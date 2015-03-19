
namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class StudentsMain
    {
        public static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Georgi", "Petrov", "133766", 089812345, "georgipetrov@abv.bg", new List<int>(new int[] { 2, 4, 5, 4 }), new Groups("2","Mathematics")));
            students.Add(new Student("Ivo", "Petrov", "133899", 029812345, "ivopetrov@gmail.com", new List<int>(new int[] { 5, 3 }), new Groups("1", "Sport")));
            students.Add(new Student("Ego", "Evdev", "133999", 089812345, "egoevdev@abv.bg", new List<int>(new int[] { 5, 5, 5, 2 }), new Groups("2", "Mathematics")));
            students.Add(new Student("Turnak", "Turnak", "134066", 089812345, "meteorite@abv.bg", new List<int>(new int[] { 5, 2 }), new Groups("1", "Sport")));
            students.Add(new Student("Ryu", "Ryujin", "134199", 029812345, "ryuv@gmail.com", new List<int>(new int[] { 6, 6, 6, 6 }), new Groups("2", "Art")));

            //Problem 9
            //Order by first name
            var orderByFirstName = students.OrderBy(s => s.FirstName);
            //foreach (var item in orderByFirstName) { Console.WriteLine(item.ToString()); }

            //Problem 10
            //Get group 2
            var studentsFromGroupTwo = students.Where(x => int.Parse(x.Group.GroupNumber) == 2);
            //foreach (var item in studentsFromGroupTwo) { Console.WriteLine(item.ToString()); }


            // Problem 11
            //extract abv.bg
            var extractABV = students.Where(x => x.Email.EndsWith("abv.bg"));
            //foreach (var item in extractABV) { Console.WriteLine(item.ToString()); };

            //Problem 12
            //Students from Sofia 02 

            var extractSofia = students.Where(x => x.PhoneNumber.ToString().StartsWith("2"));
            //foreach (var item in extractSofia) { Console.WriteLine(item.ToString()); };


            //Problem 13 
            //Atleast one 6

            var extract6 = students.Where(x => x.Marks.Contains(6));
            //foreach (var item in extract6) { Console.WriteLine(item.ToString()); };


            // Problem 14
            //Students with 2 marks

            var extractMarks = students.Where(x => x.Marks.Count == 2);
            //foreach (var item in extractMarks) { Console.WriteLine(item.ToString()); };

            //Problem 15
            //Students from 2006

            var extract2006 = students.Where(x => x.FacultyNumber.EndsWith("66"));
            //foreach (var item in extract2006) { Console.WriteLine(item.ToString()); };

            // Problem 16 extract Math groups
            var mathGroups = students.Where(x => x.Group.DepartmentName == "Mathematics");
            //foreach (var mathGroups in extract2006) { Console.WriteLine(item.ToString()); };


            //Problem 18 Group by Groupnumber

            var groupByGroupNumber = students.GroupBy(x => x.Group.GroupNumber);
            foreach (var item in groupByGroupNumber)
            {
                Console.WriteLine(item);
            }



        }
    }
}
