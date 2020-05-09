using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos_MRP;

namespace Capa_Logica_MRP
{

    public class LIIMRP
    {

        SIIMRP sn = new SIIMRP();

        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
        }
        public OdbcDataReader bitacora(string sCodigo, string sip, string Smac, string susuario, string sdepartamento, string sfechahora, string saccion, string sformulario)
        {
            return sn.insertarbitacora(sCodigo, sip, Smac, susuario, sdepartamento, sfechahora, saccion, sformulario);
        }

        public OdbcDataReader Insertar(string[] datos)
        {
            return sn.Insertar(datos);
        }
        public OdbcDataReader Eliminar(string[] datos)
        {
            return sn.Eliminar(datos);
        }

        public OdbcDataReader Modificar(string[] datos, string[] campos)
        {
            return sn.Modificar(datos, campos);
        }

        public OdbcDataReader consultaActivo()
        {
            return sn.consultaActivos();
        }

        public OdbcDataReader consultaProducto()
        {
            return sn.consultaProducto();
        }

        public OdbcDataReader BotonSolicitar(string variable)
        {
            return sn.BotonSolicitar(variable);
        }

    }
}
