using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public class MortgageAccount : Account, IDeposit
    {
        public MortgageAccount(Customer customer, double balance, double interestRate) : base(customer, balance, interestRate) { }
        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }
        public override double CalculateInterestRate(double months)
        {
            if (months <= 12 && (this.Customer is CompanyCustomers))
            {
                return base.CalculateInterestRate(months) / 2;
            }
            if (months <= 6 && (this.Customer is InvidualCustomer))
            {
                return 0.0;
            }

            return base.CalculateInterestRate(months);
        }

    }
}
