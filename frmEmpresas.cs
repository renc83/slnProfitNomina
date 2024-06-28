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
	public partial class frmEmpresas : Form
	{
		string _usuarioProfit;
		public frmEmpresas(string UsuarioProfit)
		{
			InitializeComponent();
			_usuarioProfit = UsuarioProfit;
		}

		private void btnConfSP_Click(object sender, EventArgs e)
		{
			
		}

		private void frmEmpresas_Load(object sender, EventArgs e)
		{
			LLenaEmpresas();
			lblPC.Text = System.Environment.MachineName;
			lblUsuario.Text = System.Environment.UserName;
		}
		internal void LLenaEmpresas() {
			List<eEmpresasNomina> ListadoEmpresas = new List<eEmpresasNomina>();
			dEmpresasNomina_S datEmpresa = new dEmpresasNomina_S();
			ListadoEmpresas.Clear();
			ListadoEmpresas = datEmpresa.BuscarEmpresasNomina(_usuarioProfit);
			LlenaDataGrid(ListadoEmpresas);
		}

		internal void LlenaDataGrid(List<eEmpresasNomina> ListadoEmpresas) {
			dtGridEmpresa.Rows.Clear();
			int i = 1;
			foreach (eEmpresasNomina item in ListadoEmpresas)
			{
				dtGridEmpresa.Rows.Add();
				int fila = dtGridEmpresa.Rows.Count - 1;
				dtGridEmpresa["ID", fila].Value = i;
				dtGridEmpresa["cod_empresa", fila].Value = item.cod_empresa;
				dtGridEmpresa["desc_empresa", fila].Value  = item.desc_empresa;
				dtGridEmpresa["acciones", fila].Value = "Buscar";
				i++;
			}

		}

		private void dtGridEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 3) //ESTADO
			{
				if (dtGridEmpresa.Rows.Count != e.RowIndex)
				{
					string cod_empresa = (dtGridEmpresa["cod_empresa", e.RowIndex].Value.ToString());
					frmFiltroNomina procesador = new frmFiltroNomina(cod_empresa);
					procesador.ShowDialog();
				}
			}
		}
	}
}
