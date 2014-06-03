using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Hugo_Rule_Exercise_Service.Messages.Base;

namespace Hugo_Rule_Exercise_Service.Messages.Responses
{
    [DataContract(Namespace = "")]
    public class ShapeResponse : ResponseBase
    {
        [DataMember]
        public List<shapeDto> ShareCoordinates;
    }
}
