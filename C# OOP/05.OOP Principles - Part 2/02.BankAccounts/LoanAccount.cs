namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LoanAccount : Account, IDeposit, IWithdraw
    {
        public LoanAccount(Customer customer, double balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }

        public override double CalculateInterestRate(double months)
        {
            if (this.Customer is InvidualCustomer)
            {
                months = Math.Max(0, months - 3);
            }
            else
            {
                months = Math.Max(0, months - 2);
            }

            return base.CalculateInterestRate(months);
        }
    }
}
