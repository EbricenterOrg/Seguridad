using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modulo_de_Seguridad_2._1.Presentacion; // solo esta hay que agregar

 
namespace Prueba_Seguridad
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new wfInicioSesion("Prueba_Seguridad.Form1")); // Aqui se inicia el programa se tiene que crear un windows form application y se crea un menu principal 
            //new wfInicioSesion() esta dentro de la dll de Modulo de Seguridad, adentro se agrega el form a inicializar en este cas ""Prueba_Seguridad.Form1" 
            //(En el explorador se puede ver el form con que se desea empezar)
        }
    }
}
