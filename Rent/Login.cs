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
using Rent.Clases;

namespace Rent
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //uso de libreria para mover formulario libremente
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] static extern public void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] static extern public void SendMessage(System.IntPtr hwnd, int wmsg, int wparan, int lparan);


        //PERMITE EL MOVIMIENTO
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }





        //MANDA ERROR
        private void msgError(string msg)
        {
            lblErrorMessage.Text = "     " + msg;
            lblErrorMessage.Visible = true;
        }

        //CIERRA SESION
        private void Logout(object sender, FormClosedEventArgs e)
        {
            PASS.Text = "";
            //PASS.UseSystemPasswordChar = false;
            USER.Text = "";
            lblErrorMessage.Visible = false;
            this.Show();
        }


        //INICIA SESION
        private void Log_Click_1(object sender, EventArgs e)
        {
            if (USER.Text != "" && USER.TextLength > 2)
            {
                if (PASS.Text != "")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(USER.Text, PASS.Text);
                    if (validLogin == true)
                    {
                        Principal mainMenu = new Principal();
                        //MessageBox.Show("Welcome " + UserLoginCache.NOMBRE);
                        mainMenu.Show();
                        mainMenu.FormClosed += Logout;
                        this.Hide();
                    }
                    else
                    {
                        msgError("Usuario o contraseña incorrecta. \n   Porfavor intentelo de nuevo.");
                        PASS.Text = "";
                        PASS.UseSystemPasswordChar = false;
                        USER.Focus();
                    }
                }
                else msgError("Porfavor ingrese una contraseña.");
            }
            else
            {
                msgError("Porfavor ingrese un nombre de usuario.");
            }
        }

        //CIERRA VENTANA
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //this.Visible = false;
            Usuario_Alta nuevoUsser = new Usuario_Alta();
            nuevoUsser.ShowDialog();
        }
    }
}

