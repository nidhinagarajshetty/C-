namespace BankAccount
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Account acc= new Account();
            acc.Deposit(1000);
            acc.ShowBalance();

            acc.withdraw(2000); 
            acc.ShowBalance();

            acc.withdraw(500);
        }
    }
}
