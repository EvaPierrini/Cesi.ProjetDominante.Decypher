using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WcfService1.EMM
{
    class EMMSendData
    {
        public static Boolean continueChoice = true;
        public static void SendData(string key, string txtOutput, string txtName)
        {
            try
            {
                if (continueChoice== true)
                {
                    byte[] by = Encoding.ASCII.GetBytes(txtOutput);
                    SoapJEE.DicoService mydico = new SoapJEE.DicoService();
                    string result = mydico.TryFindKeyOperation(key, by, txtName);
                    if (!result.Contains("ERROR"))
                    {
                        continueChoice = false;
                        EMMMail.SendMessage(result);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("key use : {0}  , decipher text : {1} , file name : {2}",
                key,
                txtOutput,
                txtName
                );

        }
    }
}