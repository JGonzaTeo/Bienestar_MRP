namespace Capa_Diseño_MRP.Procesos
{
    partial class Frm_Costos_Produccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Costos_Produccion));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.lblTitutlo = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dgv_Produccion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProduccion = new System.Windows.Forms.Button();
            this.btnCalculoProduccion = new System.Windows.Forms.Button();
            this.txtCostoMP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProduccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGIFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMOFinal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMPFinal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnBuscarGasto = new System.Windows.Forms.Button();
            this.txtCodGasto = new System.Windows.Forms.TextBox();
            this.btnCalcularGasto = new System.Windows.Forms.Button();
            this.Dgv_Gastos = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCostoGasto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Dgv_ManoObra = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCostoMano = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtMerma = new System.Windows.Forms.TextBox();
            this.Pnl_nombreForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produccion)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gastos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ManoObra)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.lblTitutlo);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 11);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1293, 63);
            this.Pnl_nombreForm.TabIndex = 108;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(1183, 15);
            this.btn_Ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Ayuda.Name = "btn_Ayuda";
            this.btn_Ayuda.Size = new System.Drawing.Size(44, 38);
            this.btn_Ayuda.TabIndex = 6;
            this.btn_Ayuda.UseVisualStyleBackColor = true;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_minimizar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(1136, 15);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // lblTitutlo
            // 
            this.lblTitutlo.AutoSize = true;
            this.lblTitutlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitutlo.ForeColor = System.Drawing.Color.White;
            this.lblTitutlo.Location = new System.Drawing.Point(27, 15);
            this.lblTitutlo.Name = "lblTitutlo";
            this.lblTitutlo.Size = new System.Drawing.Size(292, 25);
            this.lblTitutlo.TabIndex = 0;
            this.lblTitutlo.Text = "COSTOS DE PRODUCCION";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1233, 15);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMerma);
            this.groupBox1.Controls.Add(this.Dgv_Produccion);
            this.groupBox1.Controls.Add(this.btnBuscarProduccion);
            this.groupBox1.Controls.Add(this.btnCalculoProduccion);
            this.groupBox1.Controls.Add(this.txtCostoMP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProduccion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 267);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Materia Prima";
            // 
            // Dgv_Produccion
            // 
            this.Dgv_Produccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Produccion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgv_Produccion.Location = new System.Drawing.Point(0, 118);
            this.Dgv_Produccion.Name = "Dgv_Produccion";
            this.Dgv_Produccion.RowHeadersWidth = 51;
            this.Dgv_Produccion.RowTemplate.Height = 24;
            this.Dgv_Produccion.Size = new System.Drawing.Size(638, 108);
            this.Dgv_Produccion.TabIndex = 17;
            this.Dgv_Produccion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Codigo Formula";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Producto Final";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Materia Prima";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cantidad";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // btnBuscarProduccion
            // 
            this.btnBuscarProduccion.Location = new System.Drawing.Point(595, 39);
            this.btnBuscarProduccion.Name = "btnBuscarProduccion";
            this.btnBuscarProduccion.Size = new System.Drawing.Size(37, 27);
            this.btnBuscarProduccion.TabIndex = 11;
            this.btnBuscarProduccion.Text = "B";
            this.btnBuscarProduccion.UseVisualStyleBackColor = true;
            this.btnBuscarProduccion.Click += new System.EventHandler(this.Button6_Click);
            // 
            // btnCalculoProduccion
            // 
            this.btnCalculoProduccion.Location = new System.Drawing.Point(6, 240);
            this.btnCalculoProduccion.Name = "btnCalculoProduccion";
            this.btnCalculoProduccion.Size = new System.Drawing.Size(107, 27);
            this.btnCalculoProduccion.TabIndex = 10;
            this.btnCalculoProduccion.Text = "Calcular";
            this.btnCalculoProduccion.UseVisualStyleBackColor = true;
            this.btnCalculoProduccion.Click += new System.EventHandler(this.BtnCalculoProduccion_Click);
            // 
            // txtCostoMP
            // 
            this.txtCostoMP.Location = new System.Drawing.Point(512, 240);
            this.txtCostoMP.Name = "txtCostoMP";
            this.txtCostoMP.Size = new System.Drawing.Size(126, 22);
            this.txtCostoMP.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Costo Materia Prima";
            // 
            // txtProduccion
            // 
            this.txtProduccion.Location = new System.Drawing.Point(460, 41);
            this.txtProduccion.Name = "txtProduccion";
            this.txtProduccion.Size = new System.Drawing.Size(126, 22);
            this.txtProduccion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Codigo Produccion";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(171, 41);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(126, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Operacion";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCalcularTotal);
            this.groupBox4.Controls.Add(this.txtTotal);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtGIFinal);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtMOFinal);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtMPFinal);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(666, 366);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(600, 243);
            this.groupBox4.TabIndex = 112;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Costos Totales";
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Location = new System.Drawing.Point(470, 188);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(107, 27);
            this.btnCalcularTotal.TabIndex = 21;
            this.btnCalcularTotal.Text = "Calcular";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.BtnCalcularTotal_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(318, 188);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(126, 22);
            this.txtTotal.TabIndex = 23;
            this.txtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(189, 188);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Total";
            // 
            // txtGIFinal
            // 
            this.txtGIFinal.Enabled = false;
            this.txtGIFinal.Location = new System.Drawing.Point(318, 132);
            this.txtGIFinal.Name = "txtGIFinal";
            this.txtGIFinal.Size = new System.Drawing.Size(126, 22);
            this.txtGIFinal.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Gastos Indirectos";
            // 
            // txtMOFinal
            // 
            this.txtMOFinal.Enabled = false;
            this.txtMOFinal.Location = new System.Drawing.Point(318, 90);
            this.txtMOFinal.Name = "txtMOFinal";
            this.txtMOFinal.Size = new System.Drawing.Size(126, 22);
            this.txtMOFinal.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(189, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Mano de Obra";
            // 
            // txtMPFinal
            // 
            this.txtMPFinal.Enabled = false;
            this.txtMPFinal.Location = new System.Drawing.Point(318, 43);
            this.txtMPFinal.Name = "txtMPFinal";
            this.txtMPFinal.Size = new System.Drawing.Size(126, 22);
            this.txtMPFinal.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(189, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Materia Prima";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnBuscarGasto);
            this.groupBox3.Controls.Add(this.txtCodGasto);
            this.groupBox3.Controls.Add(this.btnCalcularGasto);
            this.groupBox3.Controls.Add(this.Dgv_Gastos);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCostoGasto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(0, 366);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(656, 243);
            this.groupBox3.TabIndex = 111;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gastos Indirectos";
            // 
            // btnBuscarGasto
            // 
            this.btnBuscarGasto.Location = new System.Drawing.Point(252, 41);
            this.btnBuscarGasto.Name = "btnBuscarGasto";
            this.btnBuscarGasto.Size = new System.Drawing.Size(37, 27);
            this.btnBuscarGasto.TabIndex = 18;
            this.btnBuscarGasto.Text = "B";
            this.btnBuscarGasto.UseVisualStyleBackColor = true;
            this.btnBuscarGasto.Click += new System.EventHandler(this.BtnBuscarGasto_Click);
            // 
            // txtCodGasto
            // 
            this.txtCodGasto.Location = new System.Drawing.Point(120, 44);
            this.txtCodGasto.Name = "txtCodGasto";
            this.txtCodGasto.Size = new System.Drawing.Size(126, 22);
            this.txtCodGasto.TabIndex = 16;
            // 
            // btnCalcularGasto
            // 
            this.btnCalcularGasto.Location = new System.Drawing.Point(6, 204);
            this.btnCalcularGasto.Name = "btnCalcularGasto";
            this.btnCalcularGasto.Size = new System.Drawing.Size(107, 27);
            this.btnCalcularGasto.TabIndex = 13;
            this.btnCalcularGasto.Text = "Calcular";
            this.btnCalcularGasto.UseVisualStyleBackColor = true;
            this.btnCalcularGasto.Click += new System.EventHandler(this.BtnCalcularGasto_Click);
            // 
            // Dgv_Gastos
            // 
            this.Dgv_Gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Gastos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.Dgv_Gastos.Location = new System.Drawing.Point(6, 90);
            this.Dgv_Gastos.Name = "Dgv_Gastos";
            this.Dgv_Gastos.RowHeadersWidth = 51;
            this.Dgv_Gastos.RowTemplate.Height = 24;
            this.Dgv_Gastos.Size = new System.Drawing.Size(638, 108);
            this.Dgv_Gastos.TabIndex = 15;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Codigo Gastos";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Valor";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo de Gasto";
            // 
            // txtCostoGasto
            // 
            this.txtCostoGasto.Location = new System.Drawing.Point(518, 204);
            this.txtCostoGasto.Name = "txtCostoGasto";
            this.txtCostoGasto.Size = new System.Drawing.Size(126, 22);
            this.txtCostoGasto.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(399, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Costo de Gastos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtHoras);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Dgv_ManoObra);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtCostoMano);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(666, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 257);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mano de Obra";
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(158, 34);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(126, 22);
            this.txtHoras.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Total de Horas";
            // 
            // Dgv_ManoObra
            // 
            this.Dgv_ManoObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_ManoObra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.Dgv_ManoObra.Location = new System.Drawing.Point(1, 69);
            this.Dgv_ManoObra.Name = "Dgv_ManoObra";
            this.Dgv_ManoObra.RowHeadersWidth = 51;
            this.Dgv_ManoObra.RowTemplate.Height = 24;
            this.Dgv_ManoObra.Size = new System.Drawing.Size(599, 133);
            this.Dgv_ManoObra.TabIndex = 18;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Codigo Estacion";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Nombre Estacion";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Codigo Empleado";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Sueldo";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 27);
            this.button2.TabIndex = 11;
            this.button2.Text = "Calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // txtCostoMano
            // 
            this.txtCostoMano.Location = new System.Drawing.Point(474, 224);
            this.txtCostoMano.Name = "txtCostoMano";
            this.txtCostoMano.Size = new System.Drawing.Size(126, 22);
            this.txtCostoMano.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Costo Mano de Obra";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(709, 637);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 27);
            this.button5.TabIndex = 114;
            this.button5.Text = "Cancelar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(491, 637);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 27);
            this.button4.TabIndex = 113;
            this.button4.Text = "Aceptar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // txtMerma
            // 
            this.txtMerma.Enabled = false;
            this.txtMerma.Location = new System.Drawing.Point(460, 79);
            this.txtMerma.Name = "txtMerma";
            this.txtMerma.Size = new System.Drawing.Size(126, 22);
            this.txtMerma.TabIndex = 18;
            this.txtMerma.Text = "0";
            this.txtMerma.Visible = false;
            // 
            // Frm_Costos_Produccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 676);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Costos_Produccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Costos_Produccion";
            this.Load += new System.EventHandler(this.Frm_Costos_Produccion_Load);
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Produccion)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Gastos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_ManoObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label lblTitutlo;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculoProduccion;
        private System.Windows.Forms.TextBox txtCostoMP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProduccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGIFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMOFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMPFinal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView Dgv_Gastos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCostoGasto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCostoMano;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnBuscarProduccion;
        private System.Windows.Forms.Button btnCalcularGasto;
        private System.Windows.Forms.DataGridView Dgv_Produccion;
        private System.Windows.Forms.TextBox txtCodGasto;
        private System.Windows.Forms.Button btnBuscarGasto;
        private System.Windows.Forms.DataGridView Dgv_ManoObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.TextBox txtMerma;
    }
}