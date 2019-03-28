using CrystalDecisions.Shared;
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
        //constructores
        Consultas consulta = new Consultas();
        DataSet dataSet = new DataSet();

        public int ElReporte=0;
        //encabezado
        public string clienteClave { set; get; }
        public string cliente { set; get; }
        public string telefono { set; get; }
        public string direccion { set; get; } //consulta
        public string correo { set; get; }
        public string contacto { set; get; } //consulta
        public string telefono2 { set; get; } //consulta
        public string cuenta { set; get; } //consulta
        //detalle
        public string codigo { set; get; }
        public string marca { set; get; }
        public string modelo { set; get; }
        public string color { set; get; }
        public string fabricacion { set; get; }
        public string subtotal { set; get; }
        public string iva { set; get; }
        public string total { set; get; }
        //despues de detalle
        public string desde { set; get; }
        public string hasta { set; get; }
        public string totaldias { set; get; }
        public string totalhoras { set; get; }
        public string precioxdia { set; get; }
        public string precioxhora { set; get; }

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

                    string elFolio = consulta.ConsultaFolio("rentas");
                    Variables.accion = "SELECT fecha FROM rentas WHERE folio='"+ elFolio +"'";
                    string laFecha = consulta.ConsultaUnDato();

                    Variables.accion = "SELECT ID, CONTACTO, CELULAR2, CUENTA FROM clientes WHERE CLAVE = '"+ clienteClave + "'";
                    ConsultaDatos();

                    RPT3.SetParameterValue("folio", elFolio);
                    RPT3.SetParameterValue("fecha", laFecha);
                    RPT3.SetParameterValue("cliente", cliente);
                    RPT3.SetParameterValue("telefono", telefono);
                    RPT3.SetParameterValue("direccion", direccion);
                    RPT3.SetParameterValue("correo", correo);
                    RPT3.SetParameterValue("contacto", contacto);
                    RPT3.SetParameterValue("telefono2", telefono2);
                    RPT3.SetParameterValue("cuenta", cuenta);
                    RPT3.SetParameterValue("codigo", codigo);
                    RPT3.SetParameterValue("marca", marca);
                    RPT3.SetParameterValue("modelo", modelo);
                    RPT3.SetParameterValue("color", color);
                    RPT3.SetParameterValue("fabricacion", fabricacion);
                    RPT3.SetParameterValue("subtotal", subtotal);
                    RPT3.SetParameterValue("iva", iva);
                    RPT3.SetParameterValue("total", total);
                    RPT3.SetParameterValue("desde", desde);
                    RPT3.SetParameterValue("hasta", hasta);
                    RPT3.SetParameterValue("totaldias", totaldias);
                    RPT3.SetParameterValue("totalhoras", totalhoras);
                    RPT3.SetParameterValue("precioxdia", precioxdia);
                    RPT3.SetParameterValue("precioxhora", precioxhora);

                    crystalReportViewer1.ReportSource = RPT3;

                    RPT3.ExportToDisk(ExportFormatType.PortableDocFormat, "C:\\RentDocs\\Renta_"+ elFolio + ".pdf");

                    crystalReportViewer1.Show();
                    break;
                case 4:
                    Reportes.RptClientes RPT4 = new Reportes.RptClientes();
                    RPT4.SetDataSource(dataSet);
                    crystalReportViewer1.ReportSource = RPT4;
                    crystalReportViewer1.Show();
                    break;
            }  
        }




        private void ConsultaDatos()
        {
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                direccion = reader[0].ToString();
                contacto = reader[1].ToString();
                telefono2 = reader[2].ToString();
                cuenta = reader[3].ToString();
            }
        }
    }
}
