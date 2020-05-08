﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica_MRP;
using System.Data.Odbc;

namespace Capa_Diseño_MRP.Consultas
{
    public partial class Consulta_CuentasContables : Form
    {
        LFCMRP logic = new LFCMRP();
        public Consulta_CuentasContables()
        {
            InitializeComponent();
            Dgv_consultaCuentasContables.Rows.Clear();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void MostrarConsulta()
        {
            OdbcDataReader mostrarDatos = logic.ConsultaCuentasContables();
            try
            {
                while (mostrarDatos.Read())
                {
                    Dgv_consultaCuentasContables.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2), mostrarDatos.GetString(3));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_consultaCuentasContables.Rows.Clear();
            MostrarConsulta();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaCuentasContables.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
