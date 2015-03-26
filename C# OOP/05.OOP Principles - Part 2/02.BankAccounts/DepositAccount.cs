namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DepositAccount : Account, IDeposit, IWithdraw
    {
        private double saveRate = 0.0;

        public DepositAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
            if (this.Balance > 0 && this.Balance <= 1000)
            {
                this.saveRate = interestRate;
                this.InterestRate = 0.0;
            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new IndexOutOfRangeException("You can't depoisit negative amounts !");
            }

            this.Balance += amount;

            if (this.Balance > 1000)
            {
                this.InterestRate = this.saveRate;
            }
            else
            {
                this.InterestRate = 0.0;
            }
        }

        public void Withdraw(double amount)
        {
            if ((this.Balance - amount) < 0 || amount < 0)
            {
                throw new IndexOutOfRangeException("You can't withdraw a negative amount !");
            }

            this.Balance -= amount;
        }
    }
}
