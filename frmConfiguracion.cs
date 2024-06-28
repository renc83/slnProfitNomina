using Newtonsoft.Json;
using slnProfitNomina.Data;
using slnProfitNomina.Entidades;
using slnProfitNomina.SysFunciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace slnProfitNomina
{
	public partial class frmConfiguracion : Form
	{
		public frmConfiguracion()
		{
			InitializeComponent();
		}

		private void btnProbar_Click(object sender, EventArgs e)
		{
			if (!ValidaCampos())
			{
				cConectividad ObjConexion = new cConectividad(txtServidor.Text, cmbBaseDatos.Text.ToString(), txtUserName.Text, txtPassword.Text);
				ObjConexion.ProbarConexion();
				CargarBasesdeDatos();
			}
		}

		internal bool ValidaCampos() {
			bool flg_error = false;
			if (txtServidor.Text.Trim() == "")
			{
				MessageBox.Show("Nombre del servidor no puede estar en blanco", "Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				flg_error = true;
			}

				if (txtUserName.Text.Trim() == "")
				{
					MessageBox.Show("Nombre de usuario no puede estar en blanco", "Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					flg_error = true;
				}
				if (txtPassword.Text.Trim() == "")
				{
					MessageBox.Show("La contraseña no puede estar en blanco", "Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					flg_error = true;
				}

				if (cmbBaseDatos.Text.Trim() == "")
				{
					MessageBox.Show("Nombre de la base de datos no puede estar en blanco", "Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					flg_error = true;
				}
			return flg_error;
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		internal void CargarBasesdeDatos() {
			clsStaticConectionSQL.ServerName = txtServidor.Text;
			clsStaticConectionSQL.DatabaseName = cmbBaseDatos.Text;
			clsStaticConectionSQL.UsuarioID = txtUserName.Text;
			clsStaticConectionSQL.Password = txtPassword.Text;

			dCargaBasesdeDatos Carga = new dCargaBasesdeDatos();
			List<string> ListaBD = Carga.BuscaBasesdeDatos();
			LlenaCmbBaseDatos(ListaBD);
		}

		internal void LlenaCmbBaseDatos(List<string> ListaBD) {
			cmbBaseDatos.Items.Clear();
			if (ListaBD.Count > 0)
			{
				foreach (var item in ListaBD)
				{
					cmbBaseDatos.Items.Add(item);
				}
			}
			else {
				cmbBaseDatos.Items.Add("Master");
			}		
		}

		private void cmbBaseDatos_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cmbBaseDatos_MouseClick(object sender, MouseEventArgs e)
		{
			CargarBasesdeDatos();
		}

		private void btnVerClave_Click(object sender, EventArgs e)
		{
				txtPassword.PasswordChar = '*';
		}

		private void btnVerClave_MouseDown(object sender, MouseEventArgs e)
		{
				txtPassword.PasswordChar = '\0';
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (!ValidaCampos())
			{
				clsDataJson data = new clsDataJson();
				clsServerConection Servidor = new clsServerConection();
				string RutaJson = Environment.CurrentDirectory + "\\appconfig.json";
				cEncripta Encripta = new cEncripta();
				Servidor.ServerName = Encripta.cifra(txtServidor.Text.ToString());
				Servidor.DatabaseName = Encripta.cifra(cmbBaseDatos.Text.ToString());
				Servidor.UsuarioID = Encripta.cifra(txtUserName.Text.ToString());
				Servidor.Password = Encripta.cifra(txtPassword.Text.ToString());
				data.ServidorSQL = Servidor;
				//por definir
				string output = JsonConvert.SerializeObject(data, Formatting.Indented);
				File.WriteAllText(RutaJson, output);

				MessageBox.Show("La aplicacion se reiniciara", "Configuracion", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.Close();
			}
		}
	}
}
