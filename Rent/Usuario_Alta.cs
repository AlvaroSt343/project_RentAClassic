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
    public partial class Usuario_Alta : Form
    {
        public string nuevo="SI";
        public string laClave;
        public Usuario_Alta()
        {
            InitializeComponent();
        }
        //uso de libreria para mover formulario libremente

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] static extern public void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] static extern public void SendMessage(System.IntPtr hwnd, int wmsg, int wparan, int lparan);

        private void GuardaUsuario_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            string Completo = "";
            Completo = Valida();

            if (Completo == "SI")
            {
                if (pass.Text == ConfirmaPass.Text)
                {
                    if (this.nuevo == "SI")
                    {
                        Variables.accion = "INSERT INTO usuarios (NOMBRE, USER, PASS, PERFIL, ESTATUS ) Values"
                        + "(" + "'" + Nombre.Text + "','" + Usuario.Text + "','" + pass.Text + "',' ADMIN','1')";
                        GuardaNuevoUsuario();
                    }
                    else
                    {
                        ActualizaUsuario();
                    }
                    //Login.ActiveForm.Visible = true;
                    //Login.ActiveForm.Focus();
                    this.Close();
                    
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "   ¡Las contraseñas no coinciden!";
                }
            }
            else
            {
                lblErrorMessage.Visible = true;
                lblErrorMessage.Text = "   ¡Debe completar los campos!";
            }
        }

        private string Valida()
        {
            if (Nombre.Text!="" && Usuario.Text!="" && pass.Text!="")
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }

        private void GuardaNuevoUsuario()
        {
            MyConnection cons = new MyConnection();
            cons.abrirConexion();
            MySqlCommand pro = new MySqlCommand(Variables.accion);
            pro.Connection = cons.GetConexion();
            pro.ExecuteNonQuery();
            cons.cerrarConexion();
            MessageBox.Show("Usuario guardado exitosamente", "Inserccion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ActualizaUsuario()
        {
            MyConnection conecta = new MyConnection();
            conecta.abrirConexion();
            string actulizar = "UPDATE usuarios SET NOMBRE=@C2, USER=@C3, PASS=@C4 WHERE CLAVE='" + this.laClave + "'";
            MySqlCommand ejecuta = new MySqlCommand(actulizar);
            ejecuta.Connection = conecta.GetConexion();
            ejecuta.Parameters.AddWithValue("@C2", (Nombre.Text));
            ejecuta.Parameters.AddWithValue("@C3", (Usuario.Text));
            ejecuta.Parameters.AddWithValue("@C4", (pass.Text));
            MessageBox.Show("Usuario actualizado correctamente ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conecta.GetConexion();
            ejecuta.ExecuteNonQuery();
            conecta.cerrarConexion();
        }


        private void cerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir?", "Aviso..", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public void ConsultaUsuario()
        {
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Nombre.Text = Convert.ToString(reader[0]);
                Usuario.Text = Convert.ToString(reader[1]);
                pass.Text = Convert.ToString(reader[2]);
                ConfirmaPass.Text = Convert.ToString(reader[2]);
            }
        }
    }
}
