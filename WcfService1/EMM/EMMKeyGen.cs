using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1.EMM
{
    public class EMMKeyGen
    {
        public static string KeyTestChar(string key)

        {
            int cpt = 0;
            if (key == null)
            {
                string firstkey = "AAAA";
                return firstkey;
            }
            char[] keyTab = key.ToCharArray();
            char x = keyTab[keyTab.Length - 1];
            while (x == 'Z')
            {
                cpt++;
                x = keyTab[keyTab.Length - 1 - cpt];
            }
            char nextletter = (char)(keyTab[keyTab.Length - 1 - cpt] + 1);
            keyTab[keyTab.Length - 1 - cpt] = nextletter;
            for (int i = 0; i < cpt; i++)
            {
                keyTab[keyTab.Length - 1 - i] = 'A';
            }
            return new string(keyTab);
        }
    }
}