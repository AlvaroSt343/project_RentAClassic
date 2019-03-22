using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Rent.Clases;

namespace Rent
{
    public partial class Clientes_Alta : Form
    {
        public Clientes_Alta()
        {
            InitializeComponent();

            ConsultaCliente();
        }
        


        private void Clientes_Alta_Load(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void ConsultaCliente()
        {
            Variables.accion = "SELECT CLAVE,NOMBRE,APELLIDO1,APELLIDO2,CELULAR1,CORREO,ID,CUENTA,CONTACTO,CELULAR2 FROM clientes ORDER BY CLAVE ASC ";
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                clave.Text = Convert.ToString(reader[0]);
                cliente.Text = Convert.ToString(reader[1]+" "+ reader[2]+" "+ reader[3]);
                telefono.Text = Convert.ToString(reader[4]);
                correo.Text = Convert.ToString(reader[5]);
                direccion.Text = Convert.ToString(reader[6]);
                cuentabanco.Text = Convert.ToString(reader[7]);
                nombreresponsable.Text = Convert.ToString(reader[8]);
                telefonoresponsable.Text = Convert.ToString(reader[9]);
                carrosenrenta.Text = "0";
                informacion.Text = "No se ha rentado ningun auto!!";

            }
        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }
      
    }
}
