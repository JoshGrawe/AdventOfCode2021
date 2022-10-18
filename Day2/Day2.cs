using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent_Of_Code_2021.Day2
{
    /* forward X increases the horizontal position by X units.
    down X increases the depth by X units.
    up X decreases the depth by X units. */


    // Objective : Calculate horizontal position and depth and sum them
    internal class Day2
    {
       
        public static void CalculateSubmarineValues()
        {
            int horizontalPosition = 0;
            int depth = 0;
            

            string submarineOperationsFilePath = @"C:\\Users\\Josh\\source\\repos\\Advent Of Code 2021 Day 1\\Day2\\Day2.txt";

            string[] submarineOperations = File.ReadAllLines(submarineOperationsFilePath);

            foreach (string submarineOperation in submarineOperations)
            {
                string operation = submarineOperation.Split(" ")[0];
                int operationValue = Int32.Parse(submarineOperation.Split(" ")[1]);
                switch (operation)
                {
                    case "forward":
                        horizontalPosition += operationValue;
                        break;
                    case "down":
                        depth += operationValue;
                        break;
                    case "up":
                        depth -= operationValue;
                        break;

                }
            }

            

            Console.WriteLine(horizontalPosition * depth); // Final Value

        }
        public static void CalculateSubmarineValuesPart2()
        {
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;

            string submarineOperationsFilePath = @"C:\\Users\\Josh\\source\\repos\\Advent Of Code 2021 Day 1\\Day2\\Day2.txt";
            string testSubmarineOperationsFilePath = @"C:\\Users\\Josh\\source\\repos\\Advent Of Code 2021 Day 1\\Day2\\ExampleText.txt";

            string[] submarineOperations = File.ReadAllLines(submarineOperationsFilePath);

            foreach (string submarineOperation in submarineOperations)
            {
                string operation = submarineOperation.Split(" ")[0];
                int operationValue = Int32.Parse(submarineOperation.Split(" ")[1]);

                Console.WriteLine($"Aim Is {aim}");
                Console.WriteLine($"Depth is {depth}");
                Console.WriteLine($"curretValue is {operationValue}");

                switch (operation)
                {
                    case "forward":
                        
                       
                       
                         horizontalPosition += operationValue;
                         depth += operationValue * aim;
                       
                       
                        break;
                    case "down":
                       
                        aim += operationValue;
                        break;
                    case "up":
                       
                        aim -= operationValue;
                        break;

                }
            }

           


            Console.WriteLine(horizontalPosition * depth); // Final Value

        }





    }
}
