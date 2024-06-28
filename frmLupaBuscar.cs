using slnProfitNomina.Data;
using slnProfitNomina.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slnProfitNomina
{
	public partial class frmLupaBuscar : Form
	{
		eLupaConfig _configuracion;
		List<eLupaDatos> _ListadoGeneral = new List<eLupaDatos>();
		public frmLupaBuscar(eLupaConfig configuracion)
		{
			InitializeComponent();
			_configuracion = configuracion;
		}

		private void frmLupaBuscar_Load(object sender, EventArgs e)
		{
			CargarDatos();
			eFiltroResultStatic.codigo = "";
		}

		internal void CargarDatos() {
			//se debe cambiar por case, cuando se agreguen nuevos
			_ListadoGeneral = LlenaDatosContrato();
			LlenaGridDatos(_ListadoGeneral);
		}

		internal List<eLupaDatos> LlenaDatosContrato() {
			List<eLupaDatos> Listado = new List<eLupaDatos> ();
			dListContratos dContratos = new dListContratos();
			List<eContratos> ListadoContratos = new List<eContratos>();
			ListadoContratos = dContratos.ListarContratos(_configuracion.codempresa);

			foreach (eContratos item in ListadoContratos)
			{
				Listado.Add(new eLupaDatos
				{
					codigo=item.co_cont,
					descripcion=item.des_cont
				});
			}
			return Listado;
		}

		internal void LlenaGridDatos(List<eLupaDatos> Listado) {
			dtGridBuscar.Rows.Clear();
			int i = 1;
			foreach (eLupaDatos item in Listado)
			{
				dtGridBuscar.Rows.Add();
				int fila = dtGridBuscar.Rows.Count - 1;
				dtGridBuscar["ID", fila].Value = i;
				dtGridBuscar["codigo", fila].Value = item.codigo;
				dtGridBuscar["descripcion", fila].Value = item.descripcion;
				i++;
			}
		}

		private void dtGridBuscar_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				string codigo = dtGridBuscar["codigo", e.RowIndex].Value.ToString();
				txtcodigo.Text = codigo;
			}
		}

		private void dtGridBuscar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				string codigo = dtGridBuscar["codigo", e.RowIndex].Value.ToString();
				txtcodigo.Text = codigo;
				RetornaValor(codigo);
			}
		}

		internal void RetornaValor(string codigo) {
			eFiltroResultStatic.codigo = codigo;
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (txtcodigo.Text == "") {
				MessageBox.Show("Seleccione una Opcion.");
			} else {
				RetornaValor(txtcodigo.Text);
			}

		}

		private void txtBusqueda_KeyPress(object sender, KeyPressEventArgs e)
		{

		}

		private void txtBusqueda_KeyUp(object sender, KeyEventArgs e)
		{
			List<eLupaDatos> Listado = new List<eLupaDatos>();
			Listado = _ListadoGeneral.Where(x => x.descripcion.ToUpper().Contains(txtBusqueda.Text.ToUpper())
			                                  || x.codigo.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();
			LlenaGridDatos(Listado);
		}
	}
}
