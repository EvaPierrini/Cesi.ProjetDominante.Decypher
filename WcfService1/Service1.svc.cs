using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    public class Service1 : IService1
    { 
        public void FindSecretKey(string[] Text, string[] Name)
        {
            OWDecrypt.StartDecrypt(Text, Name);
            CamDEC cam = new CamDEC();
            cam.CreateLog();
        }
        public MSG SetData(string tokenUser, string[] textFile, string[] textName)
        {
            MSG msg = new MSG();
            //
            msg.tokenApp = "tokenAPP";
            msg.tokenUser = tokenUser;
            msg.data[0] = textFile;
            msg.data[1] = textName;
            return msg;
        }
    }
}

