namespace _2_BankTransactionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(4000);
            account.ShowBalance();

            account.Withdraw(3000);

            account.Withdraw(40000);

            account.Deposit(4000);


            Console.ReadKey();
        }
        
        public class BankAccount
        {
            private int balance;

            public BankAccount(int balance)
            {
                this.balance = balance;
            }

            public void Withdraw(double amount)
            {

                if (balance >= amount)
                {
                    int intamount = Convert.ToInt32(amount);
                    balance -= intamount;
                    Console.WriteLine($"Your balance after withrawal({amount}): {balance}");
                }
                else
                {
                    Console.WriteLine("Your balance is not enough! ");
                }

            }

            public void Deposit(double amount)
            {
                int intamount = Convert.ToInt32(amount);
                balance += intamount;
                Console.WriteLine($"Your balance after deposit({amount}): {balance}");

            }
            public void ShowBalance()
            {
                Console.WriteLine($"Your balance: {balance}");
            }
        }
    }
}
