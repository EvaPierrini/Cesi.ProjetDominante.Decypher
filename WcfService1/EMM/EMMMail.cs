using System;
using System.Net;
using System.Net.Mail;

namespace WcfService1.EMM
{
    public class EMMMail
    {
        public static void SendMessage(String result)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.outlook.com", 587)
                {
                    EnableSsl = true,
                    Timeout = 10000,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("arnaud.ceragioli@viacesi.fr", "Lujab157") //FAKE MDP
                };
                MailMessage msg = new MailMessage();
                msg.To.Add("quentinguisiano@gmail.com");
                msg.From = new MailAddress("arnaud.ceragioli@viacesi.fr");
                msg.Subject = "Decryptage STATUS";
                msg.Body = result;
                client.Send(msg);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}