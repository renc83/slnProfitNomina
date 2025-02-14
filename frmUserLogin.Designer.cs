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
			label1 = new Label();
			txtUsuario = new TextBox();
			bntIngresar = new Button();
			groupBox1 = new GroupBox();
			label3 = new Label();
			label2 = new Label();
			txtPassword = new TextBox();
			pictureBox1 = new PictureBox();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 9);
			label1.Name = "label1";
			label1.Size = new Size(0, 15);
			label1.TabIndex = 0;
			// 
			// txtUsuario
			// 
			txtUsuario.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsuario.Location = new Point(107, 23);
			txtUsuario.Name = "txtUsuario";
			txtUsuario.Size = new Size(200, 25);
			txtUsuario.TabIndex = 1;
			txtUsuario.TextAlign = HorizontalAlignment.Center;
			// 
			// bntIngresar
			// 
			bntIngresar.FlatAppearance.BorderSize = 2;
			bntIngresar.FlatStyle = FlatStyle.Flat;
			bntIngresar.Image = (Image)resources.GetObject("bntIngresar.Image");
			bntIngresar.Location = new Point(119, 181);
			bntIngresar.Name = "bntIngresar";
			bntIngresar.Size = new Size(103, 45);
			bntIngresar.TabIndex = 2;
			bntIngresar.Text = "Ingresar";
			bntIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
			bntIngresar.UseVisualStyleBackColor = true;
			bntIngresar.Click += bntIngresar_Click;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(txtPassword);
			groupBox1.Controls.Add(txtUsuario);
			groupBox1.Location = new Point(12, 70);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(330, 99);
			groupBox1.TabIndex = 3;
			groupBox1.TabStop = false;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label3.Location = new Point(13, 61);
			label3.Name = "label3";
			label3.Size = new Size(88, 19);
			label3.TabIndex = 5;
			label3.Text = "Contraseña:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
			label2.Location = new Point(13, 26);
			label2.Name = "label2";
			label2.Size = new Size(64, 19);
			label2.TabIndex = 4;
			label2.Text = "Usuario:";
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(107, 58);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(200, 25);
			txtPassword.TabIndex = 2;
			txtPassword.TextAlign = HorizontalAlignment.Center;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(71, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(226, 70);
			pictureBox1.TabIndex = 6;
			pictureBox1.TabStop = false;
			// 
			// frmUserLogin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			ClientSize = new Size(358, 244);
			Controls.Add(pictureBox1);
			Controls.Add(groupBox1);
			Controls.Add(label1);
			Controls.Add(bntIngresar);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "frmUserLogin";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Baltico - ProfitPlus Nomina";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox txtUsuario;
		private Button bntIngresar;
		private GroupBox groupBox1;
		private TextBox txtPassword;
		private Label label3;
		private Label label2;
		private PictureBox pictureBox1;
	}
}