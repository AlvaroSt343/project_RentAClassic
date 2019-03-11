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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        //uso de libreria para mover formulario libremente
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] static extern public void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")] static extern public void SendMessage(System.IntPtr hwnd, int wmsg, int wparan, int lparan);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
