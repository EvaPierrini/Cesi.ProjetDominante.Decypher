using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WcfService1.EMM
{
    public class EMMDecrypt
    {
        public static string EncryptDecrypt(string key, string PlainText)
        {
            try
            {
                StringBuilder InputStringBuild = new StringBuilder(PlainText);
                StringBuilder OutStringBuild = new StringBuilder(PlainText.Length);
                char Textch;
                for (int i = 0; i < PlainText.Length; i++)
                {
                    Textch = InputStringBuild[i];
                    Textch = (char)(Textch ^ key[i % key.Length]);
                    OutStringBuild.Append(Textch);
                }
                return OutStringBuild.ToString();
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}