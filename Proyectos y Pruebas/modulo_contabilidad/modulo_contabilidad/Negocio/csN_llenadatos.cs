using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using modulo_contabilidad.Datos;
using System.Data;
using System.Windows.Forms;

namespace modulo_contabilidad.Negocio
{
    class csN_llenadatos
    {
        private DataTable DtDatos = new DataTable();
        private csD_tabm_CTdoccomp D_datos = new csD_tabm_CTdoccomp();
        private DataTable dtTabla = new DataTable();
        
        public DataTable ArrayalDatos()
        {
            ArrayList alDatos = D_datos.consulta("Select codtipodoc_compcont, nom_tipocomp from tabm_ctdoccomp");

            DtDatos.Columns.Add("Código");
            DtDatos.Columns.Add("Nombre");
            //MessageBox.Show(alDatos.Count.ToString());           
             for (int iPosicion = 0; iPosicion < alDatos.Count; iPosicion++ )
            {                
                ArrayList alDat = (ArrayList)alDatos[iPosicion];
                DtDatos.Rows.Add(alDat[0].ToString(), alDat[1].ToString());
               
            }
            return DtDatos;        
        }
    }
}
