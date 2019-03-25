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
        bool estado = false;
        
        string l,n;

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
            if (estado == false)
            {
                Variables.accion = "SELECT CLAVE,NOMBRE,APELLIDO1,APELLIDO2,CELULAR1,CORREO,ID,CUENTA,CONTACTO,CELULAR2 FROM clientes ORDER BY CLAVE ASC ";
                MyConnection nuevaConexion = new MyConnection();
                nuevaConexion.abrirConexion();
                MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clave.Text = Convert.ToString(reader[0]);
                    cliente.Text = Convert.ToString(reader[1] + " " + reader[2] + " " + reader[3]);
                    telefono.Text = Convert.ToString(reader[4]);
                    correo.Text = Convert.ToString(reader[5]);
                    direccion.Text = Convert.ToString(reader[6]);
                    cuentabanco.Text = Convert.ToString(reader[7]);
                    nombreresponsable.Text = Convert.ToString(reader[8]);
                    telefonoresponsable.Text = Convert.ToString(reader[9]);


                }
            }
            else if (estado==true){
                Variables.accion = "SELECT CLAVE,NOMBRE,APELLIDO1,APELLIDO2,CELULAR1,CORREO,ID,CUENTA,CONTACTO,CELULAR2 FROM clientes WHERE CLAVE='"+n+"'";
                MyConnection nuevaConexion = new MyConnection();
                nuevaConexion.abrirConexion();
                MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    clave.Text = Convert.ToString(reader[0]);
                    cliente.Text = Convert.ToString(reader[1] + " " + reader[2] + " " + reader[3]);
                    telefono.Text = Convert.ToString(reader[4]);
                    correo.Text = Convert.ToString(reader[5]);
                    direccion.Text = Convert.ToString(reader[6]);
                    cuentabanco.Text = Convert.ToString(reader[7]);
                    nombreresponsable.Text = Convert.ToString(reader[8]);
                    telefonoresponsable.Text = Convert.ToString(reader[9]);


                }
            }
        }
        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        public void RecibeCliente(string n) {
            estado = true;
            this.n = n;
            ConsultaCliente();
            ConsultaRentas();
            

        }

        public int ConsultaFolio()
        {
            Variables.accion = "SELECT Folio,Fecha,Hora FROM rentas WHERE ClienteClave='" + n + "'";
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaproductos = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");
            Folio.DataSource = tht.Tables["Listado"].DefaultView;
            verinfo.DataSource = null;
            verinfo.Refresh();


            return 0;
        }
        public void ConsultaRentas()
        {
            Variables.accion = "SELECT SUM(Cantidad) FROM rentas WHERE ClienteClave='" + n + "'";
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                rentas.Text = Convert.ToString(reader[0]);
                if (rentas.Text == "" || rentas.Text == "0") { rentas.Text = "0"; }


            }
            ConsultaFolio();
        }



        public int ConsultaModelos()
        {
            Variables.accion = "SELECT Codigo,Marca,Modelo,Cantidad,Subtotal,IVA,Total FROM rentas_detalle WHERE Folio1='" + l + "'";
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaproductos = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");
            verinfo.DataSource = tht.Tables["Listado"].DefaultView;
            return 0;
        }

        private void Folio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Folio_MouseClick(object sender, MouseEventArgs e)
        {
            l = Folio.SelectedRows[0].Cells[0].Value.ToString();
            ConsultaModelos();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
