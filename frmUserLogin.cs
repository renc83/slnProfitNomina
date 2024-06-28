﻿using System;
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
	public partial class frmUserLogin : Form
	{
		public frmUserLogin()
		{
			InitializeComponent();
		}

		private void bntIngresar_Click(object sender, EventArgs e)
		{
			if (txtUsuario.Text == "")
			{
				MessageBox.Show("Ingrese Usuario Profit");
				txtUsuario.Focus();
			}
			else {
				frmEmpresas formulario = new frmEmpresas(txtUsuario.Text);
				formulario.ShowDialog();
				this.Close();
			}
		}
	}
}
