using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos_MRP
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        OdbcCommand comm;
        public OdbcDataReader consultageneral(string tabla)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from " + tabla + ";";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }
        public OdbcDataReader consultafiltro(string tabla, string campobusqueda)
        {
            try
            {
                cn.conexionbd();
                string consultaGraAsis = " select * from " + tabla + " WHERE pkidordenproduccion='"+campobusqueda+"';";
                comm = new OdbcCommand(consultaGraAsis, cn.conexionbd());
                OdbcDataReader mostrarResultados = comm.ExecuteReader();
                return mostrarResultados;
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
                return null;
            }
        }

        
    }
}
