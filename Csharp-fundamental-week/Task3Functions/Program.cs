using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task-1 Absolute Difference
            //Console.WriteLine("Enter the first number: ");
            //int num1 = Convert.ToInt32 (Console.ReadLine());

            //Console.WriteLine("Enter the second number: ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //int result = num2 - num1;
            //Console.WriteLine($"The absolute difference between {num1} and {num2} is: {Math.Abs(result)}");
            ////////////////////////////////////////////////////////////////////////////////////////////////

            //Task 2 - Power & Root Explorer
            //Console.WriteLine("Enter a number: ");
            //double num = Convert.ToInt32(Console.ReadLine());

            //double result1 = Math.Pow(num, 2);
            //double result2 = Math.Sqrt(num);

            //Console.WriteLine($"The square of {num} is: {result1}");
            //Console.WriteLine($"The square root of {num} is: {result2}");
            ///////////////////////////////////////////////////////////////

            //Task 3 - Name Formatter
            //Console.WriteLine("Enter your full name: ");
            //string UserName = Console.ReadLine();

            //Console.WriteLine("Your name in uppercase: " + UserName.ToUpper());
            //Console.WriteLine("Your name in lowercase: " + UserName.ToLower());
            //Console.WriteLine("the number of characters in your name is: " + UserName.Length);
            //////////////////////////////////////////////////////

            //Task 4 - Subscription End Date
            //Console.WriteLine("enter the number of days of a free trial: ");
            //int freeTrialDays = Convert.ToInt32(Console.ReadLine());

            //DateTime today = DateTime.Today;
            //DateTime endate = today.AddDays(freeTrialDays);

            //Console.WriteLine("Today is :" + today.ToString("dd/MM/yyyy"));
            //Console.WriteLine("The free trial will end on: " + endate.ToString("dd/MM/yyyy"));
            //////////////////////////////////////////////////////////////

            //Task 5 - Grade Rounding System
            //Console.WriteLine("Enter your exam score as a decimal number: ");
            //double num = double.Parse(Console.ReadLine());

            //double wholeNumber = Math.Round(num);

            //Console.WriteLine("Your rounded score is: " + wholeNumber);

            //if (wholeNumber >= 60)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Fail");

            //}
            //////////////////////////////////////////////////////////

            //Task 6 - Password Strength Checker
            //Console.WriteLine("Enter password: ");
            //string passwored = Console.ReadLine();

            //int lenght = passwored.Length;
            //bool contains = passwored.Contains("passwored");

            //if (lenght >= 8 && contains == false)
            //{
            //    Console.WriteLine("Strong password");
            //}
            //else
            //{
            //    Console.WriteLine("Weak password");
            //}
            /////////////////////////////////////////////////////////

            //Task 7 - Clean Name Comparator

            //Console.WriteLine("Enter your name: ");
            //string name1 = Console.ReadLine();

            //Console.WriteLine("Confirm your name: ");
            //string name2 = Console.ReadLine();

            //string trimmed1 = name1.Trim();
            //string trimmed2 = name2.Trim();

            //if (trimmed1.ToUpper() == trimmed2.ToUpper()) 
            //{
            //    Console.WriteLine("Names match");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Names do not match"); 
            //}
            ///////////////////////////////////////////////

            //Task 8 - Membership Expiry Checker
            //Console.WriteLine("Enter your membership start date: (y-m-d) ");
            //string startDay = Console.ReadLine();

            //Console.WriteLine("Enter the number of valid membership days: ");
            //int validDays = int.Parse(Console.ReadLine());

            //DateTime parsedDate = DateTime.Parse(startDay);
            //DateTime expiryDate = parsedDate.AddDays(validDays);

            //if (DateTime.Now > expiryDate)
            //{
            //    Console.WriteLine("Membership has expired.");
            //}
            //else
            //{
            //    Console.WriteLine("Membership is Active.");
            //}
            /////////////////////////////////////////////////////////////////

            //Task 9 - Round Up / Round Down Explorer

            //Console.WriteLine("Enter a decimal number: ");
            //double num = double.Parse(Console.ReadLine());

            //double wholeNumber = Math.Round(num);
            //double roundedUp = Math.Ceiling(num);
            //double roundedDown = Math.Floor(num);

            //Console.WriteLine("Original number: " + num);
            //Console.WriteLine("Rounded to the nearest whole number: " + wholeNumber);
            //Console.WriteLine("always rounded up: " + roundedUp);
            //Console.WriteLine("always rounded down: " + roundedDown);
            //////////////////////////////////////////////////////////////////

            //Task 10 - Word Position Finder

            //Console.WriteLine("Enter a sentence: ");
            //string sentence = Console.ReadLine();

            //Console.WriteLine("Enter a word: ");
            //string word = Console.ReadLine();

            //int firstindex = sentence.IndexOf(word);
            //int LastIndex = sentence.LastIndexOf(word);

            //if (firstindex == -1)
            //{
            //    Console.WriteLine("The word " + word + " is not found in the sentence.");
            //}
            //else
            //{
            //    Console.WriteLine("The Index Value of " + word + " in the sentence is " + firstindex);
            //    Console.WriteLine("The Last Index Value of " + word + " in the sentence is " + LastIndex);
            //}
            ////////////////////////////////////////////////////////////////////////////////

            //Task 11 One-Time Password(OTP) Generator

            //Random rand = new Random();

            //int generateOTP = rand.Next(1000, 9999);

            //Console.WriteLine("Your 4-digit OTP is: " + generateOTP);
            //Console.WriteLine("-------------------------------------\n");


            //int maxAttempts = 3;
            //int userInput = 0;

            //for (int attempt = 1; attempt <= maxAttempts; attempt++)
            //{
            //    try
            //    {
            //        Console.Write("Enter the OTP send to your device: ");
            //        userInput = Convert.ToInt32(Console.ReadLine());

            //        if (userInput == generateOTP)
            //        {
            //            Console.WriteLine("Verified.");
            //        }

            //    }
            //    catch (FormatException)
            //    {
            //        Console.WriteLine("Invalid input.");
            //    }
            //}

            //// If user failed all 3 attempts
            //if (userInput != generateOTP)
            //{
            //    Console.WriteLine("Verification Failed");
            //}
            ///////////////////////////////////////////////////////////////////

            //Task 12 - Birthday Insights
            Console.WriteLine("Enter your date of birth: (y-m-d) ");
            string userInput = Console.ReadLine();

            DateTime birthDay = DateTime.Parse(userInput);
            DateTime today = DateTime.Today;

            DayOfWeek birthDayOfWeek = birthDay.DayOfWeek;

            int age = today.Year - birthDay.Year;

            if (today.Month < birthDay.Month || (today.Month == birthDay.Month && today.Day < birthDay.Day))
            {
                age--;

                Console.WriteLine($"You are {age} years old.");
                Console.WriteLine($"You were born on {birthDayOfWeek}.");
            }
            ////////////////////////////////////////////////////////////////////
        }
    }
}
