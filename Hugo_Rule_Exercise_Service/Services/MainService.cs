using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Hugo_Rule_Exercise_Service.Common.DataType;
using Hugo_Rule_Exercise_Service.Messages.Requests;
using Hugo_Rule_Exercise_Service.Messages.Responses;
using NLog;

namespace Hugo_Rule_Exercise_Service.Services
{
    public class MainService
    {
        public static readonly Logger log = LogManager.GetCurrentClassLogger();



        public ShapeResponse AddShape(ShapeRequest request)
        {
            var response = new ShapeResponse();
            var context = new RuleTestEntities();
            try
            {
                var newShape = new shape();
                newShape.name = request.ShapeDto.name;
                newShape.coordinates = request.ShapeDto.coordinates;
                newShape.area = request.Area;
                newShape.date_created = DateTime.Now;
                newShape.is_valid = 1;
                context.AddObject("shapes",newShape);
                context.SaveChanges();
                response.ShapeId = newShape.id_shape;
                response.Acknowledge = AcknowledgeType.Success;
            }
            catch (InvalidOperationException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.Failure;
            }
            catch (ArgumentNullException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.Failure;
            }
            catch (NullReferenceException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.Failure;
            }
            catch (OptimisticConcurrencyException exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.Failure;
            }
            catch (Exception exc)
            {
                log.Error(exc);
                response.Message = exc.Message;
                response.Acknowledge = AcknowledgeType.Failure;
            }
        finally
            {
                context.Dispose();
            }
            return response;
        }

    }
}
