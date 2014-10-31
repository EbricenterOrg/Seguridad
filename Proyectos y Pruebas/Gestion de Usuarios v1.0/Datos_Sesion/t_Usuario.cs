using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos_Sesion
{
    public class t_Usuario
    {
        private int iId, iPregunta, iPrivilegio, iEstado;                       //Campos Numericos
        private String sApodo, sPassword, sFecha_Creacion, sHora_Creacion;      //Campos String
       
        public t_Usuario()
        {
            this.iId = 0;               
            this.iPregunta = 0;
            this.iPrivilegio = 0;

            this.sApodo = String.Empty;
            this.sPassword = string.Empty;
            this.sFecha_Creacion = String.Empty;
            this.sHora_Creacion = String.Empty;
        }

        // Campos de la tabla Usuario tipo entero
        public int ID { get { return iId; } set { iId = value; } }
        public int Pregunta { get { return iPregunta; } set { iPregunta = value; } }
        public int Privilegio { get { return iPrivilegio; } set { iPrivilegio = value; } }

        // Campos de la tabla Usuario tipo Cadena
        public String Apodo { get { return sApodo; } set { sApodo = value; } }
        public String Password { get { return sPassword; } set { sPassword = value; } }
        public String Fecha_Creado { get { return sFecha_Creacion; } set { sFecha_Creacion = value; } }
        public String Hora_Creado { get { return sHora_Creacion; } set { sHora_Creacion = value; } }

    }
}
