using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Capa_Logica_MRP;
using Capa_Diseño_MRP.Mantenimientos;

namespace Capa_Diseño_MRP.Procesos
{
    public partial class Frm_Poliza : Form
    {
        LFCMRP logic = new LFCMRP();
        string sueldobase;
        string horas_extras;
        int sueldo;
        string materiap;

        public Frm_Poliza()

        {
            InitializeComponent();
            Txt_numeropoliza.Text = logic.siguiente("mydb.polizadetalle_mrp", "pkidpolizaencabezado_MRP");

            MateriaPrima();
            suelds();
            sueldos();
            operaciones();
            cuentas();
            cuentas2();
            sumasiguales();



        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Ayuda_Click(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void operaciones()
        {

            int montohora;

            montohora = int.Parse(horas_extras) * 15;
            sueldo = int.Parse(sueldobase) + montohora;





            Dgv_poliza.Rows.Add("001", "SUELDOS ", sueldo.ToString(), "");









        }
        public void suelds()
        {
            OdbcDataReader desplegar = logic.horasextras();
            try
            {
                while (desplegar.Read())
                {

                    horas_extras = desplegar.GetString(0);


                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
        public void descativar()
        {
            if (txt_debe.Text != "")
            {
                btn_actualizar.Visible = false;
                btn_ingresarCuenta.Visible = false;
            }
        }
        public void sumasiguales()
        {
            OdbcDataReader desplegar = logic.iguales(Txt_numeropoliza.Text);
            try
            {
                while (desplegar.Read())
                {

                    txt_debe.Text = desplegar.GetString(0);
                    txt_haber.Text = desplegar.GetString(0);

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }





        }
        public void cuentas2()
        {
            Dgv_poliza.Rows.Add("020", "BANCOS", "", sueldo.ToString());
            Dgv_poliza.Rows.Add("050", "COMPRAS", "", materiap);

            OdbcDataReader mostrar = logic.mostrarcuenta();
            try
            {
                while (mostrar.Read())
                {


                    Dgv_poliza.Rows.Add(mostrar.GetString(0), mostrar.GetString(1) + " POR PAGAR", "", mostrar.GetString(2));

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }




        }


        public void cuentas()
        {

            OdbcDataReader mostrar = logic.mostrarcuenta();
            try
            {
                while (mostrar.Read())
                {


                    Dgv_poliza.Rows.Add(mostrar.GetString(0), mostrar.GetString(1), mostrar.GetString(2));



                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }




        }
        public void sueldos()
        {

            OdbcDataReader mostrar = logic.sueldobase();
            try
            {
                while (mostrar.Read())
                {

                    sueldobase = mostrar.GetString(0);


                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }




        }
        public void MateriaPrima()
        {

            OdbcDataReader mostrar = logic.materiaprima();
            try
            {
                while (mostrar.Read())
                {


                    Dgv_poliza.Rows.Add("010", "Materia Prima", mostrar.GetString(0), "");

                    materiap = mostrar.GetString(0);

                }



            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }




        }
        public void Guardar_Encabezado()

        {
            string numeroPoliza = Convert.ToString(Txt_numeropoliza.Text);
            string TipoPoliza = Convert.ToString(Txt_tipo.Text);
            string Descripcion = Convert.ToString(txt_descripcion.Text);


            string fechaInicio = dtp_iniciopoliza.Value.ToString("yyyy-MM-dd");
            string fechaFin = dtp_finalpoliza.Value.ToString("yyyy-MM-dd");



            OdbcDataReader insertar = logic.Insertarencabezado(numeroPoliza, fechaInicio, fechaFin, Descripcion);



        }

        public void Guardar_detalle()

        {
            foreach (DataGridViewRow row in Dgv_poliza.Rows)
            {
                string numeroPoliza = Convert.ToString(Txt_numeropoliza.Text);
                string codigo = Convert.ToString(row.Cells["Codigo"].Value);
                string debe = Convert.ToString(row.Cells["Debe"].Value);
                string haber = Convert.ToString(row.Cells["Haber"].Value);

                OdbcDataReader insertar = logic.Insertardetalle(numeroPoliza, codigo, debe, haber);



            }







        }
        private void btn_generar_Click(object sender, EventArgs e)
        {
            Guardar_Encabezado();
            Guardar_detalle();
            sumasiguales();
            descativar();
        }

        private void Dgv_poliza_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            Dgv_poliza.Rows.Clear();
            MateriaPrima();
            suelds();
            sueldos();
            operaciones();
            cuentas();
            cuentas2();
            sumasiguales();
            txt_debe.Clear();
            txt_haber.Clear();

        }

        private void btn_ingresarCuenta_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresarCuenta_Click_1(object sender, EventArgs e)
        {
            Frm_MantCuentasContables hola = new Frm_MantCuentasContables();
           hola.Show();
        }
    }
}
