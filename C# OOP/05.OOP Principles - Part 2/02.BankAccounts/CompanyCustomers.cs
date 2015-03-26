namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CompanyCustomers : Customer
    {
        public CompanyCustomers(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }
    }
}
