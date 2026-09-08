using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4Solution
{
    internal class Program
    {
        //Task 1 - Personalized Welcome Functio
        public static void PrintWelcome(string name)
        {
            Console.WriteLine($"Welcome, {name}!");
        }

        //Task 2 - Square Number Function
        public static int Square(int number) 
        {
            return number * number;
        }

        //Task 3 - Celsius to Fahrenheit Function
        public static double CelsiusToFahrenheit(double celsiuse)
        {
            return (celsiuse * 9 / 5) + 32;
        }

        //Task 4 - Fixed Menu Display Function
        public static void DisplayMenu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Help");
            Console.WriteLine("3. Exit");
        }

        //Task 5 - Even or Odd Function
        // bool return and one int parameter
        public static bool IsEven(int number) 
        {
            return number % 2 == 0;
        }

        //Task 6 - Rectangle Area &Perimeter Functions
        //double return and two double parameters
        public static double CalculateArea(double width, double lenght)
        {
            return width * lenght;
        }
        public static double CalculatePerimeter(double width, double lenght)
        {
            return 2 * (width + lenght);
        }

        //Task 7 - Grade Letter Function
        //string return and one int parameter
        public static string GetGradeLetter(int grade)
        {
            if (grade < 0)
            {
                return "Invalid grade";
            }
            else if (grade >= 90)
            {
                return "A";

            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        //Task 8 - Countdown Function
        // Void return and one int parameter
        public static void Countdown (int startNumber)
        {
            for (int i = startNumber; i >= 1; i--)
            {
               Console.WriteLine(i);
            }
        }

        //Task 9 - Overloaded Multiply Function
        //int returns and two int parameters
        static int Multiply(int a, int b)
        { 
            return a * b; 
        }
        // double return and two double parameters 
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        //int return and three int parameters
        static int Multiply(int a, int b, int c)
        {
            return a * b * c;
        }

        //Task 10 - Overloaded Area Calculator
        //double return and single double parameter
        public static double CalculateArea(double side) 
        {
            return side * side;
        }
        //double return and two double parameters
        // An error appeared becuse it had already implemented in Task 6


        //Task 11 - Function-Based Calculator
        static double Add(double a, double b) 
        {
            return a + b;
        }
        static double Subtract(double a, double b)
        {
            return a - b;
        }
        static double MultiplyNumbers(double a, double b)
        {
            return a * b;
        }
        static double DivideNumbers(double a, double b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine("Error: cannot divide by zero");
                return 0;
            }
        }
        static void DisplayResult(string operation, double result)
        {
            Console.WriteLine($"Result of {operation} is:  {result}");
        }

        //Task 12 - Student Report Card Generator
        //return average as double and three double scores as parameters
        static double CalculateAverage(double s1, double s2, double s3)
        {
            return (s1 + s2 + s3) / 3;
        }
        //return grade as string and one paramenter
        static string GetGradeLetter(double average)
        {
            if (average >=90)
            {
                return "A";
            }
            else if (average >=80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        //no returen 
        static void PrintReportCard(string name, double average, string grade)
        {
            Console.WriteLine("---Report Card---");
            Console.WriteLine("Student name: " + name);
            Console.WriteLine("Averge: " + average);
            Console.WriteLine("Letter grade: " + grade);
        }



    static void Main(string[] args)
        {
            //Task 1 - Personalized Welcome Functio
            Console.WriteLine("Enter your name:");
            string userName = Console.ReadLine();

            // call PrintWelcome function
            PrintWelcome(userName);
            /////////////////////////////////////////////////////////

            //Task 2 - Square Number Function
            Console.WriteLine("Enter a whole number to square:");
            int num = Convert.ToInt16(Console.ReadLine());

            // call Square function
            int result = Square(num);
            Console.WriteLine($"The square of {num} is: " + result);
            ///////////////////////////////////////////////////////

            //Task 3 - Celsius to Fahrenheit Function
            Console.WriteLine("Enter the temperature in Celsius:");
            double celsiuseNumber = Convert.ToDouble(Console.ReadLine());

            // call CelsiusToFahrenheit function
            double fahrenheitResult = CelsiusToFahrenheit(celsiuseNumber);
            Console.WriteLine($"{celsiuseNumber} Celsius is equal to {fahrenheitResult} Fahrenheit.");
            ///////////////////////////////////////////////////////////////////////////////////////////

            //Task 4 - Fixed Menu Display Function
            //call DisplayMenu function
            DisplayMenu();
            ////////////////////////////////////////////////////////

            //Task 5 - Even or Odd Function
            Console.WriteLine("Enter a whole number to check if it is even:");
            int userNumber = Convert.ToInt16(Console.ReadLine());

            //call IsEven function
            if (IsEven(userNumber) == true)
            {
                Console.WriteLine("The number is even.");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }
            //////////////////////////////////////////////////////////

            //Task 6 - Rectangle Area & Perimeter Functions
            Console.WriteLine("Enter the width of the rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());

            // call CalculateArea and CalculatePerimeter functions and display the results
            Console.WriteLine($"The area of the rectangle is: {CalculateArea(width, length)}");
            Console.WriteLine($"The perimeter of the rectangle is: {CalculatePerimeter(width, length)}");
            /////////////////////////////////////////////////////////////////////////////////////////

            //Task 7 - Grade Letter Function
            Console.WriteLine("Enter your score:");
            int userScore = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine($"Your grade letter is: {GetGradeLetter(userScore)}");
            ////////////////////////////////////////////////////////////////////////

            //Task 8 - Countdown Function
            Console.WriteLine("Enter a number to start the countdown:");
            int countdownStart = Convert.ToInt16(Console.ReadLine());

            // call Countdown function
            Countdown(countdownStart);
            ///////////////////////////////////////////////////////////////////

            //Task 9 - Overloaded Multiply Function
            Console.WriteLine("----Test Overloaded Multiply Function----");
            // call Multiply function 
            int result1 = Multiply(2, 4);
            double result2 = Multiply(20.5, 10.5);
            int result3 = Multiply(4, 2, 5);

            // display the results
            Console.WriteLine($"Multiply 2 * 4 = {result1}");
            Console.WriteLine($"Multiply 20.5 * 10.5  = {result2}");
            Console.WriteLine($"Multiply 4 * 2 * 5 = {result3}");
            //////////////////////////////////////////////////////////////////

            //Task 10 - Overloaded Area Calculator
            Console.WriteLine("Select the shape code to calculate its area:");
            Console.WriteLine("1) Square");
            Console.WriteLine("2) Rectangle");
            int shapeChoice = Convert.ToInt16(Console.ReadLine());

            switch (shapeChoice)
            {
                case 1:
                    Console.WriteLine("Enter the side lenght of square");
                    double squareSide = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("the area of Square is " + (CalculateArea(squareSide)));
                    break;

                case 2:
                    Console.WriteLine("Enter the width of rectangle");
                    double widthInput = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the length of rectangle");
                    double lengthInput = Convert.ToDouble(Console.ReadLine());

                    double rectangleAreaResult = CalculateArea(widthInput, lengthInput);

                    Console.WriteLine("the area of rectangle is " + rectangleAreaResult);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

            //Task 11 - Function - Based Calculator

            bool isExit = false;

            while (!isExit)
            {
                Console.WriteLine("---Operator Menu--");
                Console.WriteLine("1) Add");
                Console.WriteLine("2) Subtract");
                Console.WriteLine("3) Multiply");
                Console.WriteLine("4) Divide");
                Console.WriteLine("5) Exit");
                Console.Write("Select operator number: ");
                string userChoice = Console.ReadLine();


                if (userChoice == "5")
                {
                    Console.WriteLine("Goodby!");
                    isExit = true;
                    break;
                }
                else if (userChoice != "1" && userChoice != "2" && userChoice != "3" && userChoice != "4")
                {
                    Console.WriteLine("Invalid Choice. plese select from 1-5");
                    continue;
                }


                Console.Write("Enter the first number: ");
                double firstNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number: ");
                double secondNum = Convert.ToDouble(Console.ReadLine());

                switch (userChoice)
                {
                    case "1":
                        DisplayResult("Add", Add(firstNum, secondNum));
                        break;

                    case "2":
                        DisplayResult("Subtract", Subtract(firstNum, secondNum));
                        break;

                    case "3":
                        DisplayResult("Multiply", MultiplyNumbers(firstNum, secondNum));
                        break;

                    case "4":
                        DisplayResult("Divide", DivideNumbers(firstNum, secondNum));
                        break;

                    default:
                        Console.WriteLine("Invalid input. please select from 1-5");
                        break;

                }

            }

            //Task 12 - Student Report Card Generator

            Console.WriteLine("Enter student name: ");
            string studentName = Console.ReadLine();

            Console.WriteLine("Enter score for subject 1: ");
            double s1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter score for subject 2: ");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter score for subject 3: ");
            double s3 = Convert.ToDouble(Console.ReadLine());

            double AvregeResult = CalculateAverage(s1, s2, s3);
            string gradeResult = GetGradeLetter(AvregeResult);
            PrintReportCard(studentName, result, gradeResult);
        }
    }
}