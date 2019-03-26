using CrystalDecisions.Windows.Forms;
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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            Variables.accion = "SELECT * FROM rentas";

            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            MySqlCommand Ejecuta = new MySqlCommand(Variables.accion, conecta.GetConexion());
            MySqlDataAdapter cmc = new MySqlDataAdapter(Ejecuta);
            Ejecuta.Connection = conecta.GetConexion();
            //cmc.Fill(tht, "Listado");

            DataSet dataSet = new DataSet();
            Reportes.RptRentas RPT = new Reportes.RptRentas();
            RPT.SetDataSource(dataSet);
            crystalReportViewer1.ReportSource = RPT;
            crystalReportViewer1.Show();          
        }
    }
}
