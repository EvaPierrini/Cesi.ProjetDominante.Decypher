
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        void FindSecretKey(string[] Text, string[] Name);

        [OperationContract]
        MSG SetData(string tokenUser, string[] textFile, string[] textName);

    }

    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
    [DataContract]
    public class MSG
    {
        [DataMember]
        public bool statutOp;
        [DataMember]
        public string info;
        [DataMember]
        public object[] data;
        [DataMember]
        public string operationName;
        [DataMember]
        public string tokenApp;
        [DataMember]
        public string tokenUser;
        [DataMember]
        public string appVersion;
        [DataMember]
        public string operationVersion;

        

    }
}


