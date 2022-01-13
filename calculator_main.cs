using System;

namespace Calculator
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            // Welcome the user to Calculator
            Console.WriteLine("Welcome to Calculator!");
            Console.WriteLine("Please enter your intended math operation: ");

            // Lets the user enter his/her intended math operation
            string enterMathOperation = Console.ReadLine();

            Console.WriteLine("Enter your first numbers: ");
            // User should enter numbers
            int enterFirstNumbers = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second numbers: ");
            int enterSecondNumbers = Convert.ToInt32(Console.ReadLine());

            // Addition operation
            if (enterMathOperation == "Addition")
            {
                // This will add and print the entered number of the user
                Console.Write("The sum is: ");
                Console.WriteLine(enterFirstNumbers + enterSecondNumbers);
            }

            else if (enterMathOperation == "addition")
            {
                Console.Write("The sum is: ");
                Console.WriteLine(enterFirstNumbers + enterSecondNumbers);
            }

            else if (enterMathOperation == "Add")
            {
                Console.Write("The sum is: ");
                Console.WriteLine(enterFirstNumbers + enterSecondNumbers);
            }

            else if (enterMathOperation == "add")
            {
                Console.Write("The sum is: ");
                Console.WriteLine(enterFirstNumbers + enterSecondNumbers);
            }

            // Subtraction operation
            else if (enterMathOperation == "Subtraction")
            {
                // Subtract the entered numbers by user
                Console.Write("The difference is: ");
                Console.WriteLine(enterFirstNumbers - enterSecondNumbers);
            }

            else if (enterMathOperation == "subtraction")
            {
                Console.Write("The difference is: ");
                Console.WriteLine(enterFirstNumbers - enterSecondNumbers);
            }

            else if (enterMathOperation == "Subtract")
            {
                Console.Write("The difference is: ");
                Console.WriteLine(enterFirstNumbers - enterSecondNumbers);
            }

            else if (enterMathOperation == "subtract")
            {
                Console.Write("The difference is: ");
                Console.WriteLine(enterFirstNumbers - enterSecondNumbers);
            }

            // Multiplication operation
            else if (enterMathOperation == "Multiplication")
            {
                // Multiplies the entered numbers by user
                Console.Write("The product is: ");
                Console.WriteLine(enterFirstNumbers * enterSecondNumbers);
            }

            else if (enterMathOperation == "multiplication")
            {
                Console.Write("The product is: ");
                Console.WriteLine(enterFirstNumbers * enterSecondNumbers);
            }

            else if (enterMathOperation == "Multiply")
            {
                Console.Write("The product is: ");
                Console.WriteLine(enterFirstNumbers * enterSecondNumbers);
            }

            else if (enterMathOperation == "multiply")
            {
                Console.Write("The product is: ");
                Console.WriteLine(enterFirstNumbers * enterSecondNumbers);
            }

            // Division operation
            else if (enterMathOperation == "Division")
            {
                // Divides the entered numbers by the user
                Console.Write("The quiotient is: ");
                Console.WriteLine(enterFirstNumbers / enterSecondNumbers);
            }

            else if (enterMathOperation == "division")
            {
                Console.Write("The quiotient is: ");
                Console.WriteLine(enterFirstNumbers / enterSecondNumbers);
            }

            else if (enterMathOperation == "Divide")
            {
                Console.Write("The quiotient is: ");
                Console.WriteLine(enterFirstNumbers / enterSecondNumbers);
            }

            else if (enterMathOperation == "divide")
            {
                Console.Write("The quiotient is: ");
                Console.WriteLine(enterFirstNumbers / enterSecondNumbers);
            }

            // This will prevent the console from automatically closing after the user has entered the second numbers
            Console.WriteLine("Please type 'help' if you'd like to continue; 'updates' to see new features and improvements of the current version; 're-calculate' if you want to re-calculate again without re-opening the app; or simply type 'close' or click the X button to close this window...");

            string endOptions = Console.ReadLine();

            if (endOptions == "help")
            {
                Console.WriteLine("about = Shows the current version of this app.");
                Console.WriteLine("help (current command) = Shows you all available commands for this calculator console.");
                Console.WriteLine("extra msg = Lets you read more message by this app.");
                Console.WriteLine("re-calculate = Allows you to re-calculate again without re-opening the app.");
                Console.WriteLine("updates = See new features for the current version of the app.");
                Console.WriteLine("exit = Closes this app.");
            }

            else if (endOptions == "about")
            {
                Console.WriteLine("Current Version: Calculator v1.6.0 Alpha");
            }

            else if (endOptions == "extra msg")
            {
                Console.WriteLine("You can re-calculate for 5 times at this version.");
            }

            else if (endOptions == "updates")
            {
                Console.WriteLine("Some Console.WriteLine() messages were changed.");            
                Console.WriteLine("Code refinements.");            
                Console.WriteLine("Files that does not improve the app was removed.");            
                Console.WriteLine("The command called 'updates' can now be seen at the 'help' command.");
                Console.WriteLine("The 'updates' command is now functioning.");
                Console.WriteLine("Update message printed by the 'updates' command.");
                Console.WriteLine("Replace 'about' with 'updates'");
            }

            // This will allow the user to re-calculate
            else if (endOptions == "re-calculate")
            {
                Console.WriteLine("Welcome to Calculator!");

                // Lets the user know that the user selected to re-calculate.
                Console.WriteLine("As you've selected, you will re-calculate.");
                Console.WriteLine("Please enter your intended math operation: ");

                // Lets the user enter his/her intended math operation
                string enterMathOperationSecond = Console.ReadLine();

                Console.WriteLine("Enter your first numbers: ");
                // User should enter numbers
                int enterFirstNumbersSecondCalc = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second numbers: ");
                int enterSecondNumbersSecondCalc = Convert.ToInt32(Console.ReadLine());

                // Addition operation
                if (enterMathOperation == "Addition")
                {
                    // This will add and print the entered number of the user
                    Console.Write("The sum is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc + enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "addition")
                {
                    Console.Write("The sum is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc + enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "Add")
                {
                    Console.Write("The sum is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc + enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "add")
                {
                    Console.Write("The sum is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc + enterSecondNumbersSecondCalc);
                }

                // Subtraction operation
                else if (enterMathOperation == "Subtraction")
                {
                    // Subtract the entered numbers by user
                    Console.Write("The difference is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc - enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "subtraction")
                {
                    Console.Write("The difference is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc - enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "Subtract")
                {
                    Console.Write("The difference is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc - enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "subtract")
                {
                    Console.Write("The difference is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc - enterSecondNumbersSecondCalc);
                }

                // Multiplication operation
                else if (enterMathOperation == "Multiplication")
                {
                    // Multiplies the entered numbers by user
                    Console.Write("The product is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc * enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "multiplication")
                {
                    Console.Write("The product is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc * enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "Multiply")
                {
                    Console.Write("The product is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc * enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "multiply")
                {
                    Console.Write("The product is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc * enterSecondNumbersSecondCalc);
                }

                // Division operation
                else if (enterMathOperation == "Division")
                {
                    // Divides the entered numbers by the user
                    Console.Write("The quiotient is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc / enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "division")
                {
                    Console.Write("The quiotient is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc / enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "Divide")
                {
                    Console.Write("The quiotient is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc / enterSecondNumbersSecondCalc);
                }

                else if (enterMathOperation == "divide")
                {
                    Console.Write("The quiotient is: ");
                    Console.WriteLine(enterFirstNumbersSecondCalc / enterSecondNumbersSecondCalc);
                }

                // This will prevent the console from automatically closing after the user has entered the second numbers
                Console.WriteLine("Please type 'help' if you'd like to continue; 'updates' to see new features and improvements of the current version; 're-calculate' if you want to re-calculate again without re-opening the app; or simply type 'close' or click the X button to close this window...");

                string SecondEndOptions = Console.ReadLine();

                if (SecondEndOptions == "help")
                {
                    Console.WriteLine("about = Shows the current version of this app.");
                    Console.WriteLine("help (current command) = Shows you all available commands for this calculator console.");
                    Console.WriteLine("extra msg = Lets you read more message by this app.");
                    Console.WriteLine("re-calculate = Allows you to re-calculate again without re-opening the app.");
                    Console.WriteLine("updates = See new features for the current version of the app.");
                    Console.WriteLine("exit = Closes this app.");
                }

                else if (SecondEndOptions == "about")
                {
                    Console.WriteLine("Current Version: Calculator v1.6.0 Alpha");
                }

                else if (SecondEndOptions == "updates")
                {
                    Console.WriteLine("Some Console.WriteLine() messages were changed.");
                    Console.WriteLine("Code refinements.");
                    Console.WriteLine("Files that does not improve the app was removed.");
                    Console.WriteLine("The command called 'updates' can now be seen at the 'help' command.");
                    Console.WriteLine("The 'updates' command is now functioning.");
                    Console.WriteLine("Update message printed by the 'updates' command.");
                    Console.WriteLine("Replace 'about' with 'updates'");
                }


                // This will allow the user to re-calculate for the third time
                else if (SecondEndOptions == "re-calculate")
                {
                    Console.WriteLine("Welcome to Calculator!");

                    // Lets the user know that the user selected to re-calculate.
                    Console.WriteLine("As you've selected, you will re-calculate for the third time.");
                    Console.WriteLine("Please enter your intended math operation: ");

                    // Lets the user enter his/her intended math operation
                    string enterMathOperationThird = Console.ReadLine();

                    Console.WriteLine("Enter your first numbers: ");
                    // User should enter numbers
                    int enterFirstNumbersThirdCalc = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter your second numbers: ");
                    int enterSecondNumbersThirdCalc = Convert.ToInt32(Console.ReadLine());

                    // Addition operation
                    if (enterMathOperation == "Addition")
                    {
                        // This will add and print the entered number of the user
                        Console.Write("The sum is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc + enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "addition")
                    {
                        Console.Write("The sum is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc + enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "Add")
                    {
                        Console.Write("The sum is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc + enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "add")
                    {
                        Console.Write("The sum is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc + enterSecondNumbersThirdCalc);
                    }

                    // Subtraction operation
                    else if (enterMathOperation == "Subtraction")
                    {
                        // Subtract the entered numbers by user
                        Console.Write("The difference is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc - enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "subtraction")
                    {
                        Console.Write("The difference is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc - enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "Subtract")
                    {
                        Console.Write("The difference is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc - enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "subtract")
                    {
                        Console.Write("The difference is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc - enterSecondNumbersThirdCalc);
                    }

                    // Multiplication operation
                    else if (enterMathOperation == "Multiplication")
                    {
                        // Multiplies the entered numbers by user
                        Console.Write("The product is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc * enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "multiplication")
                    {
                        Console.Write("The product is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc * enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "Multiply")
                    {
                        Console.Write("The product is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc * enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "multiply")
                    {
                        Console.Write("The product is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc * enterSecondNumbersThirdCalc);
                    }

                    // Division operation
                    else if (enterMathOperation == "Division")
                    {
                        // Divides the entered numbers by the user
                        Console.Write("The quiotient is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc / enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "division")
                    {
                        Console.Write("The quiotient is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc / enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "Divide")
                    {
                        Console.Write("The quiotient is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc / enterSecondNumbersThirdCalc);
                    }

                    else if (enterMathOperation == "divide")
                    {
                        Console.Write("The quiotient is: ");
                        Console.WriteLine(enterFirstNumbersThirdCalc / enterSecondNumbersThirdCalc);
                    }

                    // This will prevent the console from automatically closing after the user has entered the second numbers
                    Console.WriteLine("Please type 'help' if you'd like to continue; 'updates' to see new features and improvements of the current version; 're-calculate' if you want to re-calculate again without re-opening the app; or simply type 'close' or click the X button to close this window...");

                    string ThirdEndOptions = Console.ReadLine();

                    if (ThirdEndOptions == "help")
                    {
                        Console.WriteLine("about = Shows the current version of this app.");
                        Console.WriteLine("help (current command) = Shows you all available commands for this calculator console.");
                        Console.WriteLine("extra msg = Lets you read more message by this app.");
                        Console.WriteLine("re-calculate = Allows you to re-calculate again without re-opening the app.");
                        Console.WriteLine("updates = See new features for the current version of the app.");
                        Console.WriteLine("exit = Closes this app.");
                    }

                    else if (ThirdEndOptions == "about")
                    {
                        Console.WriteLine("Current Version: Calculator v1.6.0 Alpha");
                    }

                    else if (ThirdEndOptions == "updates")
                    {
                        Console.WriteLine("Some Console.WriteLine() messages were changed.");
                        Console.WriteLine("Code refinements.");
                        Console.WriteLine("Files that does not improve the app was removed.");
                        Console.WriteLine("The command called 'updates' can now be seen at the 'help' command.");
                        Console.WriteLine("The 'updates' command is now functioning.");
                        Console.WriteLine("Update message printed by the 'updates' command.");
                        Console.WriteLine("Replace 'about' with 'updates'");
                    }

                    // This will allow the user to re-calculate for the fourth time
                    else if (ThirdEndOptions == "re-calculate")
                    {
                        Console.WriteLine("Welcome to Calculator!");

                        // Lets the user know that the user selected to re-calculate.
                        Console.WriteLine("As you've selected, you will re-calculate for the fourth time.");
                        Console.WriteLine("Please enter your intended math operation: ");

                        // Lets the user enter his/her intended math operation
                        string enterMathOperationFourth = Console.ReadLine();

                        Console.WriteLine("Enter your first numbers: ");
                        // User should enter numbers
                        int enterFirstNumbersFourthCalc = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter your second numbers: ");
                        int enterSecondNumbersFourthCalc = Convert.ToInt32(Console.ReadLine());

                        // Addition operation
                        if (enterMathOperation == "Addition")
                        {
                            // This will add and print the entered number of the user
                            Console.Write("The sum is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc + enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "addition")
                        {
                            Console.Write("The sum is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc + enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "Add")
                        {
                            Console.Write("The sum is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc + enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "add")
                        {
                            Console.Write("The sum is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc + enterSecondNumbersFourthCalc);
                        }

                        // Subtraction operation
                        else if (enterMathOperation == "Subtraction")
                        {
                            // Subtract the entered numbers by user
                            Console.Write("The difference is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc - enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "subtraction")
                        {
                            Console.Write("The difference is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc - enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "Subtract")
                        {
                            Console.Write("The difference is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc - enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "subtract")
                        {
                            Console.Write("The difference is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc - enterSecondNumbersFourthCalc);
                        }

                        // Multiplication operation
                        else if (enterMathOperation == "Multiplication")
                        {
                            // Multiplies the entered numbers by user
                            Console.Write("The product is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc * enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "multiplication")
                        {
                            Console.Write("The product is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc * enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "Multiply")
                        {
                            Console.Write("The product is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc * enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "multiply")
                        {
                            Console.Write("The product is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc * enterSecondNumbersFourthCalc);
                        }

                        // Division operation
                        else if (enterMathOperation == "Division")
                        {
                            // Divides the entered numbers by the user
                            Console.Write("The quiotient is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc / enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "division")
                        {
                            Console.Write("The quiotient is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc / enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "Divide")
                        {
                            Console.Write("The quiotient is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc / enterSecondNumbersFourthCalc);
                        }

                        else if (enterMathOperation == "divide")
                        {
                            Console.Write("The quiotient is: ");
                            Console.WriteLine(enterFirstNumbersFourthCalc / enterSecondNumbersFourthCalc);
                        }

                        // This will prevent the console from automatically closing after the user has entered the second numbers
                        Console.WriteLine("Please type 'help' if you'd like to continue; 'updates' to see new features and improvements of the current version if you want to re-calculate again without re-opening the app; or simply type 'close' or click the X button to close this window...");

                        string FourthEndOptions = Console.ReadLine();

                        if (FourthEndOptions == "help")
                        {
                            Console.WriteLine("about = Shows the current version of this app.");
                            Console.WriteLine("help (current command) = Shows you all available commands for this calculator console.");
                            Console.WriteLine("extra msg = Lets you read more message by this app.");
                            Console.WriteLine("re-calculate = Allows you to re-calculate again without re-opening the app.");
                            Console.WriteLine("updates = See new features for the current version of the app.");
                            Console.WriteLine("exit = Closes this app.");
                        }

                        else if (FourthEndOptions == "about")
                        {
                            Console.WriteLine("Current Version: Calculator v1.6.0 Alpha");
                        }

                        else if (FourthEndOptions == "updates")
                        {
                            Console.WriteLine("Some Console.WriteLine() messages were changed.");
                            Console.WriteLine("Code refinements.");
                            Console.WriteLine("Files that does not improve the app was removed.");
                            Console.WriteLine("The command called 'updates' can now be seen at the 'help' command.");
                            Console.WriteLine("The 'updates' command is now functioning.");
                            Console.WriteLine("Update message printed by the 'updates' command.");
                            Console.WriteLine("Replace 'about' with 'updates'");
                        }

                        // This will allow the user to re-calculate for the fifth time
                        else if (FourthEndOptions == "re-calculate")
                        {
                            Console.WriteLine("Welcome to Calculator!");

                            // Lets the user know that the user selected to re-calculate.
                            Console.WriteLine("As you've selected, you will re-calculate for the fifth time.");
                            Console.WriteLine("Please enter your intended math operation: ");

                            // Lets the user enter his/her intended math operation
                            string enterMathOperationFifth = Console.ReadLine();

                            Console.WriteLine("Enter your first numbers: ");
                            // User should enter numbers
                            int enterFirstNumbersFifthCalc = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Enter your second numbers: ");
                            int enterSecondNumbersFifthCalc = Convert.ToInt32(Console.ReadLine());

                            // Addition operation
                            if (enterMathOperation == "Addition")
                            {
                                // This will add and print the entered number of the user
                                Console.Write("The sum is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc + enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "addition")
                            {
                                Console.Write("The sum is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc + enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "Add")
                            {
                                Console.Write("The sum is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc + enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "add")
                            {
                                Console.Write("The sum is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc + enterSecondNumbersFifthCalc);
                            }

                            // Subtraction operation
                            else if (enterMathOperation == "Subtraction")
                            {
                                // Subtract the entered numbers by user
                                Console.Write("The difference is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc - enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "subtraction")
                            {
                                Console.Write("The difference is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc - enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "Subtract")
                            {
                                Console.Write("The difference is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc - enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "subtract")
                            {
                                Console.Write("The difference is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc - enterSecondNumbersFifthCalc);
                            }

                            // Multiplication operation
                            else if (enterMathOperation == "Multiplication")
                            {
                                // Multiplies the entered numbers by user
                                Console.Write("The product is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc * enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "multiplication")
                            {
                                Console.Write("The product is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc * enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "Multiply")
                            {
                                Console.Write("The product is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc * enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "multiply")
                            {
                                Console.Write("The product is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc * enterSecondNumbersFifthCalc);
                            }

                            // Division operation
                            else if (enterMathOperation == "Division")
                            {
                                // Divides the entered numbers by the user
                                Console.Write("The quiotient is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc / enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "division")
                            {
                                Console.Write("The quiotient is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc / enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "Divide")
                            {
                                Console.Write("The quiotient is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc / enterSecondNumbersFifthCalc);
                            }

                            else if (enterMathOperation == "divide")
                            {
                                Console.Write("The quiotient is: ");
                                Console.WriteLine(enterFirstNumbersFifthCalc / enterSecondNumbersFifthCalc);
                            }

                            // This will prevent the console from automatically closing after the user has entered the second numbers
                            Console.WriteLine("If you want to re-calculate again, please reopen the app. Please type 'close' to exit Calculator or press the X button...");

                            string FifthEndOptions = Console.ReadLine();

                            if (FifthEndOptions == "close")
                            {
                                Console.WriteLine("Closing...");

                                // Environment.Exit(5) will close the app
                                Environment.Exit(5);
                            }

                            // This prevents the app from automatically closing
                            Console.ReadKey();
                        }

                        else if (FourthEndOptions == "extra msg")
                        {
                            Console.WriteLine("You can re-calculate for 5 times at this version.");
                        }

                        // If the user types 'close', the app will also close
                        else if (FourthEndOptions == "close")
                        {
                            Console.WriteLine("Closing...");

                            // Environment.Exit(5) will close the app
                            Environment.Exit(5);
                        }

                        // This prevents the app from automatically closing
                        Console.ReadKey();
                    }

                    else if (ThirdEndOptions == "extra msg")
                    {
                        Console.WriteLine("You can re-calculate for 5 times at this version.");
                    }

                    // If the user types 'close', the app will also close
                    else if (ThirdEndOptions == "close")
                    {
                        Console.WriteLine("Closing...");

                        // Environment.Exit(5) will close the app
                        Environment.Exit(5);
                    }

                    // This prevents the app from automatically closing
                    Console.ReadKey();
                }

                else if (SecondEndOptions == "extra msg")
                {
                    Console.WriteLine("You can re-calculate for 5 times at this version.");
                }

                // If the user types 'close', the app will also close
                else if (SecondEndOptions == "close")
                {
                    Console.WriteLine("Closing...");

                    // Environment.Exit(5) will close the app
                    Environment.Exit(5);
                }

                // This prevents the app from automatically closing
                Console.ReadKey();
            }

            // If the user types 'close', the app will also close
            else if (endOptions == "close")
            {
                Console.WriteLine("Closing...");

                // Environment.Exit(5) will close the app
                Environment.Exit(5);
            }

            // This prevents the app from automatically closing
            Console.ReadKey();
        }
    }
}