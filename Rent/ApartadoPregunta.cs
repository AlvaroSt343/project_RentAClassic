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
    public partial class ApartadoPregunta : Form
    {
        public string elcodigo { set; get; }

        public ApartadoPregunta()
        {
            InitializeComponent();
        }

        private void NO_MouseMove(object sender, MouseEventArgs e)
        {
            NO.Height = 190;
            NO.Width = 190;
        }

        private void NO_MouseLeave(object sender, EventArgs e)
        {
            NO.Height = 150;
            NO.Width = 150;
        }

        private void SI_MouseLeave(object sender, EventArgs e)
        {
            SI.Height = 150;
            SI.Width = 150;
        }

        private void SI_MouseMove(object sender, MouseEventArgs e)
        {
            SI.Height = 190;
            SI.Width = 190;
        }

        private void NO_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Clientes_Alta cliente = new Clientes_Alta();
            cliente.ShowDialog();
            apartaVehiculo();
            if (Variables.se_guardo == "SI")
            {
                MessageBox.Show("Este vehiculo ah sido apartado correctamente, pase al modulo de Tramites para completar sus datos", "Importante...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("error al apartar, verifique", "Importante...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void SI_Click(object sender, EventArgs e)
        {
            apartaVehiculo();
            if (Variables.se_guardo == "SI")
            {
                MessageBox.Show("Este vehiculo ah sido apartado correctamente, pase al modulo de Tramites para completar sus datos", "Importante...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("error al apartar, verifique", "Importante...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void noCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void siCliente_Click(object sender, EventArgs e)
        {
            titulo.Text = "¿YA ES USTED CLIENTE?";
            panelDesea.Visible = false;
            panel3Cliente.Visible = true;
        }

        private void siCliente_MouseLeave(object sender, EventArgs e)
        {
            siCliente.Height = 150;
            siCliente.Width = 150;
        }

        private void siCliente_MouseMove(object sender, MouseEventArgs e)
        {
            siCliente.Height = 190;
            siCliente.Width = 190;
        }

        private void noCliente_MouseLeave(object sender, EventArgs e)
        {
            noCliente.Height = 150;
            noCliente.Width = 150;
        }

        private void noCliente_MouseMove(object sender, MouseEventArgs e)
        {
            noCliente.Height = 190;
            noCliente.Width = 190;
        }

        private void apartaVehiculo()
        {
            try
            {
                Variables.accion = "UPDATE vehiculos SET estatus=@C1 WHERE codigo='" + elcodigo + "'";
                MyConnection conecta = new MyConnection();
                conecta.abrirConexion();
                MySqlCommand ejecuta = new MySqlCommand(Variables.accion);
                ejecuta.Connection = conecta.GetConexion();
                ejecuta.Parameters.AddWithValue("@C1", ("APARTADO"));
                conecta.GetConexion();
                ejecuta.ExecuteNonQuery();
                conecta.cerrarConexion();
                Variables.se_guardo = "SI";
            }
            catch
            {
                Variables.se_guardo = "NO";
            }
        }
    }
}
