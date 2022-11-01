using System.Globalization;

namespace FixationExercises
{
    class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
        }

        public BankAccount(int number, string holder, double initialDeposit) : this(number, holder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double moneyAmount)
        {
            Balance += moneyAmount;
        }

        public void Withdraw(double moneyAmount)
        {
            Balance -= 5;
            Balance -= moneyAmount;
        }

        public override string ToString()
        {
            return $"Conta: {Number}, Titular: {Holder}, Saldo: R$ {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
