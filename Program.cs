using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleInputs handleInputs = new HandleInputs();

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to the Calculator");
            Console.WriteLine("----------------------------------");

            handleInputs.Menu();
           
            Console.ReadKey();
        }
    }
}
