using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class ComplexCalculation
    {
        HandleInputs handleInputs = new HandleInputs();

        public void Pythagoras()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Pythagoras");
            Console.WriteLine("----------------------------------");

            try
            {
                double sideA = 0;
                double sideB = 0;
                double sideC = 0;
                bool canConvert = false;

                // Validate input is number
                while (!canConvert)
                {
                    Console.WriteLine("\nEnter length of side A: ");
                    canConvert = double.TryParse(Console.ReadLine(), out sideA);
                }

                // Reset
                canConvert = false;

                while(!canConvert)
                {
                    Console.WriteLine("\nEnter length of side B: ");
                    canConvert = double.TryParse(Console.ReadLine(), out sideB);
                }

                // Calculate 
                // a(square) + b(square) = c(square)
                sideA = sideA * sideA;
                sideB = sideB * sideB;
                sideC = sideA + sideB;

                //Display sideC with SquareRoot
                Console.WriteLine("\nLength of side C is: " + Math.Sqrt(sideC));

            }
            catch(FormatException)
            {
                Console.WriteLine("Sorry, number is needed.");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Sorry, number is needed.");
            }
        }
    }
}
