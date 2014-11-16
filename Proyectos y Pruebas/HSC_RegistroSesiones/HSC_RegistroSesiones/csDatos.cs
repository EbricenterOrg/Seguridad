using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSC_RegistroSesiones
{
    public class csDatos
    {
        private string sQuery;

        public void InsertarDatos(float fcod_ses, float fcod_usr)
        {
            sQuery = "INSERT INTO tabt_sgsesion (cod_ses,cod_usr,sesact_ses,fechinic_ses) VALUES (" + Convert.ToInt32(fcod_ses) + "," + Convert.ToInt32(fcod_usr) + ",1,NOW())";
            ODBCconnector.csFunciones.vInsertar(sQuery);
        }
    }
}
