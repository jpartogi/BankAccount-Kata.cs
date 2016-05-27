namespace BankAccount
{
    public class Account
    {
        private Owner owner;
        private string accountNumber;
        public double balance { private set; get; }

        public Account(string accountNumber, double initialBalance, Owner owner)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.owner = owner;
        }

        public void Save(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            this.balance -= amount;
        }
    }
}