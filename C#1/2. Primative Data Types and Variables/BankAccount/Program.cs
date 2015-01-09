//(first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
using System;

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Someone";
            string middleName = "Someonov";
            string lastName = "Somononov";
            decimal moneyAmount = 1337;
            string bankName = "Telerik Bank";
            string IBAN = "1234567890";
            string BIC = "1234567890";
            string card1 = "221234567890";
            string card2 = "331234567890";
            string card3 = "441234567890";

            Console.WriteLine("{0} {1} {2}",firstName,middleName,lastName);
            Console.WriteLine("Money amound: {0} Bank: {1}",moneyAmount,bankName);
            Console.WriteLine("IBAN: {0} BIC: {1}", IBAN, BIC);
            Console.WriteLine("Card1: {0}\n Card2: {1}\n Card3: {2}", card1, card2, card3);
        }
    }

