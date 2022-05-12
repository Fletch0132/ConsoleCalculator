using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Calculator
{
    // Handle various different inputs
    class HandleInputs
    {
        public void Menu()
        {
            // Calculation classes
            SimpleCalculation simpleCalc = new SimpleCalculation();

            try
            {
                    // More to be added
                    Console.WriteLine("Please enter the number for the Calculation to perform?" +
                        "\n1) Addition" +
                        "\n2) Subtraction" +
                        "\n3) Multiplication" +
                        "\n4) Division" +
                        "\n0) EXIT");

                // TODO: Look at better way to maintain as "4" will increase with extra functionality
                while (Convert.ToInt32(Console.ReadLine()) > 4)
                {
                    // Option validation - Switch case most simple and allows for easy extension
                    switch (Convert.ToInt32(Console.ReadLine()))
                    {
                        case 0:
                            Environment.Exit(0);
                            break;
                        case 1:
                            simpleCalc.Addition();
                            break;
                        case 2:
                            simpleCalc.Subtraction();
                            break;
                        case 3:
                            simpleCalc.Multiplication();
                            break;
                        case 4:
                            simpleCalc.Division();
                            break;
                    }
                }
            }
            // TODO: Option to log exceptions to file
            catch (FormatException)
            {
                Console.WriteLine("Sorry, please enter a number.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Sorry, please enter a number.");
            }
        }

        public List<Double> SimpleInputPrompt(List<Double> numbers)
        {
            // Variables
            string inputNums;
            List<string> preNums = new List<string>();

            try
            {
                while (numbers.Count <= 1)
                {
                    // Ensure empty
                    inputNums = "";
                    numbers.Clear();

                    // Can't be blank
                    while (inputNums == "")
                    {
                        Console.WriteLine("Please enter any numbers, seperated by a space: ");
                        inputNums = Console.ReadLine();
                    }

                    // Split string into individual numbers, convert to double and add to array
                    //          Allows for more than two numbers to be calculated
                    preNums = inputNums.Split(" ").ToList();

                    foreach (var number in preNums)
                    {
                        numbers.Add(Convert.ToDouble(number));
                    }
                }
            }
            catch(FormatException)
            {
                // TODO: Console shows message but return to the method that called this resulting in further exception
                //          Prompt input again somehow.
                Console.WriteLine("Sorry, there may not have been numbers in there. Calculator requires numbers");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Sorry, there may not have been numbers in there. Calculator requires numbers");
            }

            return numbers;
        }
    }
}
