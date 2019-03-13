using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Rent.Clases
{
    public abstract class ConnectionSQL
    {
        private readonly string connectionString;

        public ConnectionSQL()
        {
            String servidor = "localhost";
            String puerto = "3306";
            String usuario = "admin";
            String password = "admin";
            String database = "rentaclassic";

            //Esta es la cadena para abrir la conexion
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}", servidor, puerto, usuario, password, database);

            //connectionString = "Server = localhost;DataBase = rentaclassic; integrated security= true";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
