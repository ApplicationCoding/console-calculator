using System;

namespace Calculator
{
    static class calculator
    {
        #region string arrays operations
        private static string[] addOperation = { "add", "addition", "+" };
        private static string[] substractOperation = { "substract", "substraction", "-" };
        private static string[] multiplyOperation = { "multiply", "multiplication", "*" };
        private static string[] divideOperation = { "divide", "division", "/" };
        #endregion

        private static void ShowHelp()
        {
            
            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                                "about = Shows the current version of this app. \n" +
                                "help (current command) = Shows you all available commands for this calculator console. \n" +
                                "re-calculate = Allows you to re-calculate again without re-opening the app. \n" +
                                "updates = See new features for the current version of the app. \n" +
                                "operations = Lets the user see math operations that Calculator can perform. \n" +
                                "exit = Closes this app. \n" +
                                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
        static void Main(string[] args)
        {
            Console.Title = "Calculator";
            Console.WriteLine("Welcome to Calculator!");

            while(true)
            {
                Console.WriteLine("\nPlease enter your intended math operation: ");
                string? operation = Console.ReadLine();

                Console.Write("Enter your first number: ");
                int firstNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter your second number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                // Addition operation
                if (addOperation.Contains(operation?.ToLower()))
                {
                    Console.Write("The sum is: ");
                    Console.WriteLine(firstNumber + secondNumber);
                }

                // Subtraction operation
                if (substractOperation.Contains(operation?.ToLower()))
                {
                    Console.Write("The difference is: ");
                    Console.WriteLine(firstNumber - secondNumber);
                }

                // Multiplication operation
                if (multiplyOperation.Contains(operation?.ToLower()))
                {
                    Console.Write("The product is: ");
                    Console.WriteLine(firstNumber * secondNumber);
                }

                // Division operation
                if (divideOperation.Contains(operation?.ToLower()))
                {
                    if (secondNumber != 0)
                    {
                        Console.Write("The quiotient is: ");
                        Console.WriteLine(firstNumber / secondNumber);
                    }
                    else Console.WriteLine("You cannot divide by zero");
                }

                Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n" +
                    "'help' to see more information; \n" +
                    "'updates' to see new features and improvements of the current version; \n" +
                    "'re-calculate' if you want to calculate again without re-opening the app; \n" +
                    "'exit' or click the X button to close this window... \n" +
                    "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

                while (true)
                {
                    string? endOptions = Console.ReadLine();
                    if (endOptions?.ToLower() == "re-calculate")
                        break;

                    switch (endOptions?.ToLower())
                    {
                        case "help":
                            ShowHelp();
                            break;

                        case "about":
                            Console.WriteLine("Current Version: Calculator v1.6.2");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            break;

                        case "updates":
                            Console.WriteLine("Please see 'new_features_and_updates.txt' for updates");
                            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            break;

                        case "operations":
                            Console.WriteLine("Addition, Subtraction, Multiplication, and Division");
                            Console.WriteLine("\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
                            break;

                        case "exit":
                            Console.WriteLine("\nClosing...");
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }
                }
            }
        }
    }
}
