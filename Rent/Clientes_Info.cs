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
    public partial class Clientes_Info : Form
    {
        string a, b, c,w,l;
        public Clientes_Info()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Clientes_Info_Load(object sender, EventArgs e)
        {
            ConsultaClientes();
        }
        public int ConsultaClientes ()
        {
            Variables.accion = "SELECT CLAVE,NOMBRE,APELLIDO1,APELLIDO2,CELULAR1,CORREO,ID,CUENTA,CONTACTO,CELULAR2 FROM clientes";
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaproductos = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");
            Listado.DataSource = tht.Tables["Listado"].DefaultView;
            return 0;
        }
        public int ConsultaModelos()
        {
            Variables.accion = "SELECT Codigo,Marca,Modelo,Cantidad,Subtotal,IVA,Total FROM rentas_detalle WHERE Folio1='"+l+"'";
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

        private void Folio_MouseClick(object sender, MouseEventArgs e)
        {
           
            l = Folio.SelectedRows[0].Cells[0].Value.ToString();
            ConsultaModelos();
        }

        private void Folio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        public void ConsultaRentas() {
            Variables.accion = "SELECT SUM(Cantidad) FROM rentas WHERE ClienteClave='"+w+"'";
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

        private void Listado_MouseClick(object sender, MouseEventArgs e)
        {
            
            a= Listado.SelectedRows[0].Cells[1].Value.ToString();
            b = Listado.SelectedRows[0].Cells[2].Value.ToString();
            c = Listado.SelectedRows[0].Cells[3].Value.ToString();

            nombre.Text = a+" "+b+" "+c ;
            clave.Text = Listado.SelectedRows[0].Cells[0].Value.ToString();
            w = clave.Text;
            telefono.Text = Listado.SelectedRows[0].Cells[4].Value.ToString();
            ConsultaRentas();
            
        }
        public int ConsultaFolio()
        {
            Variables.accion = "SELECT Folio,Fecha,Hora FROM rentas WHERE ClienteClave='"+w+"'";
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
    }
}
