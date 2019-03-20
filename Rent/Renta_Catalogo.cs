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
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevaRenta_Click(object sender, EventArgs e)
        {
            Ralta.MdiParent = this.MdiParent;
            Ralta.Show();
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

        private void visualizar_Click(object sender, EventArgs e)
        {
            Reporte nuevoRpt = new Reporte();
            nuevoRpt.Show();
        }


        //Consultas ejecuta = new Consultas();
        //Variables.accion = "INSERT";
        //    Variables.se_guardo=ejecuta.ejecutaAccion();
        //    if (Variables.se_guardo == "SI")
        //    {
        //        MessageBox.Show("insercion correcta");
        //    }
        //    else
        //    {
        //        MessageBox.Show("error");
        //    }

    }
}
