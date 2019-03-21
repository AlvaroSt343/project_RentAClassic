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
            ConsultaListado();
           // Texto();
        }
        string a, b, c, d, e, f, g, h;
        private void ConsultaListado()
        {
           /* MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaproductos = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");*/
           
        }

        private void Clientes_Alta_Load(object sender, EventArgs e)
        {
            
        }
        /*public void Texto() {
            cliente.Text = "SELECT * FROM clientes WHERE CLAVE = (Select Max(CLAVE)FROM clientes)";
            clave.Text = b;
            telefono.Text = c;
            correo.Text = d;
            direccion.Text = e;
            cuentabanco.Text = f;
            nombreresponsable.Text = g;
            telefonoresponsable.Text = h;
            carrosenrenta.Text = "0";
            informacion.Text = "El cliente no ha rentado ningun auto!!";
        }*/
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

        private void label5_Click_1(object sender, EventArgs e)
        {

        }
        public void getData(string a, string b, string c, string d, string e, string f, string g, string h) {
            this.a=a ;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
            this.f = f;
            this.g = g;
            this.h  = h;
            Texto();
        }
    }
}
