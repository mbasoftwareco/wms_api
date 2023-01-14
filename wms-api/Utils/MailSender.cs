using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using wms_api.Models;

namespace wms_api.Utils
{
    public static class MailSender
    {
        private static String Server { get; set; }
        private static String User { get; set; }
        private static String Password { get; set; }
        private static String Domain { get; set; }
        private static String HtmlEnvelope { get; set; }
        private static String Port { get; set; }
        private static bool EnableSSL { get; set; }
        private static String MailFrom { get; set; }
        private static bool SendMailEnabled { get; set; }

        private static int numMails = 60;

        private static WMS_LIGERO_LIVEContext _db = new WMS_LIGERO_LIVEContext();

        private static void SetMailOptions()
        {

            if (_db == null)
                _db = new WMS_LIGERO_LIVEContext();

            if (string.IsNullOrEmpty(Server) || string.IsNullOrEmpty(User))
            {

                List<SParametro> listaParametros = _db.SParametros.Where(f => f.CodParametro.StartsWith("MAIL")).ToList();

                Server = listaParametros.Where(f => f.CodParametro == "MAILSERVER").First().ValorParametro;

                User = listaParametros.Where(f => f.CodParametro == "MAILUSER").First().ValorParametro;

                Password = listaParametros.Where(f => f.CodParametro == "MAILPASSWD").First().ValorParametro;

                try
                {
                    Domain = listaParametros.Where(f => f.CodParametro == "MAILDOMAIN").First().ValorParametro;
                }
                catch { }

                try
                {
                    HtmlEnvelope = listaParametros.Where(f => f.CodParametro == "MAILTPL").First().ValorParametro;
                }
                catch { HtmlEnvelope = ""; }

                try
                {
                    EnableSSL = listaParametros.Where(f => f.CodParametro == "MAILSSL").First().ValorParametro.Equals("T");
                }
                catch { EnableSSL = false; }

                try
                {
                    Port = listaParametros.Where(f => f.CodParametro == "MAILPORT").First().ValorParametro;
                }
                catch { }


                try
                {
                    MailFrom = listaParametros.Where(f => f.CodParametro == "MAILFROM").First().ValorParametro;
                }
                catch { }

                try
                {
                    SendMailEnabled = true;
                    SendMailEnabled = bool.Parse(listaParametros.Where(f => f.CodParametro == "SEND.MAIL").First().ValorParametro);
                }
                catch { }

                try
                {
                    numMails = int.Parse(listaParametros.Where(f => f.CodParametro == "MAIL.NUMREGS").First().ValorParametro);
                }
                catch
                {
                    numMails = 60;
                }

            }

        }

        public static void SendEmail(TEnviomail message)
        {

            IList<string> toAddressTO = new List<string>();

            try
            {

                if (string.IsNullOrEmpty(message.Mto))
                    return;

                SetMailOptions();

                if (!SendMailEnabled)
                    return;

                if (!string.IsNullOrEmpty(HtmlEnvelope))
                    message.Message = HtmlEnvelope.Replace("__CONTENT", message.Message);

                MailMessage objMessage = new MailMessage();

                objMessage.From = new MailAddress(MailFrom); //new MailAddress(message.mfrom);


                //TO
                foreach (String address in message.Mto.Replace(" ", ";").Split(';'))
                {
                    if (string.IsNullOrEmpty(address.Trim()))
                        continue;

                    if (toAddressTO.Contains(address.Trim()))
                        continue;

                    try
                    {
                        objMessage.To.Add(address.Trim());
                        toAddressTO.Add(address.Trim());
                    }
                    catch { }
                }

                //CC Copia Oculta
                /*if (!string.IsNullOrEmpty(message.mbcc ))
                {
                    foreach (String address in message.MBcc.Replace(" ", ";").Split(';'))
                    {
                        if (string.IsNullOrEmpty(address.Trim()))
                            continue;

                        if (toAddressTO.Contains(address.Trim()))
                            continue;

                        try
                        {
                            objMessage.Bcc.Add(address.Trim());
                            toAddressTO.Add(address.Trim());
                        }
                        catch { }
                    }
                }*/


                //ATTACHMENTS
                try
                {
                    foreach (string adj in message.Attachment.Split(';'))
                    {
                        if (string.IsNullOrEmpty(adj))
                            continue;

                        objMessage.Attachments.Add(new Attachment(adj));
                    }
                }
                catch { }


                objMessage.Subject = message.Subject;
                objMessage.Body = message.Message;


                objMessage.IsBodyHtml = true;

                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                SmtpClient smtpClient = new SmtpClient(Server);

                smtpClient.ServicePoint.MaxIdleTime = 1;

                if (string.IsNullOrEmpty(User))
                    smtpClient.UseDefaultCredentials = true;

                else
                {
                    smtpClient.UseDefaultCredentials = false;

                    if (!string.IsNullOrEmpty(Domain))
                        smtpClient.Credentials = new NetworkCredential(User, Password, Domain);
                    else
                        smtpClient.Credentials = new NetworkCredential(User, Password);

                }
                try
                {
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                }
                catch
                {

                }

                if (!string.IsNullOrEmpty(Port))
                    smtpClient.Port = int.Parse(Port);

                if (EnableSSL)
                    smtpClient.EnableSsl = true;


                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;

                smtpClient.Send(objMessage);
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        public static void EnviarEmails()
        {

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;


            if (_db == null)
                _db = new WMS_LIGERO_LIVEContext();

            SetMailOptions();

            IList<TEnviomail> msgList = _db.TEnviomails.Where(f => f.Sent == 0)
                .Take(numMails).ToList();

            if (msgList == null || msgList.Count == 0)
                return;


            foreach (TEnviomail msg in msgList)
            {
                try
                {
                    
                    MailSender.SendEmail(msg);

                    msg.Sent = 1;

                    msg.Fechaenviado = DateTime.Now;

                }
                catch (Exception ex)
                {
                    msg.Sent = 2;
                    msg.Observaciones = ex.Message;
                }

                _db.SaveChanges();

            }

        }
    }


}
