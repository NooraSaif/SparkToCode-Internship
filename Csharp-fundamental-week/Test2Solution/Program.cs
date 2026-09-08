using System.ComponentModel;

namespace Test2Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1 Countdown Time
            //Console.WriteLine("Enter a starting number");
            //int startNum = int.Parse(Console.ReadLine());

            //for (int i = startNum; i >=0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("Liftoff!");
            /////////////////////////////////////////

            //Task-2 Sum of number 1 to N
            //Console.WriteLine("Enter a positive whole number");
            //int n = int.Parse(Console.ReadLine());

            //int Sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    Sum = Sum + i;
            //    Console.WriteLine(Sum);
            //}
            ////////////////////////////////////////

            //Task-3 Mutiplication Table
            //Console.WriteLine("Enter a number");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 10; i++)
            //{
            //    int result = n * i;
            //    Console.WriteLine(n + "*" + i + "=" + result);
            //}
            //////////////////////////////////////////

            //Task-4 passwored retry

            //string passwored = "Spark2026";

            //Console.WriteLine("Enter Your passwored");
            //string userInpute = Console.ReadLine();

            //while (passwored != userInpute)
            //{
            //    Console.WriteLine("Incorrect passwored, please try again");
            //    Console.WriteLine("Enter Your passwored");
            //    userInpute = Console.ReadLine();
            //}
            //Console.WriteLine("Access Granted");
            //////////////////////////////////////////////////////

            //Task-5 Number Guessing Game
            //int secretNumber = 42;
            //int userGuess;
            //int counter = 0;

            //do
            //{
            //    Console.WriteLine("Enter your guess number");
            //    userGuess = int.Parse(Console.ReadLine());
            //    counter++;

            //    if (userGuess < secretNumber)
            //    {
            //        Console.WriteLine("Too low!");
            //    }
            //    else if (userGuess > secretNumber)
            //    {
            //        Console.WriteLine("Too high!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Correct!");
            //        break;
            //    }

            //} while (userGuess != secretNumber); 
            //{ 
            //    Console.WriteLine($"You guessed the number in {counter} attempts.");
            //}
            /////////////////////////////////////////////////

            //Task-6 Safe division calculator
            //try
            //{
            //    Console.WriteLine("Enter the first number");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter the second number");
            //    double num2 = double.Parse(Console.ReadLine());

            //    double result = num1 / num2;

            //    Console.WriteLine($"The result of {num1} divided by {num2} is: {result}");

            //} 
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}

            /////////////////////////////////////////////////
            //Task-7 Repeated Menu with Exit Options

            //bool keepRunning = true;
            //int userInpute;

            //while (keepRunning)
            //{
            //    try 
            //    {
            //        Console.WriteLine("Menu option: ");
            //        Console.WriteLine("1: say hello ");
            //        Console.WriteLine("2: show current time-of-day greeting ");
            //        Console.WriteLine("3: Exit");
            //        userInpute = int.Parse(Console.ReadLine());

            //        switch (userInpute)
            //        {
            //            case 1:
            //                Console.WriteLine("Hello!");
            //                break;

            //            case 2:
            //                Console.WriteLine("Good morning!");
            //                break;

            //            case 3:
            //                Console.WriteLine("Exiting the program.");
            //                keepRunning = false;
            //                break;

            //            default:
            //                Console.WriteLine("Invalid choice. Please try again.");
            //                break;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a number from the menu options.");
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            ////////////////////////////////////////////////////////////

            //Task - 8 Sum of Even Numbers only
            //Console.WriteLine("Enter a positive whole number");
            //int n = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        sum += i;
            //    }

            //}
            //Console.WriteLine($"The sum from 1 to " + n + " is: " + sum);
            /////////////////////////////////////////////////////////////////////

            //Task-9 Validated positive number input

            //int userInpute = 0; // declere the variable outside the loop to use it later in for loop
            //bool isValidInput = false;


            //do
            //{
            //    // to handel string input and other invalid inputs
            //    try
            //    {
            //        Console.WriteLine("Enter a positive whole number");
            //        userInpute = int.Parse(Console.ReadLine());

            //        // to handle if user enters a negative number or zero
            //        if (userInpute <= 0)
            //        {
            //            Console.WriteLine("Invalid input. Please enter a positive whole number.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"You entered a valid positive whole number: " + userInpute);
            //            isValidInput = true; 
            //        }

            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }

            //// this will keep looping until the user enters a valid positive whole number (until its true)
            //} while (isValidInput == false);

            //int total = 0;

            //for (int i = 1; i <= userInpute; i++)
            //{
            //    total = total + i;
            //    Console.WriteLine(total);
            //}

            /////////////////////////////////////////////////////////////////////////////////////

            //Task-10 Simple ATM sitmulation

            // fixed correct PIN and starting balance
            int correstPIN = 1234;
            double startingBalance = 100.000; 

            int maxAttempts = 3;
            int userInput = 0;

            // PIN entry loop up to 3 attempts
            for (int attempt = 1; attempt <= maxAttempts; attempt++)
            {
                try
                {
                    Console.Write("Enter your 4-digit PIN: ");
                    userInput = Convert.ToInt32(Console.ReadLine());

                    if (userInput == correstPIN)
                    {
                        Console.WriteLine("PIN accepted! Welcome to your account.");
                        break; // Exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Incorrect PIN. Attempts remaining: " + (maxAttempts - attempt));
                    }
                }
                catch (Exception x)
                {
                    Console.WriteLine(x.Message);
                    Console.WriteLine("Attempts remaining: " + (maxAttempts - attempt));
                }
            }

            // If user failed all 3 attempts, stop the program
            if (userInput != correstPIN)
            {
                Console.WriteLine("Card Blocked");
                return; // Stop the program completly
            }

            // Repeating ATM Menu Loop after successful PIN entry
            bool keepRunning = true;
            string choice;

            while (keepRunning)
            {
                Console.WriteLine("--- ATM MENU ---");
                Console.WriteLine("1) Deposit");
                Console.WriteLine("2) Withdraw");
                Console.WriteLine("3) Check Balance");
                Console.WriteLine("4) Exit");
                Console.WriteLine("Choose an option (1-4): ");

                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Deposit - Add to balance
                        try
                        {
                            Console.Write("Enter deposit amount (OMR): ");
                            double depositAmount = double.Parse(Console.ReadLine());

                            if (depositAmount <= 0)
                            {
                                Console.WriteLine("Error: Deposit amount must be positive number.");
                            }
                            else
                            {
                                startingBalance += depositAmount;
                                Console.WriteLine("Current Balance: " + startingBalance + " OMR");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: non-numeric input.");
                        }
                        break;

                    case "2": // Withdraw - Subtract from balance
                        try
                        {
                            Console.Write("Enter withdrawal amount (OMR): ");
                            double withdrawAmount = double.Parse(Console.ReadLine());

                            if (withdrawAmount <= 0)
                            {
                                Console.WriteLine("Error: Withdrawal amount must be positive number.");
                            }
                            else if (withdrawAmount > startingBalance)
                            {
                                Console.WriteLine("Error: it is grater than your current balence. Your balance is " + startingBalance + " OMR.");
                            }
                                else
                            {
                                startingBalance -= withdrawAmount; 
                                Console.WriteLine("Current Balance: " + startingBalance + " OMR");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error: non-numeric input.");
                        }
                        break;

                    case "3": // Check Balance
                        Console.WriteLine("Your current balance is: " + startingBalance + " OMR");
                        break;

                    case "4": // Exit
                        Console.WriteLine("Goodbye!");
                        keepRunning = false; 
                        break;

                    default: 
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 4");
                        break;
                }
            }

        }
    }
}
