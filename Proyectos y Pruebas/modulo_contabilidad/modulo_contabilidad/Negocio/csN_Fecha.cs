using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulo_contabilidad.Negocio
{
    class csN_Fecha
    {

        public string Sobtienefecha()
        {
            return DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}
