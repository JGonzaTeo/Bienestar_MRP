namespace Capa_Diseño_MRP.Procesos
{
    partial class Frm_ControlCalidadProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ControlCalidadProducto));
            this.Pnl_nombreForm = new System.Windows.Forms.Panel();
            this.btn_Ayuda = new System.Windows.Forms.Button();
            this.btn_minimizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.gpb_producto = new System.Windows.Forms.GroupBox();
            this.btn_estandar = new System.Windows.Forms.Button();
            this.btn_estacion = new System.Windows.Forms.Button();
            this.btn_producción = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_estandar = new System.Windows.Forms.TextBox();
            this.Txt_estacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_cantidad = new System.Windows.Forms.TextBox();
            this.Txt_produccion = new System.Windows.Forms.TextBox();
            this.Lbl_codigoacreedor = new System.Windows.Forms.Label();
            this.cb_no = new System.Windows.Forms.CheckBox();
            this.cb_si = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpb_detalle = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_descripcion = new System.Windows.Forms.TextBox();
            this.gpb_opciones = new System.Windows.Forms.GroupBox();
            this.Btn_merma = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.Pnl_nombreForm.SuspendLayout();
            this.gpb_producto.SuspendLayout();
            this.gpb_detalle.SuspendLayout();
            this.gpb_opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_nombreForm
            // 
            this.Pnl_nombreForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(157)))), ((int)(((byte)(250)))));
            this.Pnl_nombreForm.Controls.Add(this.btn_Ayuda);
            this.Pnl_nombreForm.Controls.Add(this.btn_minimizar);
            this.Pnl_nombreForm.Controls.Add(this.label1);
            this.Pnl_nombreForm.Controls.Add(this.btn_cerrar);
            this.Pnl_nombreForm.Location = new System.Drawing.Point(0, 0);
            this.Pnl_nombreForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pnl_nombreForm.Name = "Pnl_nombreForm";
            this.Pnl_nombreForm.Size = new System.Drawing.Size(1460, 63);
            this.Pnl_nombreForm.TabIndex = 112;
            // 
            // btn_Ayuda
            // 
            this.btn_Ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Ayuda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Ayuda.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ayuda.Image")));
            this.btn_Ayuda.Location = new System.Drawing.Point(970, 11);
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
            this.btn_minimizar.Location = new System.Drawing.Point(923, 11);
            this.btn_minimizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(44, 38);
            this.btn_minimizar.TabIndex = 5;
            this.btn_minimizar.UseVisualStyleBackColor = true;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control Calidad de Producto";
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cerrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(1020, 11);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(44, 38);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // gpb_producto
            // 
            this.gpb_producto.Controls.Add(this.btn_estandar);
            this.gpb_producto.Controls.Add(this.btn_estacion);
            this.gpb_producto.Controls.Add(this.btn_producción);
            this.gpb_producto.Controls.Add(this.label3);
            this.gpb_producto.Controls.Add(this.Txt_estandar);
            this.gpb_producto.Controls.Add(this.Txt_estacion);
            this.gpb_producto.Controls.Add(this.label4);
            this.gpb_producto.Controls.Add(this.label2);
            this.gpb_producto.Controls.Add(this.Txt_cantidad);
            this.gpb_producto.Controls.Add(this.Txt_produccion);
            this.gpb_producto.Controls.Add(this.Lbl_codigoacreedor);
            this.gpb_producto.Location = new System.Drawing.Point(32, 101);
            this.gpb_producto.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_producto.Name = "gpb_producto";
            this.gpb_producto.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_producto.Size = new System.Drawing.Size(1041, 194);
            this.gpb_producto.TabIndex = 113;
            this.gpb_producto.TabStop = false;
            this.gpb_producto.Text = "Producto";
            // 
            // btn_estandar
            // 
            this.btn_estandar.Image = ((System.Drawing.Image)(resources.GetObject("btn_estandar.Image")));
            this.btn_estandar.Location = new System.Drawing.Point(879, 107);
            this.btn_estandar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_estandar.Name = "btn_estandar";
            this.btn_estandar.Size = new System.Drawing.Size(72, 52);
            this.btn_estandar.TabIndex = 141;
            this.btn_estandar.UseVisualStyleBackColor = true;
            this.btn_estandar.Click += new System.EventHandler(this.btn_estandar_Click);
            // 
            // btn_estacion
            // 
            this.btn_estacion.Image = ((System.Drawing.Image)(resources.GetObject("btn_estacion.Image")));
            this.btn_estacion.Location = new System.Drawing.Point(879, 28);
            this.btn_estacion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_estacion.Name = "btn_estacion";
            this.btn_estacion.Size = new System.Drawing.Size(72, 52);
            this.btn_estacion.TabIndex = 151;
            this.btn_estacion.UseVisualStyleBackColor = true;
            this.btn_estacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_producción
            // 
            this.btn_producción.Image = ((System.Drawing.Image)(resources.GetObject("btn_producción.Image")));
            this.btn_producción.Location = new System.Drawing.Point(405, 26);
            this.btn_producción.Margin = new System.Windows.Forms.Padding(4);
            this.btn_producción.Name = "btn_producción";
            this.btn_producción.Size = new System.Drawing.Size(72, 52);
            this.btn_producción.TabIndex = 150;
            this.btn_producción.UseVisualStyleBackColor = true;
            this.btn_producción.Click += new System.EventHandler(this.btn_producción_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(516, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 146;
            this.label3.Text = "Estandar de Calidad";
            // 
            // Txt_estandar
            // 
            this.Txt_estandar.Location = new System.Drawing.Point(663, 122);
            this.Txt_estandar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_estandar.Name = "Txt_estandar";
            this.Txt_estandar.Size = new System.Drawing.Size(193, 22);
            this.Txt_estandar.TabIndex = 147;
            // 
            // Txt_estacion
            // 
            this.Txt_estacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estacion.Location = new System.Drawing.Point(663, 47);
            this.Txt_estacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_estacion.Name = "Txt_estacion";
            this.Txt_estacion.Size = new System.Drawing.Size(193, 23);
            this.Txt_estacion.TabIndex = 145;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 144;
            this.label4.Text = "Estación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 142;
            this.label2.Text = "Cantidad Representativa";
            // 
            // Txt_cantidad
            // 
            this.Txt_cantidad.Location = new System.Drawing.Point(189, 118);
            this.Txt_cantidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_cantidad.Name = "Txt_cantidad";
            this.Txt_cantidad.Size = new System.Drawing.Size(193, 22);
            this.Txt_cantidad.TabIndex = 143;
            // 
            // Txt_produccion
            // 
            this.Txt_produccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_produccion.Location = new System.Drawing.Point(189, 43);
            this.Txt_produccion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_produccion.Name = "Txt_produccion";
            this.Txt_produccion.Size = new System.Drawing.Size(193, 23);
            this.Txt_produccion.TabIndex = 141;
            // 
            // Lbl_codigoacreedor
            // 
            this.Lbl_codigoacreedor.AutoSize = true;
            this.Lbl_codigoacreedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoacreedor.Location = new System.Drawing.Point(21, 47);
            this.Lbl_codigoacreedor.Name = "Lbl_codigoacreedor";
            this.Lbl_codigoacreedor.Size = new System.Drawing.Size(127, 17);
            this.Lbl_codigoacreedor.TabIndex = 140;
            this.Lbl_codigoacreedor.Text = "Codigo Producción";
            // 
            // cb_no
            // 
            this.cb_no.AutoSize = true;
            this.cb_no.Location = new System.Drawing.Point(250, 46);
            this.cb_no.Margin = new System.Windows.Forms.Padding(4);
            this.cb_no.Name = "cb_no";
            this.cb_no.Size = new System.Drawing.Size(48, 21);
            this.cb_no.TabIndex = 154;
            this.cb_no.Text = "No";
            this.cb_no.UseVisualStyleBackColor = true;
            // 
            // cb_si
            // 
            this.cb_si.AutoSize = true;
            this.cb_si.Location = new System.Drawing.Point(162, 46);
            this.cb_si.Margin = new System.Windows.Forms.Padding(4);
            this.cb_si.Name = "cb_si";
            this.cb_si.Size = new System.Drawing.Size(42, 21);
            this.cb_si.TabIndex = 153;
            this.cb_si.Text = "Si";
            this.cb_si.UseVisualStyleBackColor = true;
            this.cb_si.Click += new System.EventHandler(this.cb_si_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 152;
            this.label6.Text = "Defecto";
            // 
            // gpb_detalle
            // 
            this.gpb_detalle.Controls.Add(this.cb_no);
            this.gpb_detalle.Controls.Add(this.label7);
            this.gpb_detalle.Controls.Add(this.cb_si);
            this.gpb_detalle.Controls.Add(this.label6);
            this.gpb_detalle.Controls.Add(this.Txt_descripcion);
            this.gpb_detalle.Location = new System.Drawing.Point(39, 306);
            this.gpb_detalle.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_detalle.Name = "gpb_detalle";
            this.gpb_detalle.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_detalle.Size = new System.Drawing.Size(683, 253);
            this.gpb_detalle.TabIndex = 114;
            this.gpb_detalle.TabStop = false;
            this.gpb_detalle.Text = "Detalle de Control de Calidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 23;
            this.label7.Text = "Descripción";
            // 
            // Txt_descripcion
            // 
            this.Txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descripcion.Location = new System.Drawing.Point(136, 116);
            this.Txt_descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_descripcion.Multiline = true;
            this.Txt_descripcion.Name = "Txt_descripcion";
            this.Txt_descripcion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_descripcion.Size = new System.Drawing.Size(487, 96);
            this.Txt_descripcion.TabIndex = 22;
            // 
            // gpb_opciones
            // 
            this.gpb_opciones.Controls.Add(this.Btn_merma);
            this.gpb_opciones.Controls.Add(this.button4);
            this.gpb_opciones.Controls.Add(this.button6);
            this.gpb_opciones.Location = new System.Drawing.Point(755, 314);
            this.gpb_opciones.Margin = new System.Windows.Forms.Padding(4);
            this.gpb_opciones.Name = "gpb_opciones";
            this.gpb_opciones.Padding = new System.Windows.Forms.Padding(4);
            this.gpb_opciones.Size = new System.Drawing.Size(318, 245);
            this.gpb_opciones.TabIndex = 115;
            this.gpb_opciones.TabStop = false;
            this.gpb_opciones.Text = "Opciones";
            // 
            // Btn_merma
            // 
            this.Btn_merma.Location = new System.Drawing.Point(91, 142);
            this.Btn_merma.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_merma.Name = "Btn_merma";
            this.Btn_merma.Size = new System.Drawing.Size(141, 28);
            this.Btn_merma.TabIndex = 149;
            this.Btn_merma.Text = "Agregar Merma";
            this.Btn_merma.UseVisualStyleBackColor = true;
            this.Btn_merma.Click += new System.EventHandler(this.Btn_merma_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(190, 82);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 146;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(33, 82);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 28);
            this.button6.TabIndex = 145;
            this.button6.Text = "Guardar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Frm_ControlCalidadProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 592);
            this.Controls.Add(this.gpb_opciones);
            this.Controls.Add(this.gpb_detalle);
            this.Controls.Add(this.gpb_producto);
            this.Controls.Add(this.Pnl_nombreForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_ControlCalidadProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ControlCalidadProducto";
            this.Pnl_nombreForm.ResumeLayout(false);
            this.Pnl_nombreForm.PerformLayout();
            this.gpb_producto.ResumeLayout(false);
            this.gpb_producto.PerformLayout();
            this.gpb_detalle.ResumeLayout(false);
            this.gpb_detalle.PerformLayout();
            this.gpb_opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_nombreForm;
        private System.Windows.Forms.Button btn_Ayuda;
        private System.Windows.Forms.Button btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.GroupBox gpb_producto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_estandar;
        private System.Windows.Forms.TextBox Txt_estacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_cantidad;
        private System.Windows.Forms.TextBox Txt_produccion;
        private System.Windows.Forms.Label Lbl_codigoacreedor;
        private System.Windows.Forms.CheckBox cb_no;
        private System.Windows.Forms.CheckBox cb_si;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_estandar;
        private System.Windows.Forms.Button btn_estacion;
        private System.Windows.Forms.Button btn_producción;
        private System.Windows.Forms.GroupBox gpb_detalle;
        private System.Windows.Forms.TextBox Txt_descripcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gpb_opciones;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Btn_merma;
    }
}