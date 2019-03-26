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
    public partial class Renta_Alta : Form , Interface1
    {
        Consultas consulta = new Consultas();

        double elprecio;
        double elprecioxhora;
        double sub;
        double impuesto;
        double eltotal;
        string Folio;

        public static int codigoAuto { get; set; }

        public Renta_Alta()
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

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Busca_Vehiculos busca = new Busca_Vehiculos();
            busca.inter = this;
            busca.ShowDialog();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            Busca_Cliente clientes = new Busca_Cliente();
            clientes.inter = this;
            clientes.ShowDialog();
        }

        private void GuardayConfirma_Click(object sender, EventArgs e)
        {
            Variables.accion = "INSERT INTO rentas (Fecha, Hora, Cantidad, Subtotal, IVA, Total, UsuarioClave, UsuarioNombre, ClienteClave, ClienteNombre," +
                "Estatus) Values ('"+ DateTime.Now.ToString("dd/MM/yyyy") +"','"+ DateTime.Now.ToString("HH:MM:ss") +"','1','"+ sub +"','"+ impuesto +"'," +
                " '"+ eltotal +"','"+ Variables.USER +"','"+ Variables.NOMBRE +"','"+ Clave.Text +"','"+ cliente.Text +"','ACTIVO')";
            MessageBox.Show(Variables.accion);
            GuardaRenta();
            if (Variables.se_guardo == "SI")
            {
                Folio = consulta.ConsultaFolio("rentas");
                Variables.accion = "INSERT INTO rentas_detalle (Folio1, Codigo, Marca, Modelo, Cantidad, Subtotal, IVA, Total,DiaEntrega, DiaDevolucion, Dias, Horas, Bandera) Values ('" + Folio + "'," +
                    "'" + codigo.Text + "','" + marca.Text + "','" + modelo.Text + "','1','" + sub + "','" + impuesto + "','" + eltotal + "','"+ entrega.Value.ToString("yyyyMMdd") +"'," +
                    "'"+ devolucion.Value.ToString("yyyyMMdd") +"','"+ TotalDias +"','"+ TotalHoras +"','AGREGADO')";
                MessageBox.Show(Variables.accion);
                GuardaRenta();
                if (Variables.se_guardo == "SI")
                {
                    MessageBox.Show("Renta guardada exitosamente", "Insercion Exitosa!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                { MessageBox.Show("Surgio un error al guardar el detalle, por favor verifique", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Surgio un error al guardar, por favor verifique", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void GuardaRenta()
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

        public void ConsultaCliente(string laclave)
        {
            Clave.Text = laclave;
            Variables.accion = "SELECT nombre, apellido1, apellido2, correo, celular1 FROM clientes WHERE clave='" + Clave.Text + "'";

            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string nombre= reader[0].ToString();
                string apellido = reader[1].ToString();
                string apellido2 = reader[2].ToString();

                cliente.Text = nombre + " " + apellido + " " + apellido2;
                correo.Text = Convert.ToString(reader[3]);
                telefono.Text = Convert.ToString(reader[4]);
            }
        }

        public void ConsultaVehiculo(string elCodigo)
        {
            codigo.Text = elCodigo;
            Variables.accion = "SELECT Marca, Modelo, Color, Fabricacion, Transmision, Tipo, Placa, Descripcion, Precio, Estatus FROM vehiculos WHERE codigo='" + elCodigo +"'";

            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                marca.Text = reader[0].ToString();
                modelo.Text = reader[1].ToString();
                color.Text = reader[2].ToString();
                fabricacion.Text = reader[3].ToString();
                transmision.Text = reader[4].ToString();
                tipo.Text = reader[5].ToString();
                placa.Text = reader[6].ToString();
                descripcion.Text = reader[7].ToString();
                elprecio = Convert.ToDouble(reader[8]);
                estatus.Text= reader[9].ToString();
                precioXdia.Text = "$ " + elprecio;
                elprecioxhora = Math.Round((this.elprecio / 24));
                precioXhora.Text = "$ " + elprecioxhora.ToString("0.00");
            }
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            TotalDias.Text = "0";
            entrega.Enabled = false;
            devolucion.Enabled = false;
            TotalHoras.Enabled = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            entrega.Enabled = true;
            devolucion.Enabled = true;
            TotalHoras.Text = "0";
            TotalHoras.Enabled = false;
        }

        public void CalcularTotales_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (TotalDias.Text == "0")
                {
                    MessageBox.Show("Debe selecionar correctamente sus fechas de entrega y devolucion");
                }
                else
                {
                    sub = (elprecio * Convert.ToDouble(TotalDias.Text));
                    subtotal.Text = ("$ " + sub);
                    impuesto = (sub * 0.16);
                    impuestos.Text = ("$ " + impuesto);
                    eltotal = ((sub + impuesto) - Convert.ToDouble(descuentos.Text));
                    total.Text = ("$ " + eltotal);
                }
            }
            else 
            {
                if (TotalHoras.Text == "0" || TotalHoras.Text == "")
                {
                    MessageBox.Show("Debe selecionar un total de horas adecuado");
                }
                else
                {
                    sub = (elprecioxhora * Convert.ToDouble(TotalHoras.Text));
                    subtotal.Text = ("$ " + sub);
                    impuesto = (sub * 0.16);
                    impuestos.Text = ("$ " + impuesto);
                    eltotal = ((sub + impuesto) - Convert.ToDouble(descuentos.Text));
                    total.Text = ("$ " + eltotal);
                }
            }
        }

        private void entrega_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = entrega.Value;
            DateTime dt2 = devolucion.Value;
            TimeSpan s = dt2.Subtract(dt);
            string ss = s.ToString("dd");
            int losdias = Convert.ToInt32(ss);
            losdias = losdias + 1;
            TotalDias.Text = (losdias).ToString();
        }

        private void devolucion_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = entrega.Value;
            DateTime dt2 = devolucion.Value;
            TimeSpan s = dt2.Subtract(dt);
            string ss = s.ToString("dd");
            int losdias = Convert.ToInt32(ss);
            losdias = losdias + 1;
            TotalDias.Text = (losdias).ToString();
        }

        private void imprimir_Click(object sender, EventArgs e)
        {
            Reporte nuevoRpt = new Reporte();
            nuevoRpt.ElReporte = 3;
            nuevoRpt.ShowDialog();
        }
    }
}
