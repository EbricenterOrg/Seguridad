using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo_de_Seguridad_2._1.Datos
{
    internal class D_Conexion
    {
        private static string gsConexion = "DSN=HSCconexion";
        private static OdbcConnection ocConexion;

        protected static OdbcConnection Conexion
        {
            get { return ocConexion; }
            set { ocConexion = value; }
        }

        public D_Conexion()
        {
            ocConexion = new OdbcConnection(gsConexion);
        }

        protected static bool bAbrirConexion()
        {
            try
            {
                ocConexion = new OdbcConnection(gsConexion);
                ocConexion.Open();
                return true;
            }
            catch (OdbcException )
            {
                //vControlErrores(ex.Errors);
                return false;
            }
        }

        protected static void vCerrarConexion()
        {
            try
            {
                ocConexion.Close();
            }
            catch (OdbcException )
            {
                //vControlErrores(ex.Errors);
            }
        }
    }
}
