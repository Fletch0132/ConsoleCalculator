using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    // Class for simple calculations such as addition and division
    class SimpleCalculation
    {
        HandleInputs handleInputs = new HandleInputs();

        public void Addition()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Addition");
            Console.WriteLine("----------------------------------");

            // Variables
            bool continueCalc = true;
            List<Double> inputNumbers = new List<double>();
            double total = 0;

            // Relevant user continuing to calculate
            while (continueCalc)
            {
                try
                {
                    // Retrieve numbers - validated in method
                    handleInputs.SimpleInputPrompt(inputNumbers);

                    // Display Calculation
                    Console.WriteLine(inputNumbers.First());
                    foreach (var n in inputNumbers.Skip(1))
                    {
                        Console.WriteLine("+ " + n);
                    }

                    // Calculation
                    total = inputNumbers.Sum();

                    // Display
                    Console.WriteLine("= " + total);
                }
                catch(InvalidOperationException)
                {
                    Console.WriteLine("Input must have numbers and more than 1 number.");
                }

                // Continue?
                Console.WriteLine("Would you like to perform another Addition? (Y/N)");

                if(Console.ReadLine().ToUpper() == "Y")
                {
                    continueCalc = true;
                }
                else if(Console.ReadLine().ToUpper() == "N")
                {
                    continueCalc = false;
                }
                else
                {
                    Console.WriteLine("Would you like to perform another Addition? (Y/N)");
                }
            }

            handleInputs.Menu();
        }

        public void Subtraction()
        {

        }

        public void Multiplication()
        {

        }

        public void Division()
        {

        }
    }
}
