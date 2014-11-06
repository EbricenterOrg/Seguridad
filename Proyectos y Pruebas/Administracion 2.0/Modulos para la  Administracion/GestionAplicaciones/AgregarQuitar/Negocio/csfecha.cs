using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAplicaciones.Negocio
{
    public class csfecha
    {

        public String Sagregafecha()
        {
            
            return DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}
