using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Conexion
{
    public class Conexion_Local
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


        public MySqlConnection Connection //Retorna Cadena de la Conexión
        {
            get { return connection; }
            set { connection = value; }
        }

        public Conexion_Local()   //Parametros de Conexión
        {
            server = "localhost";         //Direccion Ip del Servidor
            database = "bd_Seguridad";           //Base de Datos
            uid = "seguridad";                     //Usuario
            password = "seguridad234";         //Contraseña

            String connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString); // Genera Conexión
        }


        public bool OpenConnection() //Apertura de Conexión
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Error", "No se puede Conectar al Servidor, Intenente más tarde para ver si el servidor se ha repuesto");
                        break;

                    case 1045:
                        MessageBox.Show("Invalido Usuario/Contraseña", "Passowrd o User Erroneos en el Acceso de la Base de Datos, Intente de Nuevo");
                        break;
                }
                return false;
            }
        }


        public bool CloseConnection() //Cerrar Conexión
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error", "Error al Cerrar la Base de Datos");
                return false;
            }
        }  
    }
}
