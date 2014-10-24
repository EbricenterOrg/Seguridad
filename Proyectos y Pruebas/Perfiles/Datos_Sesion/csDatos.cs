using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;
using MySql.Data.MySqlClient;
using System.Collections;

namespace Datos_Sesion
{
    public class csDatos: Conexion_Remota
    {

        public ArrayList Obtener_Tabla_Usuario(String sQuery)       //Obtiene los Datos de la Tabla Usuario
        {
            ArrayList arTabla_Usuario = new ArrayList();

            try
            {
                this.OpenConnection();
                MySqlCommand SQLcmd = new MySqlCommand(sQuery, Connection);
                MySqlDataReader Leer_Tabla_Usuario = SQLcmd.ExecuteReader();

                while (Leer_Tabla_Usuario.Read())
                {
                    t_Usuario datos_Usuario = new t_Usuario();

                    if (Leer_Tabla_Usuario["id_usuario"].ToString() != null) { datos_Usuario.ID = Convert.ToInt32(Leer_Tabla_Usuario["id_usuario"]); } 
                    if (Leer_Tabla_Usuario["usur_pregunta"].ToString() != null) { datos_Usuario.Pregunta = Convert.ToInt32(Leer_Tabla_Usuario["usur_pregunta"]); }
                    if (Leer_Tabla_Usuario["usur_privilegio"].ToString() != null) { datos_Usuario.Privilegio = Convert.ToInt32(Leer_Tabla_Usuario["usur_privilegio"]); }

                    if (Leer_Tabla_Usuario["usur_apodo"] != null) { datos_Usuario.Apodo = Leer_Tabla_Usuario["usur_apodo"].ToString(); }
                    if (Leer_Tabla_Usuario["usur_pass"] != null) { datos_Usuario.Password = Leer_Tabla_Usuario["usur_pass"].ToString(); }
                    if (Leer_Tabla_Usuario["usur_fech_creado"] != null) { datos_Usuario.Fecha_Creado = Leer_Tabla_Usuario["usur_fech_creado"].ToString(); }
                    if (Leer_Tabla_Usuario["usur_hora_creado"] != null) { datos_Usuario.Hora_Creado = Leer_Tabla_Usuario["usur_hora_creado"].ToString(); }

                    arTabla_Usuario.Add(datos_Usuario);
                }
                Leer_Tabla_Usuario.Close();
            }
            catch (Exception) { }

            this.CloseConnection();
            return arTabla_Usuario;

        } 
    }
}
