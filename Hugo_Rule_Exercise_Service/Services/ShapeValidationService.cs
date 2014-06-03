using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Hugo_Rule_Exercise_Service.Common.DataType;
using Hugo_Rule_Exercise_Service.Messages.Responses;

namespace Hugo_Rule_Exercise_Service.Services
{
    public class ShapeValidationService
    {
        /// <summary>
        /// Validate when the the user is trying to add a circle
        /// </summary>
        /// <param name="shape">String with all the shape information</param>
        /// <returns>Return all the information required to the other process</returns>
        public ValidationResponse CircleValidation(string shape)
        {
            var response = new ValidationResponse();

            string[] circle = shape.Split();
            if (circle[0] == null || !circle[0].ToLower().Equals("circle"))
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid format. Format should be: circle X Y Radius ";
                return response;
            }
            try
            {
                var x = Convert.ToDouble(circle[1]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the X axis";
                return response;
            }

            try
            {
                var y = Convert.ToDouble(circle[2]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the Y axis";
                return response;
            }
            double radius = 0.0;
            try
            {
                radius = Convert.ToDouble(circle[3]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the radius";
                return response;
            }
            var shapeDto = new shapeDto()
                               {
                                   name = circle[0],
                                   coordinates = circle[1] + " " + circle[2] + " " + circle[3]
                               };
            response.ShapeDto = shapeDto;
            response.Area = Math.PI*(radius*radius);
            response.ShapeArray = circle;
            return response;
        }

        /// <summary>
        /// Validate when the the user is trying to add a square
        /// </summary>
        /// <param name="shape">String with all the shape information</param>
        /// <returns>Return all the information required to the other process</returns>
        public ValidationResponse SquareValidation(string shape)
        {
            var response = new ValidationResponse();

            string[] square = shape.Split();
            if (square[0] == null || !square[0].ToLower().Equals("square"))
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid format. Format should be: square X Y length";
                return response;
            }
            try
            {
                var x = Convert.ToDouble(square[1]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the X axis";
                return response;
            }

            try
            {
                var y = Convert.ToDouble(square[2]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the Y axis";
                return response;
            }
            double length = 0.0;
            try
            {
                length = Convert.ToDouble(square[3]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of side";
                return response;
            }
            var shapeDto = new shapeDto()
            {
                name = square[0],
                coordinates = square[1] + " " + square[2] + " " + square[3]
            };
            response.ShapeDto = shapeDto;
            response.Area = (length * length);
            response.ShapeArray = square;
            return response;
        }

        /// <summary>
        /// Validate when the the user is trying to add a rectangle
        /// </summary>
        /// <param name="shape">String with all the shape information</param>
        /// <returns>Return all the information required to the other process</returns>
        public ValidationResponse RectangleValidation(string shape)
        {
            var response = new ValidationResponse();

            string[] rectangle = shape.Split();
            if (rectangle[0] == null || !rectangle[0].ToLower().Equals("rectangle"))
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid format. Format should be: rectangle X Y side1 side2";
                return response;
            }
            try
            {
                var x = Convert.ToDouble(rectangle[1]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the X axis";
                return response;
            }

            try
            {
                var y = Convert.ToDouble(rectangle[2]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the Y axis";
                return response;
            }

            double side1 = 0.0;
            try
            {
                side1 = Convert.ToDouble(rectangle[3]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of side1";
                return response;
            }

            double side2 = 0.0;
            try
            {
                side2 = Convert.ToDouble(rectangle[4]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of side2";
                return response;
            }


            var shapeDto = new shapeDto()
            {
                name = rectangle[0],
                coordinates = rectangle[1] + " " + rectangle[2] + " " + rectangle[3] + " "+ rectangle[4]
            };
            response.ShapeDto = shapeDto;
            response.Area = (side1 * side2);
            response.ShapeArray = rectangle;
            return response;
        }

        /// <summary>
        /// Validate when the the user is trying to add a Triangle
        /// </summary>
        /// <param name="shape">String with all the shape information</param>
        /// <returns>Return all the information required to the other process</returns>
        public ValidationResponse TriangleValidation(string shape)
        {
            var response = new ValidationResponse();

            string[] triangle = shape.Split();
            if (triangle[0] == null || !triangle[0].ToLower().Equals("triangle"))
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid format. Format should be: triangle X Y side1 side2";
                return response;
            }
            try
            {
                var x = Convert.ToDouble(triangle[1]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the X axis";
                return response;
            }

            try
            {
                var y = Convert.ToDouble(triangle[2]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the Y axis";
                return response;
            }

            double vec1 = 0.0;
            try
            {
                vec1 = Convert.ToDouble(triangle[3]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of vertice 1";
                return response;
            }

            double vec2 = 0.0;
            try
            {
                vec2 = Convert.ToDouble(triangle[4]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of vertice 2";
                return response;
            }

            double vec3 = 0.0;
            try
            {
                vec3 = Convert.ToDouble(triangle[5]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of vertice 3";
                return response;
            }



            var shapeDto = new shapeDto()
            {
                name = triangle[0],
                coordinates = triangle[1] + " " + triangle[2] + " " + triangle[3] + " " + triangle[4] + " " + triangle[5]
            };
            response.ShapeDto = shapeDto;
            response.Area = 0.0;// 4 * (Math.PI * Math.PI) * radius1 * radius2;
            response.ShapeArray = triangle;
            return response;
        }

        /// <summary>
        /// Validate when the the user is trying to add a Triangle
        /// </summary>
        /// <param name="shape">String with all the shape information</param>
        /// <returns>Return all the information required to the other process</returns>
        public ValidationResponse DonutValidation(string shape)
        {
            var response = new ValidationResponse();

            string[] donut = shape.Split();
            if (donut[0] == null || !donut[0].ToLower().Equals("donut"))
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid format. Format should be: donut X Y side1 side2";
                return response;
            }
            try
            {
                var x = Convert.ToDouble(donut[1]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the X axis";
                return response;
            }

            try
            {
                var y = Convert.ToDouble(donut[2]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the Y axis";
                return response;
            }

            double radius1 = 0.0;
            try
            {
                radius1 = Convert.ToDouble(donut[3]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of radius1";
                return response;
            }

            double radius2 = 0.0;
            try
            {
                radius2 = Convert.ToDouble(donut[4]);
            }
            catch (Exception ex)
            {
                response.Acknowledge = AcknowledgeType.Failure;
                response.Message = "Invalid value for the lenght of radius2";
                return response;
            }


            var shapeDto = new shapeDto()
            {
                name = donut[0],
                coordinates = donut[1] + " " + donut[2] + " " + donut[3] + " " + donut[4]
            };
            response.ShapeDto = shapeDto;
            response.Area = 4 * (Math.PI * Math.PI) * radius1 * radius2;
            response.ShapeArray = donut;
            return response;
        }

    }
}
