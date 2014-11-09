using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modulo_contabilidad.Negocio
{
    class csN_validartxt
    {

        public bool bvalidartxt(TextBox txtbox)
        {
            if (!string.IsNullOrEmpty(txtbox.Text))
            {
                return true;
            }
            return false;

        }
    }
}
