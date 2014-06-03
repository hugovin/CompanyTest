using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Hugo_Rule_Exercise_Service.Messages.Base;

namespace Hugo_Rule_Exercise_Service.Messages.Requests
{
    [DataContract(Namespace = "")]
    public class ShapeRequest : RequestBase
    {
        public double Area;
    }
}
