using Capa_Diseño_MRP.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Diseño_MRP.Mantenimientos;
using Capa_Diseño_MRP.Procesos;

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

        bool ventanaBodegaInterna = false;
        Frm_MantBodegaInterna bodega = new Frm_MantBodegaInterna();

        private void BodegaInternaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_MantBodegaInterna);
            if (ventanaBodegaInterna == false || frmC == null)
            {
                if (frmC == null)
                {
                    bodega = new Frm_MantBodegaInterna();
                }

                bodega.MdiParent = this;
                bodega.Show();
                Application.DoEvents();
                ventanaBodegaInterna = true;
            }
            else
            {
                bodega.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        

        private void BodegaInternaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        bool ventanaSolicitud = false;
        Frm_SolicitudCompra solicitud = new Frm_SolicitudCompra();

        private void SolicitudDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_SolicitudCompra);
            if (ventanaSolicitud == false || frmC == null)
            {
                if (frmC == null)
                {
                    solicitud = new Frm_SolicitudCompra();
                }

                solicitud.MdiParent = this;
                solicitud.Show();
                Application.DoEvents();
                ventanaSolicitud = true;
            }
            else
            {
                solicitud.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
