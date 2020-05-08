using Capa_Datos_MRP;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Capa_Logica_MRP
{
    public class LAPMRP
    {
        SAPMRP sn = new SAPMRP();
        /*-----------------------------------------------------------------------Metodos Generales------------------------------------------------------------*/
        public string siguiente(string tabla, string campo)
        {
            string llave = sn.obtenerfinal(tabla, campo);
            return llave;
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


        public OdbcDataReader consultarEstandar()
        {
            return sn.consultaEstandar();
        }

        public OdbcDataReader consultarEstacion()
        {
            return sn.consultaEstacion();
        }


        public OdbcDataReader consultarGastos()
        {
            return sn.consultaGastos();
        }


        public OdbcDataReader consultaProduccion(string sCProduccion)
        {
            return sn.consultaProduccion(sCProduccion);
        }

        public OdbcDataReader consultaGastosP(string sCGastos)
        {
            return sn.consultaGastosP(sCGastos);
        }

        public OdbcDataReader consultaManoO(string sCProduccion)
        {
            return sn.consultaManoO(sCProduccion);
        }

        public OdbcDataReader InsertarCostosF(string sCFabricacion, string sPProduccion, string sMerma, string sCosto)
        {
            return sn.InsertarCostosF(sCFabricacion,sPProduccion,sMerma,sCosto);
        }

        public OdbcDataReader consultarCostosF()
        {
            return sn.consultaCostos();
        }
    }
}
