using System.Collections.Generic;
using System.Runtime.Serialization;
using Hugo_Rule_Exercise_Service.Common.DataType;

namespace Hugo_Rule_Exercise_Service.Messages.Base
{
   
    [DataContract(Namespace = "")]
    public class ResponseBase
    {
        
        /// <summary>
        /// Default Constructor for ResponseBase.
        /// </summary>
        public ResponseBase() { }

        /// <summary>
        /// A flag indicating success or failure of the web service response back to the 
        /// client. Default is success. Ebay.com uses this model.
        /// </summary>
        [DataMember]
        public AcknowledgeType Acknowledge = AcknowledgeType.Success;

        /// <summary>
        /// Message back to client. Mostly used when a web service failure occurs. 
        /// </summary>
        [DataMember]
        public string Message;

        [DataMember]
        public int ShapeId;



    }
}
