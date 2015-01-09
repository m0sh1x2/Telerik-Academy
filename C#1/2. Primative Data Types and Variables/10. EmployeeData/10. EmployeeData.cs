using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.MarketingFirm
{
    class MarketingFirm
    {
        static void Main(string[] args)
        {
            string firstName;
            string familyName;
            byte age;
            string gender;
            short id;
            int uniqueEmployeNumber;

            firstName = "Albert";
            familyName = "Stain";
            age = 18;
            gender = "Male";
            id = 1;
            uniqueEmployeNumber = 27569999;

            Console.WriteLine("First name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nId: {4}\nUEN: {5}",firstName,familyName,age,gender,id,uniqueEmployeNumber);
        }
    }
}
