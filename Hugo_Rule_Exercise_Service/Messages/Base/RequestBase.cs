using System.Runtime.Serialization;

namespace Hugo_Rule_Exercise_Service.Messages.Base
{
    [DataContract(Namespace = "")]
    public class RequestBase
    {
        [DataMember] 
        public shapeDto ShapeDto;
    }
}
