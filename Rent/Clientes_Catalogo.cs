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
    public partial class Clientes_Catalogo : Form
    {
        
        public Clientes_Catalogo()
        {
            InitializeComponent();
        }

        private void Clientes_Info_Load(object sender, EventArgs e)
        {
            ConsultaClientes();
        }
        public void ConsultaClientes ()
        {
            Variables.accion = "SELECT * FROM clientes";
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaproductos = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");
            Listado.DataSource = tht.Tables["Listado"].DefaultView;
        }

        private void Listado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string Valor = Listado.CurrentRow.Cells[0].Value.ToString();

            Clientes_Informacion alta = new Clientes_Informacion();
            alta.RecibeCliente(Valor);
            alta.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
