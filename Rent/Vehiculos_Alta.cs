using MySql.Data.MySqlClient;
using Rent.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent
{
    public partial class Vehiculos_Alta : Form
    {
        public string elCodigo;
        public string ESnuevo = "SI";

        public Vehiculos_Alta()
        {
            InitializeComponent();
        }


        private void Guardar_Click(object sender, EventArgs e)
        {
            if (ESnuevo == "SI")
            {
                GuardaVehiculo();
            }
            else
            {
                ActualizaVehiculo();
            }
            this.Close();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void GuardaVehiculo()
        {
            Variables.accion = "INSERT INTO vehiculos (Marca, Modelo, Color, Fabricacion, Transmision, Tipo, Placa, Descripcion, Precio, Estatus) Values"
            + "('" + marca.Text + "','" + modelo.Text + "','" + color.Text + "','" + fabricacion.Text + "','" + transmision.Text + "','" + tipo.Text + "'," +
            "'" + placa.Text + "','" + descripcion.Text + "'," + "'" + precio.Text + "','DISPONIBLE' )";
            MessageBox.Show(Variables.accion);

            MyConnection cons = new MyConnection();
            cons.abrirConexion();
            MySqlCommand pro = new MySqlCommand(Variables.accion);
            pro.Connection = cons.GetConexion();
            pro.ExecuteNonQuery();
            cons.cerrarConexion();
            MessageBox.Show("Vehiculo guardado exitosamente", "¡Insercion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizaVehiculo()
        {
            string actulizar = "UPDATE vehiculos SET marca=@C2, modelo=@C3, color=@C4, fabricacion=@C5, transmision=@C6, tipo=@C7," +
            " placa=@C8, descripcion=@C9, precio=@C10 WHERE codigo='" + codigo.Text + "'";

            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand ejecuta = new MySqlCommand(actulizar);
            ejecuta.Connection = conecta.GetConexion();
            ejecuta.Parameters.AddWithValue("@C2", (marca.Text));
            ejecuta.Parameters.AddWithValue("@C3", (modelo.Text));
            ejecuta.Parameters.AddWithValue("@C4", (color.Text));
            ejecuta.Parameters.AddWithValue("@C5", (fabricacion.Text));
            ejecuta.Parameters.AddWithValue("@C6", (transmision.Text));
            ejecuta.Parameters.AddWithValue("@C7", (tipo.Text));
            ejecuta.Parameters.AddWithValue("@C8", (placa.Text));
            ejecuta.Parameters.AddWithValue("@C9", (descripcion.Text));
            ejecuta.Parameters.AddWithValue("@C10", (precio.Text));
            MessageBox.Show("Vehiculo actualizado correctamente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conecta.GetConexion();
            ejecuta.ExecuteNonQuery();
            conecta.cerrarConexion();
        }

        public void ConsultaVehiculo()
        {
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                codigo.Text = Convert.ToString(reader[0]);
                marca.Text = Convert.ToString(reader[1]);
                modelo.Text = Convert.ToString(reader[2]);
                color.Text = Convert.ToString(reader[3]);
                fabricacion.Text = Convert.ToString(reader[4]);
                transmision.Text = Convert.ToString(reader[5]);
                tipo.Text = Convert.ToString(reader[6]);
                placa.Text = Convert.ToString(reader[7]);
                descripcion.Text = Convert.ToString(reader[8]);
                precio.Text = Convert.ToString(reader[9]);
            }
        }

    }
}
