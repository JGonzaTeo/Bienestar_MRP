using Capa_Diseño_MRP.Consultas;
using Capa_Diseño_MRP.Mantenimientos;
using Capa_Diseño_MRP.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Diseño_MRP
{
    public partial class MDIMRP : Form
    {
        private int childFormNumber = 0;

        public MDIMRP()
        {
            InitializeComponent();
            this.Size = new Size(1450, 780);
            //Console.BackgroundColor = ConsoleColor.Green;
            this.BackColor = System.Drawing.Color.White;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void CerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool ventanalistaproductos = false;
        Consulta_pedidos listaproductos = new Consulta_pedidos();
        private void ListaDePedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Consulta_pedidos);
            if (ventanalistaproductos == false || frmC == null)
            {
                if (frmC == null)
                {
                    listaproductos = new Consulta_pedidos();
                }

                listaproductos.MdiParent = this;
                listaproductos.Show();
                Application.DoEvents();
                ventanalistaproductos = true;
            }
            else
            {
                listaproductos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaEstandar = false;
        Frm_Mant_EstandarCalidad estandar = new Frm_Mant_EstandarCalidad();
        private void EstandarDeCalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_EstandarCalidad);
            if (ventanaEstandar == false || frmC == null)
            {
                if (frmC == null)
                {
                    estandar = new Frm_Mant_EstandarCalidad();
                }

                estandar.MdiParent = this;
                estandar.Show();
                Application.DoEvents();
                ventanaEstandar = true;
            }
            else
            {
                estandar.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ventanaEstacion = false;
        Frm_Mant_Estacion estacion = new Frm_Mant_Estacion();
        private void EstacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Estacion);
            if (ventanaEstacion == false || frmC == null)
            {
                if (frmC == null)
                {
                    estacion = new Frm_Mant_Estacion();
                }

                estacion.MdiParent = this;
                estacion.Show();
                Application.DoEvents();
                ventanaEstacion = true;
            }
            else
            {
                estacion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }


        bool ventanaCostosP = false;
        Frm_Costos_Produccion costosP = new Frm_Costos_Produccion();
        private void CostosDeProduccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Costos_Produccion);
            if (ventanaCostosP == false || frmC == null)
            {
                if (frmC == null)
                {
                    costosP = new Frm_Costos_Produccion();
                }

                costosP.MdiParent = this;
                costosP.Show();
                Application.DoEvents();
                ventanaCostosP = true;
            }
            else
            {
                costosP.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaGastos = false;
        Frm_Mant_Gastos gastos = new Frm_Mant_Gastos();
        private void GastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Mant_Gastos);
            if (ventanaGastos == false || frmC == null)
            {
                if (frmC == null)
                {
                    gastos = new Frm_Mant_Gastos();
                }

                gastos.MdiParent = this;
                gastos.Show();
                Application.DoEvents();
                ventanaGastos = true;
            }
            else
            {
                gastos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
        bool ventanaCProduccion = false;
        Frm_Consulta_Costos Cproduccion = new Frm_Consulta_Costos();
        private void ConsultaCostosDeFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Consulta_Costos);
            if (ventanaCProduccion == false || frmC == null)
            {
                if (frmC == null)
                {
                    Cproduccion = new Frm_Consulta_Costos();
                }

                Cproduccion.MdiParent = this;
                Cproduccion.Show();
                Application.DoEvents();
                ventanaCProduccion = true;
            }
            else
            {
                Cproduccion.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
