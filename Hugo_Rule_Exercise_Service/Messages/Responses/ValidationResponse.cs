using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hugo_Rule_Exercise_Service.Messages.Base;

namespace Hugo_Rule_Exercise_Service.Messages.Responses
{
    public class ValidationResponse : ResponseBase
    {
        public shapeDto ShapeDto;
        public string[] ShapeArray;
        public double Area;
    }
}
