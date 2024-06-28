namespace slnProfitNomina
{
	partial class frmEmpresas
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
			this.dtGridEmpresa = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cod_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.desc_empresa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
			((System.ComponentModel.ISupportInitialize)(this.dtGridEmpresa)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dtGridEmpresa
			// 
			this.dtGridEmpresa.AllowUserToAddRows = false;
			this.dtGridEmpresa.AllowUserToDeleteRows = false;
			this.dtGridEmpresa.AllowUserToOrderColumns = true;
			this.dtGridEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGridEmpresa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.cod_empresa,
            this.desc_empresa,
            this.acciones});
			this.dtGridEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtGridEmpresa.Location = new System.Drawing.Point(10, 26);
			this.dtGridEmpresa.Name = "dtGridEmpresa";
			this.dtGridEmpresa.ReadOnly = true;
			this.dtGridEmpresa.RowHeadersVisible = false;
			this.dtGridEmpresa.Size = new System.Drawing.Size(452, 344);
			this.dtGridEmpresa.TabIndex = 1;
			this.dtGridEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridEmpresa_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 40;
			// 
			// cod_empresa
			// 
			this.cod_empresa.HeaderText = "cod_empresa";
			this.cod_empresa.Name = "cod_empresa";
			this.cod_empresa.ReadOnly = true;
			this.cod_empresa.Visible = false;
			// 
			// desc_empresa
			// 
			this.desc_empresa.HeaderText = "Nombre Empresa";
			this.desc_empresa.Name = "desc_empresa";
			this.desc_empresa.ReadOnly = true;
			this.desc_empresa.Width = 300;
			// 
			// acciones
			// 
			this.acciones.HeaderText = "Filtrar";
			this.acciones.Name = "acciones";
			this.acciones.ReadOnly = true;
			this.acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// groupBox1
			// 
			this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.Controls.Add(this.dtGridEmpresa);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
			this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.groupBox1.Size = new System.Drawing.Size(472, 380);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Empresas";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblPC,
            this.lblVersion});
			this.statusStrip1.Location = new System.Drawing.Point(0, 395);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(496, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblUsuario
			// 
			this.lblUsuario.Name = "lblUsuario";
			this.lblUsuario.Size = new System.Drawing.Size(59, 17);
			this.lblUsuario.Text = "lblusuario";
			// 
			// lblPC
			// 
			this.lblPC.Name = "lblPC";
			this.lblPC.Size = new System.Drawing.Size(33, 17);
			this.lblPC.Text = "lblpc";
			// 
			// lblVersion
			// 
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.Size = new System.Drawing.Size(32, 17);
			this.lblVersion.Text = "V1.0 ";
			// 
			// frmEmpresas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(496, 417);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmEmpresas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Empresas Nomina";
			this.Load += new System.EventHandler(this.frmEmpresas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dtGridEmpresa)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private DataGridView dtGridEmpresa;
		private GroupBox groupBox1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel lblUsuario;
		private ToolStripStatusLabel lblPC;
		private ToolStripStatusLabel lblVersion;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn cod_empresa;
		private DataGridViewTextBoxColumn desc_empresa;
		private DataGridViewButtonColumn acciones;
	}
}