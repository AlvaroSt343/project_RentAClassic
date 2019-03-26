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
        DataSet dataSet = new DataSet();

        public int ElReporte=0;


        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            switch (ElReporte)
            {
                case 1:
                    Reportes.RptRentas RPT1 = new Reportes.RptRentas();
                    RPT1.SetDataSource(dataSet);
                    crystalReportViewer1.ReportSource = RPT1;
                    crystalReportViewer1.Show();
                    break;
                case 2:
                    Reportes.RptVehiculos RPT2 = new Reportes.RptVehiculos();
                    RPT2.SetDataSource(dataSet);
                    crystalReportViewer1.ReportSource = RPT2;
                    crystalReportViewer1.Show();
                    break;
                case 3:
                    Reportes.RptFactura RPT3 = new Reportes.RptFactura();
                    RPT3.SetDataSource(dataSet);
                    crystalReportViewer1.ReportSource = RPT3;
                    crystalReportViewer1.Show();
                    break;

            }
            
            
        }
    }
}
