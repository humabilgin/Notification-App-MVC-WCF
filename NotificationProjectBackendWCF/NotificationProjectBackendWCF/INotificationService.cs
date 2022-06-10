using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace NotificationProjectBackendWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface INotificationService
    {

     /*   [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

    */
        [OperationContract]
        bool InsertAnnouncement(Announcement obj);

        [OperationContract]
        List<Announcement> ListAnnouncement();

        [OperationContract]
        bool DeleteAnnouncement(int Cid);

        [OperationContract] 
        bool UpdateAnnouncement(Announcement obj);

        // TODO: Add your service operations here
    }

    // sadece servisin döneceklerini koy
    [DataContract]
    public class Announcement
    {
        [DataMember]
        public int ID;
        [DataMember]
        public string Body;
        [DataMember]
        public DateTime StartDate;
        [DataMember]
        public DateTime EndDate;
        [DataMember]
        public bool Status;
        [DataMember]
        public short Severity;
        [DataMember]
        public DateTime LastUpdateDate; //
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    /* [DataContract]
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
     }*/
}
