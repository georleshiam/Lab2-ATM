namespace Lab2
{
   
   
       
public class Program
    {
        // Static variable to hold the current balance of the account
        public static decimal Balance = 0;

        public static void Main(string[] args)
        {
            // Call the user interface method to activate the application
            RunATM();
        }

        public static void RunATM()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Welcome to the ATM. Please choose an option:");
                Console.WriteLine("1. View Balance");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Deposit");
                Console.WriteLine("4. Exit");

                

                Console.WriteLine();
            }
        }

        public static void ViewBalance()
        {
            Console.WriteLine($"Current balance: {Balance:C}");
        }

        public static void Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                if (amount > Balance)
                {
                    Console.WriteLine("Insufficient balance.");
                }
                else if (amount < 0)
                {
                    Console.WriteLine("Invalid amount.");
                }
                else
                {
                    Balance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {Balance:C}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }
        }

        public static void Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                if (amount < 0)
                {
                    Console.WriteLine("Invalid amount.");
                }
                else
                {
                    Balance += amount;
                    Console.WriteLine($"Successfully deposited {amount:C}. New balance: {Balance:C}");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid amount.");
            }
        }
    }


}
