namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TestAccounts
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            bank.AddAccount(new DepositAccount(new InvidualCustomer("Sora", "Sorov"), 999, 5));
            bank.AddAccount(new LoanAccount(new CompanyCustomers("Teemo", "Teemov"), 1337, 5));
            bank.AddAccount(new MortgageAccount(new InvidualCustomer("Kartof", "Kompirov"), 7331, 5));


            Console.WriteLine(bank.ToString());
        }
    }
}
