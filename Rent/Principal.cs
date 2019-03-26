using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Rent
{
    //aqui inicia todo
    public partial class Principal : Form
    {             
        public Principal()
        {
            InitializeComponent();
        }

        //VARIABLES PUCLICAS DE CLASE PRINCIPAL
        int estado = 1;

        //uso de libreria para mover formulario libremente
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] static extern public void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] static extern public void SendMessage(System.IntPtr hwnd, int wmsg, int wparan, int lparan);

        //objeto para mover libre
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Hora_Click(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //funcion para insertar nuevo form dentro de principal
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }


        // ################# I N I C I A N    B O T O N E S  ##############################################
        //boton despliega menu
        private void botonMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 53;
                logo1.Visible = false;
                logo2.Visible = true;
            }
            else
            {
                MenuVertical.Width = 250;
                logo1.Visible = true;
                logo2.Visible = false;
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Aviso..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void maximizar_Click(object sender, EventArgs e)
        {
            if (this.estado == 2)
            {
                this.WindowState = FormWindowState.Normal;
                this.estado = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.estado = 2;
            }
        }



        private void minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        //BOTONES DE MENU
        private void Vehiculos_Click(object sender, EventArgs e)
        {
            //AbrirFormInPanel(new Vehiculos_Catalogo());
            Vehiculos_Catalogo Catalogo = new Vehiculos_Catalogo();
            Catalogo.Show();
        }

        private void Rentas_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Renta_Catalogo());
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Clientes_Catalogo());
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Usuario_Catalogo());
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            //aqui va el formulario de reportes
        }

        private void Config_Click(object sender, EventArgs e)
        {
            //aqui va el formulario de ajustes

            //accion temporal
        }

        private void CerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesion?", "Aviso! ..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
        }

        private void CatalogoVehiculos_Click(object sender, EventArgs e)
        {
            Vehiculos_CatalogoUsuario catalogo = new Vehiculos_CatalogoUsuario();
            catalogo.ShowDialog();
        }
    }
}
