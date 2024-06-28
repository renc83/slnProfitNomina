namespace slnProfitNomina
{
	partial class frmUserLogin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogin));
			this.label1 = new System.Windows.Forms.Label();
			this.txtUsuario = new System.Windows.Forms.TextBox();
			this.bntIngresar = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 15);
			this.label1.TabIndex = 0;
			// 
			// txtUsuario
			// 
			this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.txtUsuario.Location = new System.Drawing.Point(25, 26);
			this.txtUsuario.Name = "txtUsuario";
			this.txtUsuario.Size = new System.Drawing.Size(219, 25);
			this.txtUsuario.TabIndex = 1;
			this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// bntIngresar
			// 
			this.bntIngresar.FlatAppearance.BorderSize = 2;
			this.bntIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bntIngresar.Image = ((System.Drawing.Image)(resources.GetObject("bntIngresar.Image")));
			this.bntIngresar.Location = new System.Drawing.Point(74, 57);
			this.bntIngresar.Name = "bntIngresar";
			this.bntIngresar.Size = new System.Drawing.Size(121, 45);
			this.bntIngresar.TabIndex = 2;
			this.bntIngresar.Text = "Ingresar";
			this.bntIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.bntIngresar.UseVisualStyleBackColor = true;
			this.bntIngresar.Click += new System.EventHandler(this.bntIngresar_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bntIngresar);
			this.groupBox1.Controls.Add(this.txtUsuario);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(266, 116);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Usuario Profit";
			// 
			// frmUserLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(290, 140);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmUserLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ingreso Usuario";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private TextBox txtUsuario;
		private Button bntIngresar;
		private GroupBox groupBox1;
	}
}