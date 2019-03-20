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
    public partial class Usuario_Alta : Form
    {
        public Usuario_Alta()
        {
            InitializeComponent();
        }

        private void GuardaUsuario_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            string Completo = "";
            Completo = Valida();

            if (Completo == "SI")
            {
                if (pass.Text == ConfirmaPass.Text)
                {
                    Variables.accion = " INSERT INTO usuarios (NOMBRE, USER, PASS, PERFIL, ESTATUS ) Values"
                    + "(" + "'" + Nombre.Text + "','" + Usuario.Text + "','" + pass.Text + "',' ADMIN','1')";

                    GuardaNuevoUsuario();
                }
                else
                {
                    lblErrorMessage.Visible = true;
                    lblErrorMessage.Text = "   ¡Las contraseñas no coinciden!";
                }
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
            //ins_pro inserta productos en la tabla
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
