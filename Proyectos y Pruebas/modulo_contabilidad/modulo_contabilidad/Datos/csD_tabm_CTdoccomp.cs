using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_contabilidad.Datos
{
    class csD_tabm_CTdoccomp
    {
        public ArrayList consulta(String SQuery)
        {
           return ODBCconnector.csFunciones.alConsultar(SQuery);
        }
    }
}
