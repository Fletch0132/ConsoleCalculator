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

        #region Addition
        public void Addition()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Addition");
            Console.WriteLine("----------------------------------");

            // Variables
            List<Double> inputNumbers = new List<double>();
            double total = 0;

            try
            {
                // Retrieve numbers - validated in method
                handleInputs.SimpleInputPromptMulti(inputNumbers);

                // Display Calculation
                Console.WriteLine(inputNumbers.First());
                foreach (var n in inputNumbers.Skip(1))
                {
                    Console.WriteLine("+ " + n);
                }

                // Calculation
                total = inputNumbers.Sum();

                // Display
                Console.WriteLine("= " + total +
                    "\n----------------------------------\n\n");
            }
            catch(InvalidOperationException)
            {
                Console.WriteLine("Input must have numbers and more than 1 number.");
            }

            handleInputs.Menu();
        }
        #endregion

        #region Subtraction
        public void Subtraction()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Subtraction");
            Console.WriteLine("----------------------------------");

            // Variables
            List<Double> inputNumbers = new List<double>();
            double total = 0;
            try
            {
                // Retrieve numbers - validated in method
                handleInputs.SimpleInputPromptMulti(inputNumbers);


                // TODO: Handle subtracting a negative number => currently exception
                // Display Calculation and Calculate
                Console.WriteLine(inputNumbers.First());
                total = inputNumbers.First();
                foreach (var n in inputNumbers.Skip(1))
                {
                    Console.WriteLine("- " + n);
                    total = total - n;
                }

                // Display
                Console.WriteLine("= " + total +
                "\n----------------------------------\n\n");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Input must have numbers and more than 1 number.");
            }

            handleInputs.Menu();
        }
        #endregion

        #region Multiplication
        public void Multiplication()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Multiplication");
            Console.WriteLine("----------------------------------");

            // Variables
            List<Double> inputNumbers = new List<double>();
            double total = 0;
            try
            {
                // Retrieve numbers - validated in method
                handleInputs.SimpleInputPromptMulti(inputNumbers);


                // TODO: Handle multiplying a negative number => currently exception =>
                //              Turn negative to positive then return total to negative = > Cause issues
                //              Check maths functions C# 
                // Display Calculation and Calculate
                Console.WriteLine(inputNumbers.First());
                total = inputNumbers.First();
                foreach (var n in inputNumbers.Skip(1))
                {
                    Console.WriteLine("* " + n);
                    total = total * n;
                }

                // Display
                Console.WriteLine("= " + total +
                "\n----------------------------------\n\n");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Input must have numbers and more than 1 number.");
            }

            handleInputs.Menu();
        }
        #endregion

        #region Division
        public void Division()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Division");
            Console.WriteLine("----------------------------------");

            // Variables
            double number1 = 0, number2 = 0;
            
            try
            {
                // TODO: Handle dividing more than 2 numbers => currently exception
                //              For now, strict input to 2 numbers
                /*
                 *          Console.WriteLine(inputNumbers.First());
                            total = inputNumbers.First();
                            foreach (var n in inputNumbers.Skip(1))
                            {
                                Console.WriteLine("/ " + n);
                                total = total / n;
                            }
                 */

                // First Number
                Console.WriteLine("Please enter first number: ");
                number1 = Convert.ToDouble(Console.ReadLine());

                // Second Number
                Console.WriteLine("Please enter second number: ");
                number2 = Convert.ToDouble(Console.ReadLine());

                // Display Calculation and Calculate - 2 Numbers
                double total = number1 / number2;

                // Display
                Console.WriteLine("= " + total +
                "\n----------------------------------\n\n");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Input must have numbers and more than 1 number.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, that was not a number. Calculator requires numbers");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sorry, that was not a number. Calculator requires numbers");
            }

            handleInputs.Menu();
        }
        #endregion
    }
}
