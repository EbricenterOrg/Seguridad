using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_2._1.Entidades;

namespace Prueba_Seguridad
{
    public partial class Form1 : Form
    {
        private int codigoApp;
        private String nombreApp;
        private Dictionary<string, int> DerechosApp;
        private String derechos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList alAplicaciones = new E_DatosUsuario().alAplicaciones;
            foreach (E_Aplicaciones Dato in alAplicaciones)
            {
                codigoApp = Dato.CodigoAplicacion;
                nombreApp = Dato.NombreAplicacion;
                DerechosApp = Dato.PrivilegiosAplicacion;
                foreach (KeyValuePair<string, int> Valor in DerechosApp)
                {
                    derechos += Valor.Key + ": " + Valor.Value + Environment.NewLine;
                }
                MessageBox.Show(codigoApp + ", " + nombreApp + Environment.NewLine + derechos);
                derechos = String.Empty;
            }
        }
    }
}
