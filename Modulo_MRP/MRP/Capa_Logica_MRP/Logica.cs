using Capa_Datos_MRP;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Logica_MRP
{
    
    public class Logica
    {
        Sentencias sn = new Sentencias();
        public OdbcDataReader consultageneral(string tabla)
        {
            return sn.consultageneral(tabla);
        }
        public OdbcDataReader consultafiltro(string tabla, string campobusqueda)
        {
            return sn.consultafiltro(tabla, campobusqueda);
        }
    }
}
