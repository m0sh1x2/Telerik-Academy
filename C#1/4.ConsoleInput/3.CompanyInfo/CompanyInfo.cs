using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CompanyInfo
{
    class CompanyInfo
    {
        static void Main(string[] args)
        {
            // has name, address, phone number, fax number, web site and manager
            Console.WriteLine("--------------------");
            Console.WriteLine("Employee information");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.Write("Enter your name : ");
            string name = Console.ReadLine();

            Console.Write("Enter your adress : ");
            string adress = Console.ReadLine();

            Console.Write("Enter your phone number : ");
            string phoneNumber = Console.ReadLine();
            int phoneNumberInt;
           
            if (int.TryParse(phoneNumber, out phoneNumberInt))
            {
                Console.WriteLine("Valid phone number : {0} ", phoneNumberInt);
            }
            else
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("!!! Not valid phone number : {0} !!!", phoneNumber);
                Console.WriteLine("------------------------------------");
                phoneNumber = "Error";
            }

            Console.Write("Enter your fax number : ");
            string faxNumber = Console.ReadLine();
            int faxNumberInt;
            if (int.TryParse(faxNumber, out faxNumberInt))
            {
                Console.WriteLine("Valid fax number : {0} ", faxNumberInt);
            }
            else
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("!!! Not valid fax number : {0} !!!", faxNumber);
                Console.WriteLine("----------------------------------");
                faxNumber = "Error";
            }

            Console.Write("Enter your web site : ");
            string webSite = Console.ReadLine();
            Console.WriteLine("-------------");
            Console.WriteLine("Name : {0} \nAdress : {1} \nPhone number : {2} \nFax Number : {3} \nWebSite : {4}",name ,adress, phoneNumberInt, faxNumberInt, webSite);
            Console.WriteLine("-------------");
        }
    }
}
