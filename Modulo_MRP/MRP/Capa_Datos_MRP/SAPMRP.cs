using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_MRP
{
  public class SAPMRP
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        //--------------------------------------------------------------------Metodo General--------------------------------------------------------------------//
        public string obtenerfinal(string tabla, string campo)
        {
            String camporesultante = "";
            try
            {
                string sql = "SELECT MAX(" + campo + "+1) FROM " + tabla + ";"; //SELECT MAX(idFuncion) FROM `funciones`     
                OdbcCommand command = new OdbcCommand(sql, cn.conexionbd());
                OdbcDataReader reader = command.ExecuteReader();
                reader.Read();
                camporesultante = reader.GetValue(0).ToString();
                //Console.WriteLine("El resultado es: " + camporesultante);
                if (String.IsNullOrEmpty(camporesultante))
                    camporesultante = "1";
            }
            catch (Exception)
            {
                Console.WriteLine(camporesultante);
            }
            return camporesultante;
        }

        public OdbcDataReader Insertar(string[] datos)
        {
            string query = "";
            for (int i = 1; i < datos.Length; i++)
            {
                query += "'";
                query += datos[i];
                if (i == datos.Length - 1)
                    query += "'";
                else
                    query += "',";
            }
            try
            {
                cn.conexionbd();
                string consulta = "insert into " + datos[0] + " values(" + query + ");";
                Console.WriteLine(consulta);
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Eliminar(string[] datos)
        {
            try
            {
                cn.conexionbd();
                string consulta = "UPDATE " + datos[0] + " set estado='0' where " + datos[2] + " = '" + datos[1] + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader Modificar(string[] datos, string[] campos)
        {
            string query = "";
            int n = 1;
            query += " set ";
            for (int i = 2; i < datos.Length; i++)
            {
                query += campos[n];
                query += " = '";
                query += datos[i];
                if (i == datos.Length - 1)
                    query += "'";
                else
                    query += "',";
                n++;
            }

            try
            {
                cn.conexionbd();
                string consulta = "UPDATE " + datos[0] + query + " where " + campos[0] + " = '" + datos[1] + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }


        public OdbcDataReader consultaEstandar()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM estandardecalidad WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        public OdbcDataReader consultaEstacion()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM estacion WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader consultaGastos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM gastos_indirectos WHERE estado = 1 ;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        public OdbcDataReader consultaProduccion(string sCProduccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select fe.pkidformulaencabezado , fe.pkidProducto, fd.pkidProducto, fd.cantidad, p.Precio from formula_encabezado fe inner join formula_detalle fd on fe.pkidformulaencabezado = fd.pkidformulaencabezado inner join detalle_produccion dp on fd.pkidformulaencabezado = dp.pkidformula inner join producto p on p.pkidProducto = fe.pkidProducto inner join procesoproduccion pc on pc.pkidencabezadop = dp.pkidencabezadop  where pc.pkidprocesoproduccion ='" + sCProduccion + "';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }

        public OdbcDataReader consultaGastosP(string sCGastos)
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM gastos_indirectos WHERE pkidgastos_indirectos ='"+sCGastos+"';";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        public OdbcDataReader consultaManoO(string sCProduccion)
        {
            try
            {
                cn.conexionbd();
                string consulta = "Select e.pkidestacion, e.nombre, e.pkcodigoempleado, p.sueldo from estacion e inner join procesoproduccion pp on pp.pkidestacion = e.pkidestacion inner join empleado em on em.pkcodigoempleado = e.pkcodigoempleado inner join puesto p on p.fkcodigoempleado = em.pkcodigoempleado where pp.pkidprocesoproduccion = '" + sCProduccion + "'; ";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }


        public OdbcDataReader InsertarCostosF(string sCFabricacion, string sPProduccion, string sMerma, string sCosto)
        {
            try
            {
                cn.conexionbd();
                string consulta = "insert into costodefabricacion values(" + sCFabricacion + ", '" + sPProduccion + "' ,'" + sMerma +
                    "' ,'" + sCosto + "');";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        public OdbcDataReader consultaCostos()
        {
            try
            {
                cn.conexionbd();
                string consulta = "SELECT * FROM costodefabricacion;";
                comm = new OdbcCommand(consulta, cn.conexionbd());
                OdbcDataReader mostrar = comm.ExecuteReader();
                return mostrar;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }

        }
    }
}
