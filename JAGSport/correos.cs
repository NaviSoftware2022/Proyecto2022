using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace JAGSport
{
    class correos
    {
        const string Usuario = "jagsportclient@gmail.com";
        const string Password = "utzznvsaurzwmplk";

        public static string EnviarCorreo(StringBuilder mensaje, DateTime fecha, string De, string Para, string Asunto, string team1, string team2, DateTime horaEvento, out string Error )
        {
            

            Error = "";

            try
            {
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("El Evento que te subscribiste esta apunto de empezar!!!"));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format(" Equipo 1: " + team1 + " vs equipo 2: " + team2));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("El evento se realizara en la hora y en el dia: " + horaEvento));
                mensaje.Append(Environment.NewLine);
                mensaje.Append(string.Format("Este correo fue enviado el dia: {0:dd/MM/yyyy} a las {0:HH:mm:ss} Hrs: \n\n", fecha));
                mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De);
                mail.To.Add(Para);
                mail.Subject = Asunto;
                mail.Body = mensaje.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Exito";
                return Error;
                

            }
            catch (Exception ex)
            {
                Error = "Error: " + ex.Message;
                return Error;
            }
        }
    }
}
