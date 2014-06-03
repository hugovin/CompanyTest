using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hugo_Rule_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                userInput = Displays.DisplayMainMenu();
            } while (userInput != 5);
        }
    }
}
