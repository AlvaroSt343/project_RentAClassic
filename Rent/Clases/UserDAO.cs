using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Rent.Clases
{
    public class UserDAO:ConnectionSQL
    {
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new MySqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM usuarios WHERE USER=@user and PASS=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Variables.ID = reader.GetInt32(0);
                            Variables.NOMBRE = reader.GetString(1);
                            Variables.USER = reader.GetString(2);
                            Variables.PASS = reader.GetString(3);
                            Variables.PERFIL = reader.GetString(4);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }

        }

    }
}
