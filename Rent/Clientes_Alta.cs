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
    public partial class Clientes_Alta : Form
    {
        Consultas consulta = new Consultas();
        public string esEdicion = "NO";

        public Clientes_Alta()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guarda_Click(object sender, EventArgs e)
        {
            string guarda = Valida();
            if (esEdicion == "NO")
            {
                if (guarda == "SI")
                {
                    Variables.accion = "INSERT INTO clientes (NOMBRE, APELLIDO1, APELLIDO2, CELULAR1, CORREO, ID, CUENTA, CONTACTO, CELULAR2, ESTATUS, RUTAIMAGEN) Values"
                        + "('"+ nombre.Text + "','"+ apellido1.Text + "','"+ apellido2.Text + "','"+ telefono1.Text + "','"+ correo.Text + "','"+ domicilio.Text + "'," +
                        "'"+ cuenta.Text + "','"+ nombre2.Text + "','"+ telefono2.Text +"','"+ estatus.Checked + "','')";
                    GuardaNuevo();
                    if (Variables.se_guardo == "SI")
                    {
                        MessageBox.Show("Cliente guardado correctamente", "¡Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        esEdicion = "SI";
                        Variables.accion = "SELECT clave FROM clientes";
                        clave.Text = consulta.ConsultaUnDato();
                    }
                    else
                    {
                        MessageBox.Show("error al guardar", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos los datos son obligatorios", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (guarda == "SI")
                {
                    Variables.accion = "";
                    GuardaEdicion();
                    if (Variables.se_guardo == "SI")
                    {
                        MessageBox.Show("Cliente actualizado correctamente", "¡Genial!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        esEdicion = "SI";
                    }
                    else
                    {
                        MessageBox.Show("error al guardar", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Todos los datos son obligatorios", "Alerta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            //aqui limpia
            clave.Text = "";
            nombre.Text = "";
            apellido1.Text = "";
            apellido2.Text = "";
            telefono1.Text = "";
            correo.Text = "";
            domicilio.Text = "";
            cuenta.Text = "";
            nombre2.Text = "";
            telefono2.Text = "";
            estatus.Checked = true;
            esEdicion = "NO";
        }

        private string Valida()
        {
            if (nombre.Text == "" || apellido1.Text == "" || apellido2.Text == "" || telefono1.Text == "" ||
            correo.Text == "" || domicilio.Text == "" || cuenta.Text == "" || nombre2.Text == "" || telefono2.Text == "")
            {
                return "NO";
            }
            else
            {
                return "SI";
            } 
        }

        private void GuardaNuevo()
        {
            try
            {
                MyConnection cons = new MyConnection();
                cons.abrirConexion();
                MySqlCommand pro = new MySqlCommand(Variables.accion);
                pro.Connection = cons.GetConexion();
                pro.ExecuteNonQuery();
                cons.cerrarConexion();
                Variables.se_guardo = "SI";
            }
            catch
            {
                Variables.se_guardo = "NO";
            }
        }

        private void GuardaEdicion()
        {
            try
            {
                MyConnection conecta = new MyConnection();
                conecta.abrirConexion();
                string actulizar = "UPDATE clientes SET NOMBRE = @C3, APELLIDO1 = @C4, APELLIDO2 = @C5, CELULAR1 = @C6, CORREO = @C7, ID = @C8," +
                    " CUENTA = @C9, CONTACTO = @C10, CELULAR2 = @C11, ESTATUS = @C12, RUTAIMAGEN = @C13 WHERE CLAVE = '" + clave.Text + "'";
                MySqlCommand ejecuta = new MySqlCommand(actulizar);
                ejecuta.Connection = conecta.GetConexion();
                ejecuta.Parameters.AddWithValue("@C3", (nombre.Text));
                ejecuta.Parameters.AddWithValue("@C4", (apellido1.Text));
                ejecuta.Parameters.AddWithValue("@C5", (apellido2.Text));
                ejecuta.Parameters.AddWithValue("@C6", (telefono1.Text));
                ejecuta.Parameters.AddWithValue("@C7", (correo.Text));
                ejecuta.Parameters.AddWithValue("@C8", (domicilio.Text));
                ejecuta.Parameters.AddWithValue("@C9", (cuenta.Text));
                ejecuta.Parameters.AddWithValue("@C10", (nombre2.Text));
                ejecuta.Parameters.AddWithValue("@C11", (telefono2.Text));
                ejecuta.Parameters.AddWithValue("@C12", (estatus.Checked));
                ejecuta.Parameters.AddWithValue("@C13", (""));
                conecta.GetConexion();
                ejecuta.ExecuteNonQuery();
                conecta.cerrarConexion();
                Variables.se_guardo = "SI";
            }
            catch
            {
                Variables.se_guardo = "NO";
            }
        }
    }
}
