using slnProfitNomina.Data;
using slnProfitNomina.Entidades;
using SpreadsheetLight;
using System.Collections.Generic;
using System.Data;

namespace slnProfitNomina
{
	public partial class frmFiltroNomina : Form
	{
		string _cod_empresa;
		List<eContratos> gListadoContratos = new List<eContratos>();
		public frmFiltroNomina(string cod_empresa)
		{
			InitializeComponent();
			_cod_empresa = cod_empresa;
		}

		private void frmFiltroNomina_Load(object sender, EventArgs e)
		{
			lblPC.Text = System.Environment.MachineName;
			lblUsuario.Text = System.Environment.UserName;
			gListadoContratos = ListaContratos(_cod_empresa);
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			eFiltroNominas Filtro = new eFiltroNominas();
			List<eNominaList> ListadoNomina = new List<eNominaList>();
			dListNominas_S dListar = new dListNominas_S();
			if (validaCampos())
			{
				Filtro.cod_empresa = _cod_empresa;
				Filtro.co_contDesde= txtco_contdesde.Text;
				Filtro.co_contHasta = txtco_conthasta.Text;
				Filtro.fec_ini = dfec_ini.Value.ToString("yyyyMMdd");
				Filtro.fec_fin = dfec_fin.Value.ToString("yyyyMMdd");
				ListadoNomina = dListar.ListarNominas(Filtro);
				if (ListadoNomina.Count > 0)
				{
					LlenaListadoNomina(ListadoNomina);
				}
				else {
					MessageBox.Show("Sin Resultados.");
				}
			}
			else {
				MessageBox.Show("Faltan Campos");
			}
		}

		internal void LlenaListadoNomina(List<eNominaList> ListadoNomina) {
			dtGridListadoNomina.Rows.Clear();
			int i = 1;
			foreach (eNominaList item in ListadoNomina)
			{
				dtGridListadoNomina.Rows.Add();
				int fila = dtGridListadoNomina.Rows.Count - 1;
				dtGridListadoNomina["ID", fila].Value = i;
				dtGridListadoNomina["co_gennomi", fila].Value = item.co_gennomi;
				dtGridListadoNomina["des_gennomi", fila].Value = item.des_gennomi;
				dtGridListadoNomina["co_cont", fila].Value = item.co_cont;
				dtGridListadoNomina["fec_ini", fila].Value = item.fec_ini;
				dtGridListadoNomina["fec_fin", fila].Value = item.fec_emis;
				dtGridListadoNomina["acciones", fila].Value = "Generar";
				i++;
			}
		}

		internal bool validaCampos() {
			bool flg = true;
			if (txtco_contdesde.Text == "" || txtco_conthasta.Text == "") {
				MessageBox.Show("Falta el Codigo del Contrato.");
				flg = false;
			}


			return flg;
		}

		private void dtGridListadoNomina_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 6) //ESTADO
			{
				if (dtGridListadoNomina.Rows.Count != e.RowIndex)
				{
					int codigonomina =Convert.ToInt32(dtGridListadoNomina["co_gennomi", e.RowIndex].Value.ToString());
					GeneraExcel(codigonomina);
				}
			}
		}

		internal void GeneraExcel(int codigonomina) {
			dDetNominaxls_S Datos = new dDetNominaxls_S();
			DataTable dtxls = new DataTable("Datos");
			eFiltroNominaDet Filtro = new eFiltroNominaDet();
			Filtro.co_gennomi = codigonomina;
			Filtro.cod_empresa = _cod_empresa;
			dtxls = Datos.DetNominaxls(Filtro);

			SaveFileDialog SaveFileDialog = new SaveFileDialog();
			SaveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";

			//genera el documento de excel
			SLDocument sl = new SLDocument();
			int iStartRowIndex = 1;
			int iStartColumnIndex = 1;

			if (SaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				string PathLogResult = SaveFileDialog.FileName;

				sl.ImportDataTable(iStartRowIndex, iStartColumnIndex, dtxls, true);
				// + 1 because the header row is included
				// - 1 because it's a counting thing, because the start row is counted.
				int iEndRowIndex = iStartRowIndex + dtxls.Rows.Count + 1 - 1;
				// - 1 because it's a counting thing, because the start column is counted.
				int iEndColumnIndex = iStartColumnIndex + dtxls.Columns.Count - 1;
				SLTable table = sl.CreateTable(iStartRowIndex, iStartColumnIndex, iEndRowIndex, iEndColumnIndex);
				//table.SetTableStyle(SLTableStyleTypeValues.Medium17);
				//table.HasTotalRow = true;
				//table.SetTotalRowFunction(5, SLTotalsRowFunctionValues.Sum);
				sl.InsertTable(table);
				sl.AutoFitColumn(iStartColumnIndex, iEndColumnIndex);				
				sl.SaveAs(PathLogResult);
				MessageBox.Show("Archivo Guardado");
			}
		}

		internal List<eContratos> ListaContratos(string cod_empresa) {
			dListContratos dContratos = new dListContratos();
			List<eContratos> Listado = new List<eContratos>();
			Listado = dContratos.ListarContratos(cod_empresa);
			return Listado;
		}

		private void txtco_contdesde_Leave(object sender, EventArgs e)
		{
			ValidaDesde();
		}
		internal void ValidaDesde() {
			List<eContratos> ListBusca = new List<eContratos>();
			if (!String.IsNullOrEmpty(txtco_contdesde.Text))
			{
				ListBusca = gListadoContratos.Where(x => x.co_cont.Trim() == txtco_contdesde.Text).ToList();
				if (ListBusca.Count == 0)
				{
					MessageBox.Show("Contrato No Existe.");
					txtco_contdesde.Focus();
				}
				else
				{
					txtDesde.Text = ListBusca[0].des_cont;
				}
			}
		}

		private void txtco_conthasta_Leave(object sender, EventArgs e)
		{
			Validahasta();
		}
		internal void Validahasta() {
			List<eContratos> ListBusca = new List<eContratos>();
			if (!String.IsNullOrEmpty(txtco_conthasta.Text))
			{
				ListBusca = gListadoContratos.Where(x => x.co_cont.Trim() == txtco_conthasta.Text).ToList();
				if (ListBusca.Count == 0)
				{
					MessageBox.Show("Contrato No Existe.");
					txtco_conthasta.Focus();
				}
				else
				{
					txtHasta.Text = ListBusca[0].des_cont;
				}
			}
		}

		private void btnBuscarD_Click(object sender, EventArgs e)
		{
			eLupaConfig config = new eLupaConfig();
			config.tabla = "contratos";
			config.ventana = "frmFiltroNomina";
			config.codempresa = _cod_empresa;
			config.campo = "txtco_contdesde";
			frmLupaBuscar Lupa = new frmLupaBuscar(config);
			Lupa.ShowDialog();
			if (!String.IsNullOrEmpty(eFiltroResultStatic.codigo))
			{
				txtco_contdesde.Text = eFiltroResultStatic.codigo;
				ValidaDesde();
			}
		}

		private void btnBuscarH_Click(object sender, EventArgs e)
		{
				eLupaConfig config = new eLupaConfig();
				config.tabla = "contratos";
				config.ventana = "frmFiltroNomina";
				config.codempresa = _cod_empresa;
				config.campo = "txtco_conthasta";
				frmLupaBuscar Lupa = new frmLupaBuscar(config);
				Lupa.ShowDialog();
			if (!String.IsNullOrEmpty(eFiltroResultStatic.codigo))
			{
				txtco_conthasta.Text = eFiltroResultStatic.codigo;
				Validahasta();
			}
		}
	}
}
