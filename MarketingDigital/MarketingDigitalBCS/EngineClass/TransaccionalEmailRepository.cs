using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace MarketingDigitalBCS.EngineClass
{
    public class TransaccionalEmailRepository
    {
        public bool SendEmailTransaccional(string email)
        {
            bool result = false;
            try
            {

                MailMessage mensaje = new MailMessage();
                SmtpClient servidor = new SmtpClient();
                mensaje.From = new MailAddress("SocialWifi <emcingenieriadesoftware@outlook.com>");
                mensaje.Subject = "Test SMTP SendiBlue Marketing Digital  Transaccional";
                mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                mensaje.Body = "Hola este es una prueba para email transaccional";
                mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.To.Add(new MailAddress(email));
                servidor.Credentials = new System.Net.NetworkCredential("emcingenieriadesoftware@outlook.com", "UPDbq2sVG50yWQkA");
                servidor.Port = 587;
                servidor.Host = "smtp-relay.sendinblue.com";
                servidor.EnableSsl = true;
                servidor.Send(mensaje);
                mensaje.Dispose();
                result = true;

            }
            catch (Exception ex)
            {
                string n = ex.ToString();
            }

            return result;
        }
    }
}
