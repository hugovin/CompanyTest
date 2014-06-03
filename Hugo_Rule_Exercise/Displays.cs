using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hugo_Rule_Exercise_Service.Common.DataType;
using Hugo_Rule_Exercise_Service.Messages.Requests;
using Hugo_Rule_Exercise_Service.Messages.Responses;
using Hugo_Rule_Exercise_Service.Services;

namespace Hugo_Rule_Exercise
{
    public class Displays
    {



        /// <summary>
        /// display the main menu of the application 
        /// </summary>
        /// <returns>returns the value of the option while is not 5 the aplication will runs</returns>
        public static int DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("Add Shapes  --- Type Help for instructions | Exit to finish");
            Console.WriteLine();
            Console.WriteLine("1. Add a Shape");
            Console.WriteLine("2. Mass Insert from File");
            var result = Console.ReadLine();
            if (result.ToLower().Trim().Equals("help"))
            {
                DisplayHelp();

            }
            if (result.ToLower().Trim().Equals("exit"))
            {
                Environment.Exit(0);
            }



            try
            {
               var option = Convert.ToInt32(result);
                switch (option)
                {
                    case 1 :
                        DisplayAddShape();
                        break;
                    case 2:
                        MassInsert();
                        break;
                    default:
                        return 1;
                }
                return option;
            }
            catch (Exception)
            {
                Console.WriteLine("Select a valid Option");
                return 0;

            }

        }

        /// <summary>
        /// display the help inforammtion to the user 
        /// </summary>
        /// <returns>return 4 which is the code for help</returns>
        public static int DisplayHelp()
        {
            int userInput = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Add Shapes  --- Type Help for instructions | Exit to finish");
                Console.WriteLine();
                Console.WriteLine("-- For the circle, the numbers are the x and y coordinates of the centre followed by the radius.");
                Console.WriteLine("-- For the square it is x and y of one corner followed by the length of the side.");
                Console.WriteLine("-- For the rectangle it is x and y of one corner followed by the two sides.");
                Console.WriteLine("-- For the triangle it is the x and y coordinates of the three vertices (six numbers in total).Delete a Shape");
                Console.WriteLine("-- For the donut it is the x and y of the centre followed by the two radiuses.");
                Console.WriteLine("Type 1 to go to the main Menu");
                var result = Console.ReadLine();
                try
                {
                    userInput = Convert.ToInt32(result);

                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Option");
                }
            } while (userInput != 1);
            return 4;

        }

        public static int DisplayAddShape()
        {
            var validationService = new ShapeValidationService();
            var mainService = new MainService();
            int userInput = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("New Shape ");
                Console.WriteLine();
                Console.WriteLine("Type the shape information");
                var result = Console.ReadLine();
                try
                {
                    if (result.ToLower().Trim().Equals("exit"))
                    {
                        DisplayMainMenu();
                    }
                    if (result.ToLower().Trim().Equals("help"))
                    {
                        DisplayHelp();
                    }
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
                            Console.WriteLine("");
                            Console.WriteLine(">> Shape id " + addingResponse.ShapeId + ": Circle with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and radius " + validationResponse.ShapeArray[3]);
                            Console.WriteLine(">> Area: " + validationResponse.Area);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(validationResponse.Message);
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();

                        }
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
                            Console.WriteLine("");
                            Console.WriteLine(">> Shape id " + addingResponse.ShapeId + ": Square with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and side length  " + validationResponse.ShapeArray[3]);
                            Console.WriteLine(">> Area: " + validationResponse.Area);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(validationResponse.Message);
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();

                        }
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
                            Console.WriteLine("");
                            Console.WriteLine(">> Shape id " + addingResponse.ShapeId + ": Rectangle with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and side1: " + validationResponse.ShapeArray[3]+ " side2: " + validationResponse.ShapeArray[4]);
                            Console.WriteLine(">> Area: " + validationResponse.Area);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(validationResponse.Message);
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();

                        }
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
                            Console.WriteLine("");
                            Console.WriteLine(">> Shape id " + addingResponse.ShapeId + ": Triangle with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and vertice1: " + validationResponse.ShapeArray[3] + " vertice2: " + validationResponse.ShapeArray[4] + " vertice2: " + validationResponse.ShapeArray[5]);
                            Console.WriteLine(">> Area: " + validationResponse.Area);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(validationResponse.Message);
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();

                        }
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
                            Console.WriteLine("");
                            Console.WriteLine(">> Shape id " + addingResponse.ShapeId + ": Donut with centre at (" + validationResponse.ShapeArray[1] + ", " + validationResponse.ShapeArray[2] + ") and radius1: " + validationResponse.ShapeArray[3] + " radius2: " + validationResponse.ShapeArray[4]);
                            Console.WriteLine(">> Area: " + validationResponse.Area);
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine(validationResponse.Message);
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();

                        }
                        #endregion
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Wrong Option");
                }
            } while (userInput != 1);
            return 4;
        }

        public static int MassInsert()
        {
            var insertService = new MassInsertService();
            int userInput = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Mass Insert  --- Plese verify that your file is on c: folder");
                Console.WriteLine("");
                Console.WriteLine("Type 1 when you are ready");
                var result = Console.ReadLine();
                try
                {
                    userInput = Convert.ToInt32(result);
                    if (userInput == 1)
                    {
                        var insertResult = insertService.PostFileInDb();
                        if (insertResult != -1)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Something went wrong with the insetation of informatio to the DB");
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();
                            return 1;
                        }
                        if(insertService.EtlToShapes())
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Process Succesfull");
                            Console.WriteLine("Press any key to try again...");
                            Console.ReadKey();
                            return 1;
                        }
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Wrong Option");
                }
            } while (userInput != 1);
            return 1;
        }
    }
}
