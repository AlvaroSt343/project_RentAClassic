using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;

namespace Rent.Clases
{
    public class Consultas
    {

        public string ejecutaAccion()
        {
            try
            {
                MyConnection nuevaConexion = new MyConnection();
                nuevaConexion = new MyConnection();
                nuevaConexion.abrirConexion();
                string elQuery = Variables.accion;
                MySqlCommand ejecuta = new MySqlCommand(elQuery, nuevaConexion.GetConexion());
                ejecuta.Connection = nuevaConexion.GetConexion();
                ejecuta.ExecuteNonQuery();
                nuevaConexion.cerrarConexion();
                Variables.se_guardo = "SI";
                return Variables.se_guardo;
            }
            catch
            {
                Variables.se_guardo = "NO";
                return Variables.se_guardo;
            }
        }

        public string ConsultaFolio(string laTabla)
        {
            string elDato = "";
            Variables.accion = "SELECT folio FROM " + laTabla;
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                elDato = reader[0].ToString();
            }
            return elDato;
        }

        public string ConsultaUnDato()
        {
            string elDato = "";
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                elDato = reader[0].ToString();
            }
            return elDato;
        }

    }
}
