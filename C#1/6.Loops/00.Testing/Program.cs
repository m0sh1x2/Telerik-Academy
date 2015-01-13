using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            EmployeeBasicData companyStaff = new EmployeeBasicData();
            Console.Write("Enter First Name here: ");
            companyStaff.firstName = Console.ReadLine();
            Console.Write("Enter Last Name here: ");
            companyStaff.lastName = Console.ReadLine();
            Console.Write("Enter Age here: ");
            companyStaff.age = byte.Parse(Console.ReadLine());
            Console.Write("Enter Gender here (m/f) ");
            companyStaff.gender = char.Parse(Console.ReadLine());
            Console.Write("Enter Personal Id here: ");
            companyStaff.personalID = long.Parse(Console.ReadLine());
            Console.Write("Enter Employee unique ID here: ");
            companyStaff.uniqueEmployeeID = long.Parse(Console.ReadLine());


            Console.WriteLine("First Name: {0} \nLast Name: {1} \nAge : {2} \nGender: {3} \nPersonal ID: {4} \nUnique Employee ID: {5}",
                companyStaff.firstName,
                companyStaff.lastName,
                companyStaff.age,
                companyStaff.gender,
                companyStaff.personalID,
                companyStaff.uniqueEmployeeID);
            Console.ReadLine();

        }
        class EmployeeBasicData
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public byte age { get; set; }
            public char gender { get; set; }
            public long personalID { get; set; }
            public long uniqueEmployeeID { get; set; }
        }
    }

}