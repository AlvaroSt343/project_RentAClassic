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
        string w;
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


        private void Folio_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void Listado_MouseClick(object sender, MouseEventArgs e)
        {

            label1.Text = Listado.SelectedRows[0].Cells[0].Value.ToString();
            w = label1.Text;
            
            
            Clientes_Alta alta = new Clientes_Alta();
            alta.RecibeCliente(w);
            alta.Show();
            



        }


    }
}
