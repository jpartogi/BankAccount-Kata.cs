namespace BankAccount
{
    using NUnit.Framework;

    public class BankTest
    {
        private Bank bank;
        private Owner owner;
        private Account account;

        [SetUp]
        public void SetUp()
        {
            this.bank = new Bank();
            this.owner = new Owner("John Doe");
            this.account = new Account("A123", 10000, owner);
        }

        [Test]
        public void TestSaveMoney()
        {
            double fiveThousands = 5000;

            account.Save(fiveThousands);

            Assert.AreEqual(15000, account.balance);
        }

        [Test]
        public void TestWithdrawMoney()
        {
            double fiveThousands = 5000;

            account.Withdraw(fiveThousands);

            Assert.AreEqual(5000, account.balance); 
        }
    }
}
