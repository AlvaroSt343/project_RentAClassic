using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent.Clases
{
    class EnviarCorreo
    {
        public string ElFolio { set; get; }
        public string Elcliente { set; get; }
        public string ElAuto { set; get; }
        public string destinatario { set; get; }

        string servidor = "smtp.gmail.com";
        string remitente = "rentaclassics@gmail.com";
        string password = "acceso01";
        string Asunto = "CONTRATO FACTURA DE RENTA";
        //string ElMensaje = "Estimado: " + this.Elcliente +"d";

        public void Correo()
        {
            //genera los parametros para la estructura del mail
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(servidor);
                mail.From = new MailAddress(remitente);
                mail.To.Add(destinatario);
                mail.Subject = Asunto;
                mail.Body = "Estimado: " + Elcliente + "\n\n" +
                    "\n\n Usted ah rentado: "+ ElAuto +
                    "Le hacemos la entraga de su contrato por este medio. \n\n Rent A Classic ¡AGRADECE SU PREFERENCIA!";
                mail.Attachments.Add(new Attachment("C:\\RentDocs\\Renta_" + ElFolio + ".pdf"));
                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(remitente, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                Variables.se_guardo = "SI";
            }
            catch
            {
                Variables.se_guardo = "NO";
            }

        }
    }

}
