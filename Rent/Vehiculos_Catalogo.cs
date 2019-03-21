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
    public partial class Vehiculos_Catalogo : Form
    {
        //atributos publicos locales
        Button []arrbutton;
        public int x = 0;
        public List<datos> lista = new List<datos>();

        public Vehiculos_Catalogo()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botonMenu_Click(object sender, EventArgs e)
        {
            if (panelVehiculos.Width == 280)
            {
                panelVehiculos.Width = 0;
                Classic.Width = 0;
                Classic.Location= new System.Drawing.Point(0,0);
                Muscle.Width = 0;
                Muscle.Location = new System.Drawing.Point(0, 0);
                PickUp.Width = 0;
                PickUp.Location = new System.Drawing.Point(0, 0);
                Motorcycle.Width = 0;
                Motorcycle.Location = new System.Drawing.Point(0, 0);
                botonMenu.Location = new System.Drawing.Point(0, 0);
            }
            else
            {
                panelVehiculos.Width = 280;
                Classic.Width = 65;
                Classic.Location = new System.Drawing.Point(0, 0);
                Muscle.Width = 59;
                Muscle.Location = new System.Drawing.Point(64, 0);
                PickUp.Width = 72;
                PickUp.Location = new System.Drawing.Point(122, 0);
                Motorcycle.Width = 90;
                Motorcycle.Location = new System.Drawing.Point(192, 0);
                botonMenu.Location = new System.Drawing.Point(280, 0);
            }
        }


        private void Classic_Click(object sender, EventArgs e)
        {
            panelVehiculos.Controls.Clear();
            Variables.accion = "SELECT Codigo, Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'Classic' AND estatus='DISPONIBLE'";
            LlenaLista();
            CreaBotones();
        }

        private void Muscle_Click(object sender, EventArgs e)
        {
            panelVehiculos.Controls.Clear();
            Variables.accion = "SELECT Codigo, Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'Muscle' AND estatus='DISPONIBLE'";
            LlenaLista();
            CreaBotones();
        }

        private void PickUp_Click(object sender, EventArgs e)
        {
            panelVehiculos.Controls.Clear();
            Variables.accion = "SELECT Codigo, Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'PickUp' AND estatus='DISPONIBLE'";
            LlenaLista();
            CreaBotones();
        }

        private void Motorcycle_Click(object sender, EventArgs e)
        {
            panelVehiculos.Controls.Clear();
            Variables.accion = "SELECT Codigo, Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'Motorcycle' AND estatus='DISPONIBLE'";
            LlenaLista();
            CreaBotones();
        }

        private void CreaBotones()
        {
            arrbutton = new Button[lista.Count];
            int y = 20;
            for (x = 0; x < lista.Count; x++)
            {
                arrbutton[x] = new Button();
                arrbutton[x].Text = lista[x].DescripcionVehiculo.ToString();
                arrbutton[x].Tag = lista[x].CodigoVehiculo.ToString();
                arrbutton[x].Cursor = System.Windows.Forms.Cursors.Hand;
                arrbutton[x].FlatAppearance.BorderSize = 0;
                arrbutton[x].FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
                arrbutton[x].FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
                arrbutton[x].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                y = y + 45;
                arrbutton[x].Location = new System.Drawing.Point(0, y);
                arrbutton[x].Name = "btn"+x;
                arrbutton[x].Size = new System.Drawing.Size(280, 35);
                arrbutton[x].TabIndex = x;
                arrbutton[x].UseVisualStyleBackColor = true;
                arrbutton[x].ForeColor = System.Drawing.Color.White;
                this.panelVehiculos.Controls.Add(arrbutton[x]);
                arrbutton[x].Click += new System.EventHandler(SelectAuto);
            }
        }

        public void LlenaLista()
        {
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            lista.Clear();
            while (reader.Read())
            {
                lista.Add(new datos()
                {
                    CodigoVehiculo = Convert.ToString(reader[0]),
                    DescripcionVehiculo = Convert.ToString(reader[1]) + " " + Convert.ToString(reader[2]) + " " + Convert.ToString(reader[3])
                });
            }
        }

        private void SelectAuto(object sender, EventArgs e)
        {
            Button ax = (Button)sender;
            Variables.accion = "SELECT * FROM vehiculos WHERE codigo='"+ ax.Tag.ToString() + "'";
            ConsultaVehiculo();
            titulo.Text = ax.Text;
            ValidaEstatus();
            panelContVehiculos.Visible = true;
            string Ruta1= "C:\\Users\\Alvaro\\Documents\\RENTACLASSIC\\RENT PROJECT\\vehiculos\\marcas\\" + marca.Text + ".png";
            string Ruta2 = "C:\\Users\\Alvaro\\Documents\\RENTACLASSIC\\RENT PROJECT\\vehiculos\\coches\\" + ax.Tag.ToString() + ".jpg";
            logoMarca.ImageLocation = Ruta1;
            Fotos.ImageLocation = Ruta2;
        }

        private void ConsultaVehiculo()
        {
            MyConnection nuevaConexion = new MyConnection();
            nuevaConexion.abrirConexion();
            MySqlCommand cmd = new MySqlCommand(Variables.accion, nuevaConexion.GetConexion());
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                marca.Text = Convert.ToString(reader[1]);
                modelo.Text = Convert.ToString(reader[2]);
                color.Text = Convert.ToString(reader[3]);
                fabricacion.Text = Convert.ToString(reader[4]);
                transmision.Text = Convert.ToString(reader[5]);
                tipo.Text = Convert.ToString(reader[6]);
                placa.Text = Convert.ToString(reader[7]);
                descripcion.Text = Convert.ToString(reader[8]);

                double PrecioxDia = Convert.ToDouble(reader[9]);
                double PrecioxHora = (PrecioxDia / 24);

                precioDia.Text = "$ " + PrecioxDia + "   M/N";
                PrecioHora.Text = "$ " + PrecioxHora + "   M/N";
                estatus.Text = Convert.ToString(reader[10]);
            }
        }

        private void ValidaEstatus()
        {
            if (estatus.Text == "DISPONIBLE")
            {
                estatus.ForeColor = Color.Green;
            }
            else
            {
                estatus.ForeColor = Color.Red;
            }
        }

        private void Vehiculos_Catalogo_Load(object sender, EventArgs e)
        {
            panelContVehiculos.Visible = false;
        }
    }

    public class datos
    {
        public string DescripcionVehiculo { get; set; }
        public string CodigoVehiculo { get; set; }
    }
}