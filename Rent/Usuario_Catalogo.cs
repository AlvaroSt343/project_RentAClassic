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
    public partial class Usuario_Catalogo : Form
    {
        public Usuario_Catalogo()
        {
            InitializeComponent();
        }

        private void ConsultaUsarios()
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

        private void Usuario_Catalogo_Load(object sender, EventArgs e)
        {
            Variables.accion = "SELECT clave,nombre,user,pass,perfil FROM usuarios WHERE estatus='1'";
            ConsultaUsarios();
        }

        private void nuevaRenta_Click(object sender, EventArgs e)
        {
            Usuario_Alta nuevoUser = new Usuario_Alta();
            nuevoUser.Show();
        }
    }
}
