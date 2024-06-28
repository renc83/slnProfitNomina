namespace slnProfitNomina
{
	partial class frmFiltroNomina
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroNomina));
			this.txtDesde = new System.Windows.Forms.TextBox();
			this.txtco_contdesde = new System.Windows.Forms.TextBox();
			this.dfec_fin = new System.Windows.Forms.DateTimePicker();
			this.dfec_ini = new System.Windows.Forms.DateTimePicker();
			this.txtco_conthasta = new System.Windows.Forms.TextBox();
			this.txtHasta = new System.Windows.Forms.TextBox();
			this.btnBuscarD = new System.Windows.Forms.Button();
			this.btnBuscarH = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtGridListadoNomina = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.co_gennomi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.des_gennomi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.co_cont = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fec_ini = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.fec_fin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.acciones = new System.Windows.Forms.DataGridViewButtonColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblPC = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGridListadoNomina)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtDesde
			// 
			this.txtDesde.Location = new System.Drawing.Point(277, 49);
			this.txtDesde.Name = "txtDesde";
			this.txtDesde.ReadOnly = true;
			this.txtDesde.Size = new System.Drawing.Size(280, 23);
			this.txtDesde.TabIndex = 0;
			// 
			// txtco_contdesde
			// 
			this.txtco_contdesde.Location = new System.Drawing.Point(139, 49);
			this.txtco_contdesde.Name = "txtco_contdesde";
			this.txtco_contdesde.Size = new System.Drawing.Size(99, 23);
			this.txtco_contdesde.TabIndex = 3;
			this.txtco_contdesde.Leave += new System.EventHandler(this.txtco_contdesde_Leave);
			// 
			// dfec_fin
			// 
			this.dfec_fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dfec_fin.Location = new System.Drawing.Point(351, 20);
			this.dfec_fin.Name = "dfec_fin";
			this.dfec_fin.Size = new System.Drawing.Size(206, 23);
			this.dfec_fin.TabIndex = 4;
			// 
			// dfec_ini
			// 
			this.dfec_ini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dfec_ini.Location = new System.Drawing.Point(139, 20);
			this.dfec_ini.Name = "dfec_ini";
			this.dfec_ini.Size = new System.Drawing.Size(206, 23);
			this.dfec_ini.TabIndex = 5;
			// 
			// txtco_conthasta
			// 
			this.txtco_conthasta.Location = new System.Drawing.Point(139, 78);
			this.txtco_conthasta.Name = "txtco_conthasta";
			this.txtco_conthasta.Size = new System.Drawing.Size(99, 23);
			this.txtco_conthasta.TabIndex = 7;
			this.txtco_conthasta.Leave += new System.EventHandler(this.txtco_conthasta_Leave);
			// 
			// txtHasta
			// 
			this.txtHasta.Location = new System.Drawing.Point(277, 79);
			this.txtHasta.Name = "txtHasta";
			this.txtHasta.ReadOnly = true;
			this.txtHasta.Size = new System.Drawing.Size(280, 23);
			this.txtHasta.TabIndex = 6;
			// 
			// btnBuscarD
			// 
			this.btnBuscarD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBuscarD.FlatAppearance.BorderSize = 2;
			this.btnBuscarD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarD.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarD.Image")));
			this.btnBuscarD.Location = new System.Drawing.Point(243, 48);
			this.btnBuscarD.Name = "btnBuscarD";
			this.btnBuscarD.Size = new System.Drawing.Size(29, 25);
			this.btnBuscarD.TabIndex = 9;
			this.btnBuscarD.UseVisualStyleBackColor = true;
			this.btnBuscarD.Click += new System.EventHandler(this.btnBuscarD_Click);
			// 
			// btnBuscarH
			// 
			this.btnBuscarH.FlatAppearance.BorderSize = 2;
			this.btnBuscarH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarH.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarH.Image")));
			this.btnBuscarH.Location = new System.Drawing.Point(243, 77);
			this.btnBuscarH.Name = "btnBuscarH";
			this.btnBuscarH.Size = new System.Drawing.Size(29, 25);
			this.btnBuscarH.TabIndex = 10;
			this.btnBuscarH.UseVisualStyleBackColor = true;
			this.btnBuscarH.Click += new System.EventHandler(this.btnBuscarH_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.dtGridListadoNomina);
			this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.groupBox1.Location = new System.Drawing.Point(23, 193);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
			this.groupBox1.Size = new System.Drawing.Size(579, 232);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Nominas";
			// 
			// dtGridListadoNomina
			// 
			this.dtGridListadoNomina.AllowUserToAddRows = false;
			this.dtGridListadoNomina.AllowUserToDeleteRows = false;
			this.dtGridListadoNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGridListadoNomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.co_gennomi,
            this.des_gennomi,
            this.co_cont,
            this.fec_ini,
            this.fec_fin,
            this.acciones});
			this.dtGridListadoNomina.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtGridListadoNomina.Location = new System.Drawing.Point(8, 24);
			this.dtGridListadoNomina.Name = "dtGridListadoNomina";
			this.dtGridListadoNomina.ReadOnly = true;
			this.dtGridListadoNomina.RowHeadersVisible = false;
			this.dtGridListadoNomina.RowTemplate.Height = 25;
			this.dtGridListadoNomina.Size = new System.Drawing.Size(563, 200);
			this.dtGridListadoNomina.TabIndex = 0;
			this.dtGridListadoNomina.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridListadoNomina_CellContentClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 40;
			// 
			// co_gennomi
			// 
			this.co_gennomi.HeaderText = "co_gennomi";
			this.co_gennomi.Name = "co_gennomi";
			this.co_gennomi.ReadOnly = true;
			this.co_gennomi.Visible = false;
			// 
			// des_gennomi
			// 
			this.des_gennomi.HeaderText = "Desc. Nomina";
			this.des_gennomi.Name = "des_gennomi";
			this.des_gennomi.ReadOnly = true;
			this.des_gennomi.Width = 200;
			// 
			// co_cont
			// 
			this.co_cont.HeaderText = "Contrato";
			this.co_cont.Name = "co_cont";
			this.co_cont.ReadOnly = true;
			this.co_cont.Width = 60;
			// 
			// fec_ini
			// 
			this.fec_ini.HeaderText = "Fecha Inicio";
			this.fec_ini.Name = "fec_ini";
			this.fec_ini.ReadOnly = true;
			// 
			// fec_fin
			// 
			this.fec_fin.HeaderText = "Fecha Fin";
			this.fec_fin.Name = "fec_fin";
			this.fec_fin.ReadOnly = true;
			// 
			// acciones
			// 
			this.acciones.HeaderText = "Excel";
			this.acciones.Name = "acciones";
			this.acciones.ReadOnly = true;
			this.acciones.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.acciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.acciones.Width = 60;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuario,
            this.lblPC,
            this.lblVersion});
			this.statusStrip1.Location = new System.Drawing.Point(0, 428);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(617, 22);
			this.statusStrip1.TabIndex = 12;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtHasta);
			this.groupBox2.Controls.Add(this.txtDesde);
			this.groupBox2.Controls.Add(this.txtco_contdesde);
			this.groupBox2.Controls.Add(this.btnBuscarH);
			this.groupBox2.Controls.Add(this.dfec_fin);
			this.groupBox2.Controls.Add(this.btnBuscarD);
			this.groupBox2.Controls.Add(this.dfec_ini);
			this.groupBox2.Controls.Add(this.txtco_conthasta);
			this.groupBox2.Location = new System.Drawing.Point(23, 59);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(579, 119);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filtros";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(21, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 19);
			this.label3.TabIndex = 13;
			this.label3.Text = "Contrato Hasta:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(18, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 19);
			this.label2.TabIndex = 12;
			this.label2.Text = "Contrato Desde:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(29, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 19);
			this.label1.TabIndex = 11;
			this.label1.Text = "Fecha Emisión:";
			// 
			// btnBuscar
			// 
			this.btnBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnBuscar.FlatAppearance.BorderSize = 2;
			this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
			this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnBuscar.Location = new System.Drawing.Point(23, 12);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(133, 41);
			this.btnBuscar.TabIndex = 13;
			this.btnBuscar.Text = "Buscar Nominas";
			this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// frmFiltroNomina
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(617, 450);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmFiltroNomina";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Filtro Nominas";
			this.Load += new System.EventHandler(this.frmFiltroNomina_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGridListadoNomina)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox txtDesde;
		private TextBox txtco_contdesde;
		private DateTimePicker dfec_fin;
		private DateTimePicker dfec_ini;
		private TextBox txtco_conthasta;
		private TextBox txtHasta;
		private Button btnBuscarD;
		private Button btnBuscarH;
		private GroupBox groupBox1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel lblUsuario;
		private ToolStripStatusLabel lblPC;
		private ToolStripStatusLabel lblVersion;
		private GroupBox groupBox2;
		private DataGridView dtGridListadoNomina;
		private Button btnBuscar;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn co_gennomi;
		private DataGridViewTextBoxColumn des_gennomi;
		private DataGridViewTextBoxColumn co_cont;
		private DataGridViewTextBoxColumn fec_ini;
		private DataGridViewTextBoxColumn fec_fin;
		private DataGridViewButtonColumn acciones;
		private Label label3;
		private Label label2;
		private Label label1;
	}
}