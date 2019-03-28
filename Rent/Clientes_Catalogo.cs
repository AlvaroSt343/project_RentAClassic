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
        Clientes_Alta clientesalta = new Clientes_Alta();


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

        private void Nuevo_Click(object sender, EventArgs e)
        {
            clientesalta.ShowDialog();
        }

        private void editar_Click(object sender, EventArgs e)
        {
            clientesalta.clave.Text= Listado.CurrentRow.Cells[0].Value.ToString();
            clientesalta.nombre.Text = Listado.CurrentRow.Cells[1].Value.ToString();
            clientesalta.apellido1.Text = Listado.CurrentRow.Cells[2].Value.ToString();
            clientesalta.apellido2.Text = Listado.CurrentRow.Cells[3].Value.ToString();
            clientesalta.telefono1.Text = Listado.CurrentRow.Cells[4].Value.ToString();
            clientesalta.correo.Text = Listado.CurrentRow.Cells[5].Value.ToString();
            clientesalta.domicilio.Text = Listado.CurrentRow.Cells[6].Value.ToString();
            clientesalta.cuenta.Text = Listado.CurrentRow.Cells[7].Value.ToString();
            clientesalta.nombre2.Text = Listado.CurrentRow.Cells[8].Value.ToString();
            clientesalta.telefono2.Text = Listado.CurrentRow.Cells[9].Value.ToString();
            clientesalta.esEdicion = "SI";
            clientesalta.ShowDialog();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            Reporte nuevoRpt = new Reporte();
            nuevoRpt.ElReporte = 4;
            nuevoRpt.ShowDialog();
        }
    }
}
