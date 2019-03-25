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
    public partial class Vehiculos_CatalogoUsuario : Form
    {
        Vehiculos_Alta VehiculosAlta = new Vehiculos_Alta();

        public Vehiculos_CatalogoUsuario()
        {
            InitializeComponent();
        }

        private void Vehiculos_CatalogoUsuario_Load(object sender, EventArgs e)
        {
            Variables.accion = "SELECT * FROM vehiculos";
            ConsultaListado();
            Listado.ClearSelection();
        }

        private void ConsultaListado()
        {
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaproductos = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaproductos);
            DataSet tht = new DataSet();
            buscaproductos.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");
            Listado.DataSource = tht.Tables["Listado"].DefaultView;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            VehiculosAlta.ShowDialog();
        }

        public void Editar_Click(object sender, EventArgs e)
        {
            iniciaEdicion();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Listado_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            iniciaEdicion();
        }

        private void iniciaEdicion()
        {
            string elCodigo = Listado.CurrentRow.Cells[0].Value.ToString();
            Variables.accion = "SELECT * FROM vehiculos WHERE codigo='" + elCodigo + "'";
            VehiculosAlta.ESnuevo = "NO";
            //VehiculosAlta.elCodigo = elCodigo;
            VehiculosAlta.ConsultaVehiculo();
            VehiculosAlta.ShowDialog();
        }
    }
}
