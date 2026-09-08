using System.Reflection.Metadata.Ecma335;

namespace OOP_Task1Solution
{
    public class BankAccount 
    {
        //Properties
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        //methods or functions 
        public void Deposit(double amount) 
        {
            Balance += amount;
            SendEmail();
        }
        public void Withdraw(double amount) 
        {
            if (amount < Balance)
            {
                Balance -= amount;
                SendEmail();
            }
            else
            {
                Console.WriteLine("Invalide Input");
            }
        }
        public double CheckBalance() 
        {
            PrintInformation();
            return Balance;
        }
        private void PrintInformation() 
        {
            Console.WriteLine("\n---Account Information---");
            Console.WriteLine("User number: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }
        private void SendEmail()
        {
            Console.WriteLine("Notivication email sent to the user");
        }
    }
    
    public class Student 
    {
        //properties
        public int Grade;
        public string Name;
        public string Address;
        private string email; // private access (only accesseable inside Student class)
        int age; // defult access (private)

        //Methods
        public void Register(string Email) 
        {
            email = Email;
            SendEmail();
        }
        private void SendEmail() 
        {
            Console.WriteLine("registration email sent successfully");
        }
    }

    public class Product 
    {
        //properties
        public string ProductName;
        public double Price;
        public int StockQuantity;

        //method or function 
        public void Sell(int quantity) 
        {
            if (quantity > StockQuantity)
            {
                Console.WriteLine("not enough stock");
            }
            else
            {
                StockQuantity -= quantity;
            }
            LogTransaction();

        }       
        public void Restock(int quantity)
        {
            StockQuantity -= quantity;
            LogTransaction();
        }
        public double GetInventoryValue() 
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        private void PrintDetails()
        {
            Console.WriteLine("\n---Product's Information---");
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Stock: " + StockQuantity);
            Console.WriteLine("Price: " + Price);
        }
        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged successfully");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Crated Object of class 
            BankAccount account1 = new BankAccount();
            account1.AccountNumber = 1163;
            account1.HolderName = "karim";
            account1.Balance = 120;

            BankAccount account2 = new BankAccount();
            account1.AccountNumber = 15203;
            account1.HolderName = "Ali";
            account1.Balance = 63;

            Student s1 = new Student();
            s1.Grade = 65;
            s1.Name = "Ali";
            s1.Address = "Muscat";

            Student s2 = new Student();
            s1.Grade = 70;
            s1.Name = "Ahmed";
            s1.Address = "Muscat";

            Product p1 = new Product();
            p1.ProductName = "Wireless Mouse";
            p1.Price = 5.500;
            p1.StockQuantity = 50;

            Product p2 = new Product();
            p1.ProductName = "Mechanical Keyboard";
            p1.Price = 15.750;
            p1.StockQuantity = 20;



            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    //case 1: ViewAccountDetails(); break;
                    //case 2: UpdateStudentAddress(); break;
                    //case 3: MakeDeposit(); break;
                    //case 4: MakeWithdrawal(); break;
                    //case 5: ViewProductDetails(); break;
                    //case 6: RegisterStudent(); break;
                    //case 7: CompareAccountBalances(); break;
                    //case 8: RestockProduct(); break;
                    //case 9: TransferBetweenAccounts(); break;
                    //case 10: UpdateStudentGrade(); break;
                    //case 11: StudentReportCard(); break;
                    //case 12: AccountHealthStatus(); break;
                    //case 13: BulkSaleWithRevenue(); break;
                    //case 14: ScholarshipEligibilityCheck(); break;
                    //case 15: FullBalanceTopUpFlow(); break;
                    //case 16: QuickAccountOpening(); break;
                    //case 17: TotalStudentsCounter(); break;
                    //case 18: OverdrawnAccountCheck(); break;
                    //case 19: SetStudentSecurityPin(); break;

                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
            }

        }
    

    }
}
