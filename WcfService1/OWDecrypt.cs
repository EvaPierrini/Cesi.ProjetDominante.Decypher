using System.Threading;
using WcfService1.EMM;

namespace WcfService1
{
    class OWDecrypt
    {

        public static void StartDecrypt(string[] Text, string[] TextName)
        {
            string[] CurrKey = new string[Text.Length];

            Thread[] threads = new Thread[Text.Length];
            Semaphore sem = new Semaphore(5, 5);

            for (int i = 0; i < Text.Length; i++)
            {
                int localI = i;
                Thread t = new Thread(()
                    =>
                {
                    while (CurrKey[localI] != "ZZZZ")
                    {
                        sem.WaitOne();
                        CurrKey[localI] = EMMKeyGen.KeyTestChar(CurrKey[localI]);
                        string output = EMMDecrypt.EncryptDecrypt(CurrKey[localI], Text[localI]);
                        EMMSendData.SendData(CurrKey[localI], output, TextName[localI]);
                        sem.Release();
                    }
                });
                t.Name = (i).ToString();
                threads[i] = t;
            }
            for (int i = 0; i < Text.Length; i++)
            {
                threads[i].Start();
            }

        }
    }
}