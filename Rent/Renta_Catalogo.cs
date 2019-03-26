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
    public partial class Renta_Catalogo : Form
    {
        Renta_Alta Ralta = new Renta_Alta();
        
        public Renta_Catalogo()
        {
            InitializeComponent();
        }

        private void Renta_Catalogo_Load(object sender, EventArgs e)
        {
            Variables.accion = "SELECT * FROM rentas";
            ConsultaListado();
            Listado.ClearSelection();

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaRenta_Click(object sender, EventArgs e)
        {
            Ralta.ShowDialog();
        }

        private void ConsultaListado()
        {
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand buscaRentas = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(buscaRentas);
            DataSet tht = new DataSet();
            buscaRentas.Connection = conecta.GetConexion();
            cmc.Fill(tht, "Listado");
            Listado.DataSource = tht.Tables["Listado"].DefaultView;
        }

        private void visualizar_Click(object sender, EventArgs e)
        {
            Reporte nuevoRpt = new Reporte();
            nuevoRpt.ElReporte = 1;
            nuevoRpt.ShowDialog();
        }
    }
}
