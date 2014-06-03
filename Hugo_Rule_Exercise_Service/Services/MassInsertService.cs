using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hugo_Rule_Exercise_Service.Common.DataType;
using Hugo_Rule_Exercise_Service.Messages.Requests;
using NLog;

namespace Hugo_Rule_Exercise_Service.Services
{
    public class MassInsertService
    {
        public static readonly Logger log = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Runs the store proceadure to add all the information from the file the database
        /// </summary>
        /// <returns>result from the SPROC</returns>
        public int PostFileInDb()
        {
            
            var context = new RuleTestEntities();
            try
            {
                return context.MassUpdate();
            }
            catch (Exception exc)
            {
                log.Error(exc);
                return 1;
            }
            
        }


        public bool EtlToShapes()
        {
            var context = new RuleTestEntities();
            try
            {

                    var listForInsert = context.massinserts.Where(x => x.is_valid == 0).ToList();
                    foreach (var massinsert in listForInsert)
                    {
                        var result = ValidateAndInsert(massinsert.shape);
                        if (result)
                        {
                            massinsert.is_valid = 1;
                            context.SaveChanges();
                        }
                    }

            }
            catch (Exception exc)
            {
                log.Error(exc);
                return false;
            }
            return true;
        }


        public bool ValidateAndInsert(string result)
        {
            var validationService = new ShapeValidationService();
            var mainService = new MainService();
            if (result.ToLower().Contains("circle"))
            {
                #region circleCodeRegion
                var validationResponse = validationService.CircleValidation(result);
                if (validationResponse.Acknowledge != AcknowledgeType.Failure)
                {
                    var addingResponse =
                        mainService.AddShape(new ShapeRequest()
                        {
                            ShapeDto = validationResponse.ShapeDto,
                            Area = validationResponse.Area
                        });
                    
                    log.Info(">> Shape id " + addingResponse.ShapeId + ": Circle with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and radius " + validationResponse.ShapeArray[3]);
                    return true;
                }
                log.Error(validationResponse.Message);
                return false;

                #endregion
            }
            if (result.ToLower().Contains("square"))
            {
                #region SquareRegion
                var validationResponse = validationService.SquareValidation(result);
                if (validationResponse.Acknowledge != AcknowledgeType.Failure)
                {
                    var addingResponse =
                        mainService.AddShape(new ShapeRequest()
                        {
                            ShapeDto = validationResponse.ShapeDto,
                            Area = validationResponse.Area
                        });
                    log.Info(">> Shape id " + addingResponse.ShapeId + ": Square with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and side length  " + validationResponse.ShapeArray[3]);
                    return true;
                }
                log.Error(validationResponse.Message);
                return false;

                #endregion

            }
            if (result.ToLower().Contains("rectangle"))
            {
                #region rectangleCodeRegion
                var validationResponse = validationService.RectangleValidation(result);
                if (validationResponse.Acknowledge != AcknowledgeType.Failure)
                {
                    var addingResponse =
                        mainService.AddShape(new ShapeRequest()
                        {
                            ShapeDto = validationResponse.ShapeDto,
                            Area = validationResponse.Area
                        });
                   log.Info(">> Shape id " + addingResponse.ShapeId + ": Rectangle with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and side1: " + validationResponse.ShapeArray[3] + " side2: " + validationResponse.ShapeArray[4]);
                   return true;
                }
                log.Error("validationResponse.Message");
                return false;

                #endregion

            }
            if (result.ToLower().Contains("triangle"))
            {
                #region triangleCodeRegion
                var validationResponse = validationService.TriangleValidation(result);
                if (validationResponse.Acknowledge != AcknowledgeType.Failure)
                {
                    var addingResponse =
                        mainService.AddShape(new ShapeRequest()
                        {
                            ShapeDto = validationResponse.ShapeDto,
                            Area = validationResponse.Area
                        });
                    log.Info(">> Shape id " + addingResponse.ShapeId + ": Triangle with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and vertice1: " + validationResponse.ShapeArray[3] + " vertice2: " + validationResponse.ShapeArray[4] + " vertice2: " + validationResponse.ShapeArray[5]);
                    return true;
                }
                log.Error(validationResponse.Message);
                return false;

                #endregion
            }
            if (result.ToLower().Contains("donut"))
            {
                #region donutCodeRegion
                var validationResponse = validationService.DonutValidation(result);
                if (validationResponse.Acknowledge != AcknowledgeType.Failure)
                {
                    var addingResponse =
                        mainService.AddShape(new ShapeRequest()
                        {
                            ShapeDto = validationResponse.ShapeDto,
                            Area = validationResponse.Area
                        });
                    log.Info(">> Shape id " + addingResponse.ShapeId + ": Donut with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and radius1: " + validationResponse.ShapeArray[3] + " radius2: " + validationResponse.ShapeArray[4]);
                    return true;
                }
                log.Error(validationResponse.Message);
                return false;

                #endregion
            }
            return true;
        }
    }
}
