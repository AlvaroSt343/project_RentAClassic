using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Rent.Clases;
namespace Rent
{
    public partial class Clientes_Alta : Form
    {

        public Clientes_Alta()
        {
            InitializeComponent();

            panelContenedor.Show();
            AbrirFormInPanel(new Clientes_Catalogo());
        }
        
        private void ConsultaCliente()
        {
            Variables.accion = "SELECT CLAVE FROM clientes ORDER BY CLAVE ASC ";
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int a = Convert.ToInt32(reader[0]);
                clave.Text = Convert.ToString(a + 1);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            panelContenedor.Show();
            AbrirFormInPanel(new Clientes_Informacion());
        }
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            panelContenedor.Hide();
            setVis();
            ConsultaCliente();
        }
        public void setVis()
        {
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label12.Show();
            panel3.Show();
            //button5.Show();
            //button4.Show();
            label11.Show();
            clave.Visible = true;
            nombre.Visible = true;
            apellido1.Visible = true;
            apellido2.Visible = true;
            telefono.Visible = true;
            correo.Visible = true;
            direccion.Visible = true;
            cuentabanco.Visible = true;
            nombreresponsable.Visible = true;
            telefonoresponsable.Visible = true;
        }

        public void button6_Click(object sender, EventArgs e)
        {
            //panelContenedor.Controls.Clear();
            //panelContenedor.Hide();
            //panelContenedor.Show();
            //AbrirFormInPanel(new Clientes_Catalogo());
        }

        public void button4_Click_1(object sender, EventArgs e)
        {
            if (ValidaC() == "SI")
            {
                DialogResult result = MessageBox.Show("Cliente: "+nombre.Text+" "+apellido1.Text+" "+apellido2.Text+
                      "\nTelefono: "+telefono.Text+ "\nCorreo: "+correo.Text+ "\nDireccion: "+direccion.Text
                      + "\nCuenta bancaria: "+cuentabanco.Text+ "\nResponsable de daños: "+nombreresponsable.Text+ "\nTelefono: "+telefonoresponsable.Text
                      , "Verificar datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Variables.accion = " INSERT INTO clientes (CLAVE,NOMBRE, APELLIDO1, APELLIDO2, CELULAR1, CORREO, ID,CUENTA,CONTACTO,CELULAR2,ESTATUS ) Values"
                    + "(" + "'" + clave.Text + "','" + nombre.Text + "','" + apellido1.Text + "','" + apellido2.Text + "','" + telefono.Text + "','" + correo.Text + "','" + direccion.Text + "','" + cuentabanco.Text + "','" + nombreresponsable.Text + "','" + telefonoresponsable.Text + "','" + "0" + " ')";
                    GuardaNuevoCliente();
                }
                else if (result == DialogResult.Cancel)
                {

                }
            }
            else
            {
                MessageBox.Show("Debe completar los campos!!", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ValidaC()
        {
            if (clave.Text != "" && nombre.Text != "" && apellido1.Text != "" && telefono.Text != "" && correo.Text != "" && direccion.Text != "" && cuentabanco.Text != "" && nombreresponsable.Text != "" && telefonoresponsable.Text != "")
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }

        private void GuardaNuevoCliente()
        {
            MyConnection cons = new MyConnection();
            cons.abrirConexion();
            MySqlCommand pro = new MySqlCommand(Variables.accion);
            pro.Connection = cons.GetConexion();
            pro.ExecuteNonQuery();
            cons.cerrarConexion();
            MessageBox.Show("Cliente guardado exitosamente", "Inserccion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            DialogResult result = MessageBox.Show("Desea agregar otro cliente", "Inserccion Exitosa!",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
             
            }
            else if (result == DialogResult.No)
            {
                panelContenedor.Show();
                AbrirFormInPanel(new Clientes_Informacion());
            }
            CleanT();
        }

        public void CleanT() {
            
            nombre.Clear();
            apellido1.Clear();
            apellido2.Clear();
            telefono.Clear();
            correo.Clear();
            direccion.Clear();
            cuentabanco.Clear();
            nombreresponsable.Clear();
            telefonoresponsable.Clear();
        }

        public void button5_Click_1(object sender, EventArgs e)
        {
            CleanT();
        }

        private void telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void cuentabanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void telefonoresponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) )
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void apellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void apellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombreresponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
