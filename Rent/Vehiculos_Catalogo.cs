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
            }
            else
            {
                panelVehiculos.Width = 280;
            }
        }


        private void Classic_Click(object sender, EventArgs e)
        {
            Variables.accion = "SELECT Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'Classic' AND estatus='DISPONIBLE'";
            EliminaBotones();
            LlenaLista();
            CreaBotones();
        }

        private void Muscle_Click(object sender, EventArgs e)
        {
            Variables.accion = "SELECT Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'Muscle' AND estatus='DISPONIBLE'";
            EliminaBotones();
            LlenaLista();
            CreaBotones();
        }

        private void PickUp_Click(object sender, EventArgs e)
        {
            Variables.accion = "SELECT Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'PickUp' AND estatus='DISPONIBLE'";
            EliminaBotones();
            LlenaLista();
            CreaBotones();
        }

        private void Motorcycle_Click(object sender, EventArgs e)
        {
            Variables.accion = "SELECT Marca, Modelo, Fabricacion FROM vehiculos WHERE Tipo = 'Motorcycle' AND estatus='DISPONIBLE'";
            EliminaBotones();
            LlenaLista();
            CreaBotones();
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
                    DescripcionVehiculo = Convert.ToString(reader[0]) + " " + Convert.ToString(reader[1]) + " " + Convert.ToString(reader[2])
                });
            }
        }

        private void CreaBotones()
        {
            arrbutton = new Button[lista.Count];
            int y = 20;
            for (x = 0; x < lista.Count; x++)
            {
                arrbutton[x] = new Button();
                arrbutton[x].Text = lista[x].DescripcionVehiculo.ToString();
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
                //arrbutton[x].Click += new System.EventHandler(arrbutton[x]_Click);
            }
        }

        private void EliminaBotones()
        {
            
            if (lista.Count > 0)
            {
                for (x = 1; x <= lista.Count; x++)
                {
                    //Button btn1 = this.Controls.OfType<Button>().Where(c => c.Name.Equals("btn" + x)).First();
                    Button boton = panelVehiculos.Controls.OfType<Button>().FirstOrDefault(x => x.Name == "btn" + x);
                    panelVehiculos.Controls.Remove(boton);
                }
            }
            
            
        }
    }

    public class datos
    {
        public string DescripcionVehiculo { get; set; }
    }
}