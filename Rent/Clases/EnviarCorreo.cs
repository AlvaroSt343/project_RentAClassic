using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Ejercicio_12_Correo
{
    class EnviarCorreo
    {
        public int Correo(string servidor, string remitente, string password, string destinatario, string Asunto, string ElMensaje)
        {
            int bandera = 0;
            //genera los parametros para la estructura del mail
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(servidor);
                mail.From = new MailAddress(remitente);
                mail.To.Add(destinatario);
                mail.Subject = Asunto;
                mail.Body = ElMensaje;
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(remitente, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                bandera = 1;
            }
            catch (Exception)
            {
                bandera = 0;
            }
            return bandera;
        }
    }
}
