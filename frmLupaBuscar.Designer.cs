namespace slnProfitNomina
{
	partial class frmLupaBuscar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLupaBuscar));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dtGridBuscar = new System.Windows.Forms.DataGridView();
			this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtBusqueda = new System.Windows.Forms.TextBox();
			this.txtcodigo = new System.Windows.Forms.TextBox();
			this.btnAceptar = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dtGridBuscar)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.dtGridBuscar);
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.groupBox1.Location = new System.Drawing.Point(7, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(8);
			this.groupBox1.Size = new System.Drawing.Size(365, 312);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// dtGridBuscar
			// 
			this.dtGridBuscar.AllowUserToAddRows = false;
			this.dtGridBuscar.AllowUserToDeleteRows = false;
			this.dtGridBuscar.AllowUserToOrderColumns = true;
			this.dtGridBuscar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtGridBuscar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.codigo,
            this.descripcion});
			this.dtGridBuscar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dtGridBuscar.Location = new System.Drawing.Point(8, 24);
			this.dtGridBuscar.Name = "dtGridBuscar";
			this.dtGridBuscar.ReadOnly = true;
			this.dtGridBuscar.RowHeadersVisible = false;
			this.dtGridBuscar.RowTemplate.Height = 25;
			this.dtGridBuscar.Size = new System.Drawing.Size(349, 280);
			this.dtGridBuscar.TabIndex = 1;
			this.dtGridBuscar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridBuscar_CellClick);
			this.dtGridBuscar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridBuscar_CellDoubleClick);
			// 
			// ID
			// 
			this.ID.HeaderText = "ID";
			this.ID.Name = "ID";
			this.ID.ReadOnly = true;
			this.ID.Width = 40;
			// 
			// codigo
			// 
			this.codigo.HeaderText = "Codigo";
			this.codigo.Name = "codigo";
			this.codigo.ReadOnly = true;
			// 
			// descripcion
			// 
			this.descripcion.HeaderText = "Descripción";
			this.descripcion.Name = "descripcion";
			this.descripcion.ReadOnly = true;
			this.descripcion.Width = 205;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 402);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(380, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.txtBusqueda);
			this.groupBox2.Location = new System.Drawing.Point(7, 9);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(267, 51);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(10, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "Busqueda:";
			// 
			// txtBusqueda
			// 
			this.txtBusqueda.Location = new System.Drawing.Point(94, 17);
			this.txtBusqueda.Name = "txtBusqueda";
			this.txtBusqueda.Size = new System.Drawing.Size(161, 23);
			this.txtBusqueda.TabIndex = 0;
			this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
			this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyUp);
			// 
			// txtcodigo
			// 
			this.txtcodigo.Location = new System.Drawing.Point(18, 376);
			this.txtcodigo.Name = "txtcodigo";
			this.txtcodigo.Size = new System.Drawing.Size(100, 23);
			this.txtcodigo.TabIndex = 3;
			this.txtcodigo.Visible = false;
			// 
			// btnAceptar
			// 
			this.btnAceptar.FlatAppearance.BorderSize = 2;
			this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAceptar.Image = ((System.Drawing.Image)(resources.GetObject("btnAceptar.Image")));
			this.btnAceptar.Location = new System.Drawing.Point(284, 16);
			this.btnAceptar.Name = "btnAceptar";
			this.btnAceptar.Size = new System.Drawing.Size(88, 44);
			this.btnAceptar.TabIndex = 4;
			this.btnAceptar.Text = "Aceptar";
			this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAceptar.UseVisualStyleBackColor = true;
			this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
			// 
			// frmLupaBuscar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(380, 424);
			this.Controls.Add(this.btnAceptar);
			this.Controls.Add(this.txtcodigo);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmLupaBuscar";
			this.Text = "Buscar...";
			this.Load += new System.EventHandler(this.frmLupaBuscar_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dtGridBuscar)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GroupBox groupBox1;
		private DataGridView dtGridBuscar;
		private StatusStrip statusStrip1;
		private GroupBox groupBox2;
		private Label label1;
		private TextBox txtBusqueda;
		private DataGridViewTextBoxColumn ID;
		private DataGridViewTextBoxColumn codigo;
		private DataGridViewTextBoxColumn descripcion;
		private TextBox txtcodigo;
		private Button btnAceptar;
	}
}