using MySql.Data.MySqlClient;
using Rent.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent
{
    public partial class Busca_Vehiculos : Form 
    {
        public Interface1 inter { get; set; }

        public Busca_Vehiculos()
        {
            InitializeComponent();
        }

        //uso de libreria para mover formulario libremente
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] static extern public void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] static extern public void SendMessage(System.IntPtr hwnd, int wmsg, int wparan, int lparan);

        //objeto para mover libre
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Busca_Vehiculos_Load(object sender, EventArgs e)
        {
            Variables.accion = "SELECT codigo, marca, fabricacion, estatus FROM vehiculos";
            ConsultaListado();
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

        private void Listado_DoubleClick(object sender, EventArgs e)
        {
            inter.ConsultaVehiculo(Listado.CurrentRow.Cells[0].Value.ToString());
            this.Close();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
