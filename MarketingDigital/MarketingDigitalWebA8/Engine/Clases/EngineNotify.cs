using EASendMail;
using MarketingDigitalWebA8.Engine.Interfaces;
using MarketingDigitalWebA8.Models.ObjModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MarketingDigitalWebA8.Engine.Clases
{
    public class EngineNotify : IEngineNotify
    {
        
        public bool EnviarMailNotificacion(EstructuraMail model,IWebHostEnvironment env)
        {
            bool result = false;
            model = ConstruccionNotificacion(model,env);
            try
            {
                MailMessage mensaje = new MailMessage();
                System.Net.Mail.SmtpClient servidor = new System.Net.Mail.SmtpClient();
                mensaje.From = new System.Net.Mail.MailAddress("EMC Ingenieria de Software <supergozom@gmail.com>");
                mensaje.Subject = model.Asunto;
                mensaje.SubjectEncoding = System.Text.Encoding.UTF8;
                mensaje.Body = model.Cuerpo;
                mensaje.BodyEncoding = System.Text.Encoding.UTF8;
                mensaje.IsBodyHtml = true;
                mensaje.To.Add(new System.Net.Mail.MailAddress(model.EmailDestinatario));
                servidor.Credentials = new System.Net.NetworkCredential("supergozom@gmail.com", "1234gabriel");
                servidor.Port = 587;
                servidor.Host = "smtp.gmail.com";
                servidor.EnableSsl = true;
                servidor.Send(mensaje);
                mensaje.Dispose();
                result = true;
            }
            catch (Exception ex)
            {
                string e = ex.ToString();
            }

            return result;
        }

        private EstructuraMail ConstruccionNotificacion(EstructuraMail model , IWebHostEnvironment env)
        {
            try
            {
                string body = Path.Combine(env.WebRootPath, "templates", model.PathLecturaArchivo);
                body = File.ReadAllText(body);
                body = body.Replace("@Model.Saludo", model.Saludo);
                body = body.Replace("@Model.Fecha", model.Fecha);
                body = body.Replace("@Model.EmailDestinatario", model.EmailDestinatario);
                body = body.Replace("@Model.Observacion", model.Observacion);
                body = body.Replace("@Model.Descripcion", model.Descripcion);
                body = body.Replace("@Model.ClickAqui", model.ClickAqui);
                body = body.Replace("@Model.Link", model.Link);
                body = body.Replace("@Model.CodigoResetPassword", model.CodigoResetPassword);
                model.Cuerpo = body;
            }
            catch (Exception ex)
            {
                string e = ex.ToString();
            }
          
            return model;
        }

        public bool EnviarNotificacionEmailOutlook(EstructuraMail model, IWebHostEnvironment env)
        {
            bool result = false;
            model = ConstruccionNotificacion(model, env);
            try
            {
               
                SmtpMail oMail = new SmtpMail("TryIt");
                oMail.From = "emcingenieriadesoftware@outlook.com";
                oMail.To = model.EmailDestinatario;
                oMail.Subject = model.Asunto;
                oMail.HtmlBody = model.Cuerpo;
                //oMail.TextBody = "";
                SmtpServer oServer = new SmtpServer("smtp.live.com");
                oServer.User = "emcingenieriadesoftware@outlook.com";
                oServer.Password = "1234fabrizio";
                oServer.Port = 587;
                oServer.ConnectType = SmtpConnectType.ConnectSSLAuto;
                EASendMail.SmtpClient oSmtp = new EASendMail.SmtpClient();
                oSmtp.SendMail(oServer, oMail);
                result = true;
            }

            catch (Exception ex)
            {
                string e = ex.ToString();
            }

            return result;
        }

    }
}
