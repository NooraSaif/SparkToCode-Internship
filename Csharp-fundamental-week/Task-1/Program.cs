using System.ComponentModel.Design;
using System.Numerics;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task-1 create personal info cart 
            //string name = "Noora saif";
            //int age = 24;
            //double height = 1.53;
            //bool isStudent = false;

            //Console.Write("Name: " + name + ", Age: " + age + ", Height: " + height + ", Student: " + isStudent);
            ///////////////////////////////////////////////////////////////////////////////////////////////////////

            //task-2 create Rectangle calculator
            //Console.WriteLine("Enter the length of the rectangle: ");
            //double length = double.Parse (Console.ReadLine());

            //Console.WriteLine("Enter the width of the rectangle: ");
            //double width = double.Parse (Console.ReadLine());

            //double Area = length * width;
            //double Perimeter = 2 * (length + width);

            //Console.WriteLine("Area of the rectangle in meter: " + Area );
            //Console.WriteLine("Perimeter of the rectangle in sequere meter: " + Perimeter);
            /////////////////////////////////////////////////////////////////////////////////

            //task-3 Create Odd or Even Number Checker
            //Console.WriteLine("Enter a whole number: ");
            //double num = double.Parse (Console.ReadLine());

            //double result = num % 2;

            //if (result == 0)
            //{
            //    Console.WriteLine("Even number");
            //}
            //else if (result == 1)
            //{
            //    Console.WriteLine("Odd number");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number, please use only a whole number");
            //}
            ////////////////////////////////////////////////

            //Task-4 Create Voting Eligibility Checker
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse (Console.ReadLine());

            //Console.WriteLine("Do you have a valid national ID ? (yes/no): ");
            //string hasID = Console.ReadLine();

            //bool hasValidID = hasID == "yes";

            //if (age >= 18 && hasValidID == true)
            //{
            //    Console.WriteLine("You are eligible to vote.");
            //}
            //else 
            //{
            //    Console.WriteLine("You are not eligible to vote.");
            //}
            ///////////////////////////////////////////////////////////////////

            //Task-5 Grade letter lookup

            //Console.WriteLine("Grade Options:");
            //Console.WriteLine("A");
            //Console.WriteLine("B");
            //Console.WriteLine("C");
            //Console.WriteLine("D");
            //Console.WriteLine("F");

            //Console.WriteLine("Select a grade:");
            //char grade = char.Parse (Console.ReadLine());

            //switch (grade) 
            //{
            //    case 'A':
            //        Console.WriteLine("Excellent");
            //        break;
            //    case 'B':
            //        Console.WriteLine("Very Good");
            //        break;
            //    case 'C':
            //        Console.WriteLine("Good");
            //        break;
            //    case 'D':
            //        Console.WriteLine("Pass");
            //        break;
            //    case 'F':
            //        Console.WriteLine("Fail");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid grade");
            //        break;

            //}
            //////////////////////////////////////////////////////////////

            //Task-6 Temperature Converter
            //Console.WriteLine("Enter the temperature in Celsius:");
            //double C = double.Parse (Console.ReadLine());

            //double F = (C * 9 / 5) + 32;

            //Console.WriteLine("Temperature in Fahrenheit: " + F);

            //if (C < 10) 
            //{
            //    Console.WriteLine("Cold");
            //}

            //else if (C >= 10 && C <= 30)
            //{
            //    Console.WriteLine("Mild");
            //}
            //else if (C > 30)
            //{
            //    Console.WriteLine("Hot");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid temperature");
            //}
            ////////////////////////////////////////////////////////////

            //Task-7 Movie Ticket Price Calculator
            //Console.WriteLine("Enter your age in year: ");
            //int age = int.Parse(Console.ReadLine());

            //if (age >= 0 && age <= 12)
            //{
            //    Console.WriteLine("You are a child. and your ticket price is 2.000 OMR");
            //}
            //else if (age >= 13 && age <= 59)
            //{
            //    Console.WriteLine("You are a Adults. and your ticket price is 5.000 OMR");
            //}
            //else if (age >= 60)
            //{
            //    Console.WriteLine("You are a Seniors. and your ticket price is 3.000 OMR");
            //}
            //else 
            //{
            //    Console.WriteLine("Invalid age, please enter a valid age.");
            //}
            ////////////////////////////////////////////////////////////////////

            //Task-8 create Restaurant Bill Calculator with Membership Discount
            //Console.WriteLine("Enter your total bill amount");
            //double billAmount = double.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a loyalty member? (yes/no)");
            //string isloyal = Console.ReadLine();

            //bool loyalityMember = isloyal == "yes";

            //if (billAmount >= 20 && loyalityMember == true)
            //{
            //    double afterDiscount = billAmount - (billAmount * 0.15);
            //    Console.WriteLine("Your discount is 15%. Your final bill amount is: " + afterDiscount + " OMR");
            //}
            //else 
            //{
            //    Console.WriteLine("You do not have a discount. our final bill amount is: " + billAmount);
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////

            //Task-9 Day name finder
            //Console.WriteLine("Enter number from 1 to 7 to represent the day of the week ");
            //int day = int.Parse(Console.ReadLine());

            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Thursday");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid number, please enter a number from 1 to 7.");
            //        break;
            ////////////////////////////////////////////////////////////////////////////

            //Task-10 Mini Calculator
            //Console.WriteLine("Enter the first number");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the secound number");
            //int num2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Select operator charachter (+, -, *, /, %) ");
            //string form = Console.ReadLine();

            //switch (form) 
            //{ 
            //    case "+":
            //        Console.WriteLine("The result is: " + (num1 + num2));
            //        break;
            //    case "-":
            //        Console.WriteLine("The result is: " + (num1 - num2));
            //        break;
            //    case "*":
            //        Console.WriteLine("The result is: " + (num1 * num2));
            //        break;
            //    case "/":
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("The result is: " + (num1 / num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not allowed.");
            //        }
            //        break;
            //    case "%":
            //        if (num2 != 0)
            //        {
            //            Console.WriteLine("The result is: " + (num1 % num2));
            //        }
            //        else
            //        {
            //            Console.WriteLine("Division by zero is not allowed.");
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator, please select a valid operator (+, -, *, /, %).");
            //        break;  
            //}
            ///////////////////////////////////////////////////////////////////////////////////////////

            //Task-11 Loan Eligibility System 
            //Console.WriteLine("Enter your age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter your monthly income: ");
            //double income = double.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have an existing loan ? (yes/no)");
            //string hasLoan = Console.ReadLine();

            //bool existingLoan = hasLoan == "yes";

            //if (age >= 21 && age <= 60 && income >= 400 && !(existingLoan))
            //{
            //    Console.WriteLine("Eligible for a loan.");
            //}
            //else if ((age < 21 || age > 60) && income >= 400 && !(existingLoan)) 
            //{
            //    Console.WriteLine("not eligible for a loan due to age out of range");
            //}
            //else if (age >= 21 && age <= 60 && income < 400 && !(existingLoan))
            //{
            //    Console.WriteLine("not eligible for a loan due to income is too low");
            //}
            //else if (age >= 21 && age <= 60 && income >= 400 && existingLoan == true)
            //{
            //    Console.WriteLine("not eligible for a loan due to has an existing loan");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Please check your input and try again.");
            //}
            /////////////////////////////////////////////////////

            //Task-12 Shipping Cost Calculator
            //Console.WriteLine("Choose the region code");
            //Console.WriteLine("A. Local");
            //Console.WriteLine("B. National");
            //Console.WriteLine("C. International");
            //char region = char.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the package weight in Kg ");
            //double weight = double.Parse(Console.ReadLine());

            //switch (region) 
            //{
            //    case 'A':
            //        Console.WriteLine("Local base cost is 1.000 OMR");
            //        if (weight >= 5)
            //        {
            //            Console.WriteLine("Extra chatge for this weight is 2.000 OMR");
            //            double totalCost = 1.000 + 2.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        else if (weight >= 10)
            //        {
            //            Console.WriteLine("Extra chatge for this weight is 5.000 OMR");
            //            double totalCost = 1.000 + 5.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No extra charge for this weight");
            //            double totalCost = 1.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        break;

            //    case 'B':
            //        Console.WriteLine("Local base cost is 3.000 OMR");
            //        if (weight >= 5)
            //        {
            //            Console.WriteLine("Extra chatge for this weight is 2.000 OMR");
            //            double totalCost = 3.000 + 2.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        else if (weight >= 10)
            //        {
            //            Console.WriteLine("Extra chatge for this weight is 5.000 OMR");
            //            double totalCost = 3.000 + 5.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No extra charge for this weight");
            //            double totalCost = 3.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        break;

            //    case 'C':
            //        Console.WriteLine("Local base cost is 7.000 OMR");
            //        if (weight >= 5)
            //        {
            //            Console.WriteLine("Extra chatge for this weight is 2.000 OMR");
            //            double totalCost = 7.000 + 2.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        else if (weight >= 10)
            //        {
            //            Console.WriteLine("Extra chatge for this weight is 5.000 OMR");
            //            double totalCost = 7.000 + 5.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No extra charge for this weight");
            //            double totalCost = 7.000 + weight;
            //            Console.WriteLine("Your Total shiping cost is : " + totalCost + "OMR");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("error: please try again");
            //        break;
            //}
            ///////////////////////////////////////////////////////////////

            //Task-13 Triangle Type Classifier
            //Console.WriteLine("Enter the length of side 1: ");
            //double side1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the length of side 2: ");
            //double side2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the length of side 3: ");
            //double side3 = double.Parse(Console.ReadLine());

            //if ((side1 + side2) > side3)
            //{
            //    Console.WriteLine("The triangle is valid.");

            //    if (side1 == side2 && side2 == side3 && side3 == side1)
            //    {
            //        Console.WriteLine("The type of the triangle is Equilateral");
            //    }
            //    else if (side1 == side2 || side2 == side3 || side3 == side1)
            //    {
            //        Console.WriteLine("The type of the triangle is Isosceles");
            //    }
            //    if (side1 != side2 && side2 != side3 && side3 != side1)
            //    {
            //        Console.WriteLine("The type of the triangle is Scalene");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("The triangle is not valid.");
            //}
            ///////////////////////////////////////////////////////////

            //Task-14 Online store checkout 
            //Console.WriteLine("select a product by Entering the product code (1, 2, 3): ");
            //Console.WriteLine("1. Headphone ");
            //Console.WriteLine("2. Keyboard ");
            //Console.WriteLine("3. Mouse ");
            //int productCode = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the number of products you want to buy: ");
            //int quantity = int.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have discount coupon? (yes/no): ");
            //string coupon = Console.ReadLine();

            //bool hasCoupon = coupon == "yes";

            //switch (productCode)
            //{
            //    case 1:
            //        Console.WriteLine("you selected a Headphone. the unit price is 8.500 OMR");
            //        double subtotal1 = quantity * 8.500;
            //        Console.WriteLine("the subtotal is " + subtotal1 + "OMR");

            //        if (subtotal1 >= 20 && hasCoupon == true)
            //        {
            //            Console.WriteLine("You have a 10% discount");
            //            Console.WriteLine("the tax is 5%");
            //            double afterDiscount = subtotal1 - (subtotal1 * 0.10);
            //            double afterTax = afterDiscount + (afterDiscount * 0.05);
            //            Console.WriteLine("the total after discount is " + afterDiscount + "OMR");
            //            Console.WriteLine("the final total after appling the tax is " + afterTax + "OMR");
            //        }
            //        else 
            //        {
            //            Console.WriteLine("No discount");
            //        }

            //        break;

            //    case 2:
            //        Console.WriteLine("you selected a Keyboard. the unit price is 12.000 OMR");
            //        double subtotal2 = quantity * 12.000;
            //        Console.WriteLine("the subtotal is " + subtotal2 + "OMR");

            //        if (subtotal2 >= 20 && hasCoupon == true)
            //        {
            //            Console.WriteLine("You have a 10% discount");
            //            Console.WriteLine("the tax is 5%");
            //            double afterDiscount = subtotal2 - (subtotal2 * 0.10);
            //            double afterTax = afterDiscount + (afterDiscount * 0.05);
            //            Console.WriteLine("the total after discount is " + afterDiscount + "OMR");
            //            Console.WriteLine("the final total after appling the tax is " + afterTax + "OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No discount");
            //        }
            //        break;

            //    case 3:
            //        Console.WriteLine("you selected a Mouse. the unit price is 5.000 OMR");
            //        double subtotal3 = quantity * 5.000;
            //        Console.WriteLine("the subtotal is " + subtotal3 + "OMR");

            //        if (subtotal3 >= 20 && hasCoupon == true)
            //        {
            //            Console.WriteLine("You have a 10% discount");
            //            Console.WriteLine("the tax is 5%");
            //            double afterDiscount = subtotal3 - (subtotal3 * 0.10);
            //            double afterTax = afterDiscount + (afterDiscount * 0.05);
            //            Console.WriteLine("the total after discount is " + afterDiscount + "OMR");
            //            Console.WriteLine("the final total after appling the tax is " + afterTax + "OMR");
            //        }
            //        else
            //        {
            //            Console.WriteLine("No discount");
            //        }
            //        break;

            //    default:
            //        Console.WriteLine("Invalid product code");
            //        break;
            //}
            ///////////////////////////////////////////////

            //Task-15 University admission decision
            Console.WriteLine("select a program code");
            Console.WriteLine("S for science ");
            Console.WriteLine("A for Arts");
            char programType = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the applicant's GPA (out of 4.0)");
            double GPA = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter exam score (out of 100)");
            double examScore = double.Parse(Console.ReadLine());

            Console.WriteLine("Do you have extracurricular achievements (yes/no)");
            string achievement = Console.ReadLine();

            bool hasAchievements = achievement == "yes";

            switch (programType)
            {
                case 'S':
                    if (GPA >= 3.0 && GPA <= 4.0 && examScore >= 75 && examScore <= 100)
                    {
                        Console.WriteLine("Admitted to Science program");
                    }
                    else if (GPA > 4.0 && examScore > 100)
                    {
                        Console.WriteLine("You enterd invalied numbers");
                    }
                    else if (hasAchievements == true)
                    {
                        Console.WriteLine("Conditinally admission to Science program");
                    }
                    else
                    {
                        Console.WriteLine("Not admitted to Science program");
                    }
                    break;

                case 'A':
                    if (GPA >= 2.5 && examScore >= 60)
                    {
                        Console.WriteLine("Admitted to Arts program");
                    }
                    else if (GPA > 4.0 && examScore > 100)
                    {
                        Console.WriteLine("You enterd invalied numbers");
                    }
                    else if (hasAchievements == true)
                    {
                        Console.WriteLine("Conditinally admission to Arts program");
                    }
                    else
                    {
                        Console.WriteLine("Not admitted to Arts program");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid program code");
                    break;
            }
        }
    }
}
