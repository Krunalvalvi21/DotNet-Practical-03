using System;

namespace ExpenseTrakingSystem
{
    class Expense
    {
        public int ExpenseId;
        public string Category;
        public double Amount;
        public string PaymentMode;
        public DateTime ExpenseDate;

        public static double TotalExpense = 0;

        public void AddExpense()
        {
            Console.Write("Enter Expense ID: ");
            ExpenseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Category: ");
            Category = Console.ReadLine();

            Console.Write("Enter Amount: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            if (Amount <= 0)
            {
                throw new Exception("Amount must be greater than 0.");
            }

            TotalExpense += Amount;

            Console.Write("Enter Payment Mode: ");
            PaymentMode = Console.ReadLine();

            Console.Write("Enter Expense Date (dd/mm/yyyy): ");
            ExpenseDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nExpense Added Successfully.\n");
        }

        public void DisplayExpense()
        {
            Console.WriteLine("\n------ Expense Details ------");
            Console.WriteLine("Expense ID   : " + ExpenseId);
            Console.WriteLine("Category     : " + Category);
            Console.WriteLine("Amount       : " + Amount);
            Console.WriteLine("Payment Mode : " + PaymentMode);
            Console.WriteLine("Expense Date : " + ExpenseDate.ToShortDateString());
            Console.WriteLine("------------------------------\n");
        }

        public void DisplayTotalExpense()
        {
            Console.WriteLine("\n------ Total Expense ------");
            Console.WriteLine("Total Expense : " + TotalExpense);
            Console.WriteLine("---------------------------\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Expense exp = new Expense();

            while (true)
            {
                Console.WriteLine("===== Expense Tracking System =====");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. Display Expense");
                Console.WriteLine("3. Total Expense");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Choice: ");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            exp.AddExpense();
                            break;

                        case 2:
                            exp.DisplayExpense();
                            break;

                        case 3:
                            exp.DisplayTotalExpense();
                            break;

                        case 4:
                            Console.WriteLine("Thank You!");
                            return;

                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter only numbers where required.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine();
            }
        }
    }
}