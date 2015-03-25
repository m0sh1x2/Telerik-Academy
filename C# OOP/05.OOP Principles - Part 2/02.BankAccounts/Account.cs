using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BankAccounts
{
    public abstract class Account
    {
        public Account(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;

        }

        public Customer Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public virtual double CalculateInterestRate(double months)
        {
            return InterestRate * months;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", this.Customer.GetType().Name, this.Customer.FirstName, this.Balance, this.InterestRate);
        }
    }
}
