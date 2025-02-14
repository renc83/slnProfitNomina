using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using slnProfitNomina.Data;

namespace slnProfitNomina
{
	public partial class frmUserLogin : Form
	{
		public frmUserLogin()
		{
			InitializeComponent();
		}

		private void bntIngresar_Click(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "" || txtPassword.Text == "")
			{
				MessageBox.Show("Ingrese los Datos Necesarios", "Baltico Consultores");
				txtUsuario.Focus();
			}
			else {
				dValidaPassword Validador = new dValidaPassword();
				if (Validador.ValidaPassword(txtUsuario.Text, txtPassword.Text))
				{
					frmEmpresas formulario = new frmEmpresas(txtUsuario.Text);
					formulario.ShowDialog();
					this.Close();
				}
				else {
					MessageBox.Show("Datos ingresados son Incorrectos", "Baltico Consultores");
					txtUsuario.Focus();
				}
			}
		}
	}
}
