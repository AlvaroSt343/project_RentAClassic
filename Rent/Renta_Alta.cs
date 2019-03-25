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
    public partial class Renta_Alta : Form
    {

        public static int codigoAuto { get; set; }

        public Renta_Alta()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busca_Vehiculos busca = new Busca_Vehiculos();
            busca.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Busca_Cliente clientes = new Busca_Cliente();
            clientes.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GuardayConfirma_Click(object sender, EventArgs e)
        {
            //Variables.accion = "INSERT INTO usuarios (NOMBRE, USER, PASS, PERFIL, ESTATUS ) Values"
            //            + "(" + "'" + Nombre.Text + "','" + Usuario.Text + "','" + pass.Text + "',' ADMIN','1')";
            //Guardarenta();
        }

        private void GuardaRenta()
        {
            MyConnection cons = new MyConnection();
            cons.abrirConexion();
            MySqlCommand pro = new MySqlCommand(Variables.accion);
            pro.Connection = cons.GetConexion();
            pro.ExecuteNonQuery();
            cons.cerrarConexion();
            MessageBox.Show("Usuario guardado exitosamente", "Inserccion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
