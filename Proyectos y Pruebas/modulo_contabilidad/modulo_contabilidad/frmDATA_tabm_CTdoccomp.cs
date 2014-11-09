using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using modulo_contabilidad.Negocio;
using System.Collections;

namespace modulo_contabilidad
{
    public partial class frmDATA_tabm_CTdoccomp : Form
    {
        csN_llenadatos alLlenadatos = new csN_llenadatos();
        private String Scodigo = string.Empty;

        public String Scodigo1
        {
            get { return Scodigo; }
            set { Scodigo = value; }
        }

        
        public frmDATA_tabm_CTdoccomp()
        {
            InitializeComponent();
        }

        private void frmDATA_tabm_CTdoccomp_Load(object sender, EventArgs e)
        {
           csN_llenadatos N_Llenadat = new csN_llenadatos();
           dtDato.DataSource = N_Llenadat.ArrayalDatos();           
        }

        private void dtDato_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dtDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Scodigo1 = dtDato.Rows[e.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show(dtDato.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void dtDato_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}
