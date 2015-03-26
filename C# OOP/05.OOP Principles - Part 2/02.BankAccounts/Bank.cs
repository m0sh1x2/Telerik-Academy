namespace _02.BankAccounts
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            this.accounts = new List<Account>();
        }

        public Account this[int index]
        {
            get
            {
                return this.accounts[index];
            }
        }

        public void AddAccount(Account customer)
        {
            this.accounts.Add(customer);
        }

        public void RemoveAccount(Account customer)
        {
            this.accounts.Remove(customer);
        }

        public override string ToString()
        {
            this.accounts = this.accounts.OrderBy(x => x.Balance).ToList();

            var result = new StringBuilder();

            foreach (var item in this.accounts)
            {
                result.AppendLine(item.ToString());
            }

            return result.ToString();
        }
    }
}
