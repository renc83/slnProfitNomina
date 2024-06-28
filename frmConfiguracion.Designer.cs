namespace slnProfitNomina
{
	partial class frmConfiguracion
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.txtServidor = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.btnVerClave = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cmbBaseDatos = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnProbar = new System.Windows.Forms.Button();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtServidor
			// 
			this.txtServidor.Location = new System.Drawing.Point(97, 22);
			this.txtServidor.Name = "txtServidor";
			this.txtServidor.Size = new System.Drawing.Size(232, 23);
			this.txtServidor.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtServidor);
			this.groupBox1.Location = new System.Drawing.Point(12, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(345, 159);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos Conexion";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.btnVerClave);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.txtPassword);
			this.groupBox3.Controls.Add(this.label2);
			this.groupBox3.Controls.Add(this.txtUserName);
			this.groupBox3.Location = new System.Drawing.Point(17, 51);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(312, 92);
			this.groupBox3.TabIndex = 6;
			this.groupBox3.TabStop = false;
			// 
			// btnVerClave
			// 
			this.btnVerClave.Location = new System.Drawing.Point(276, 50);
			this.btnVerClave.Name = "btnVerClave";
			this.btnVerClave.Size = new System.Drawing.Size(27, 23);
			this.btnVerClave.TabIndex = 10;
			this.btnVerClave.Text = "☺";
			this.btnVerClave.UseVisualStyleBackColor = true;
			this.btnVerClave.Click += new System.EventHandler(this.btnVerClave_Click);
			this.btnVerClave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnVerClave_MouseDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Contraseña";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(86, 50);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(188, 23);
			this.txtPassword.TabIndex = 8;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(71, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "Usuario SQL";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(86, 20);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(217, 23);
			this.txtUserName.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Servidor SQL";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cmbBaseDatos);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Location = new System.Drawing.Point(12, 218);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(345, 69);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Base de Datos";
			// 
			// cmbBaseDatos
			// 
			this.cmbBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbBaseDatos.FormattingEnabled = true;
			this.cmbBaseDatos.Items.AddRange(new object[] {
            "Master"});
			this.cmbBaseDatos.Location = new System.Drawing.Point(97, 27);
			this.cmbBaseDatos.Name = "cmbBaseDatos";
			this.cmbBaseDatos.Size = new System.Drawing.Size(232, 23);
			this.cmbBaseDatos.TabIndex = 4;
			this.cmbBaseDatos.SelectedIndexChanged += new System.EventHandler(this.cmbBaseDatos_SelectedIndexChanged);
			this.cmbBaseDatos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbBaseDatos_MouseClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nombre BD";
			// 
			// btnProbar
			// 
			this.btnProbar.Location = new System.Drawing.Point(12, 314);
			this.btnProbar.Name = "btnProbar";
			this.btnProbar.Size = new System.Drawing.Size(121, 27);
			this.btnProbar.TabIndex = 3;
			this.btnProbar.Text = "Probar Conexión";
			this.btnProbar.UseVisualStyleBackColor = true;
			this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
			// 
			// btnAceptar
			// 
			this.btnAceptar.Location = new System.Drawing.Point(185, 314);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(83, 27);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(274, 314);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(83, 27);
			this.btnCancelar.TabIndex = 5;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// frmConfiguracion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(369, 353);
			this.Controls.Add(this.btnCancelar);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.btnProbar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmConfiguracion";
			this.Text = "frmConfiguracion";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private TextBox txtServidor;
		private GroupBox groupBox1;
		private Label label1;
		private GroupBox groupBox2;
		private Label label4;
		private Button btnProbar;
		private Button btnAceptar;
		private Button btnCancelar;
		private GroupBox groupBox3;
		private Label label3;
		private TextBox txtPassword;
		private Label label2;
		private TextBox txtUserName;
		private ComboBox cmbBaseDatos;
		private Button btnVerClave;
	}
}