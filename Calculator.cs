//Check list for Calculator Activity in C#:
//Create a calculator using User Input:
// Should be accepting numerical values, otherwise, display invalid. When the scenario occurs, terminate the App
//user may input(int, double, float, etc.), 
//instruct the user to input any of the 4 fundamental operators: +,-,/, and *  otherwise display invalid message:
//Input valid prompt the user to input another numerical value. Display an error message again when invalid.
//When valid display the results:
//When the results in displayed, ask the user if he wants to do another calculation again: 
//If Yes, procede with the First Step otherwise No end the vode.

using System;
namespace Calculator
class Program
    {
        static void Main(string[] args)
        {
            do
            {
                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.WriteLine("------------------");
                Console.WriteLine("Calculator Program");
                Console.WriteLine("------------------");

                Console.Write("Enter number 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an option: ");
                Console.WriteLine("\t+ : Add");
                Console.WriteLine("\t- : Subtract");
                Console.WriteLine("\t* : Multiply");
                Console.WriteLine("\t/ : Divide");
                Console.Write("Enter an option: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"Your result: {num1} + {num2} = " + result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"Your result: {num1} - {num2} = " + result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"Your result: {num1} * {num2} = " + result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"Your result: {num1} / {num2} = " + result);
                        break;
                    default:
                        Console.WriteLine("That was not a valid option");
                        break;
                }
                Console.Write("Would you like to continue? (Y = yes, N = No): ");
            } while (Console.ReadLine().ToUpper() == "Y");

            Console.WriteLine("Bye!");
            Console.ReadKey();
        }
    }
}

