namespace _03.FirstBeforeLast
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[]{
                new Student("Avan", "Zvanov",20),
                new Student("Ivaylo", "Kenov",15),
                new Student("Aoncho", "CJavaScript",21),
                new Student("Zeorgi", "Aristov",22)
            };
            var result = FirstNameBeforeLast(students); //First before last
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Arrange by Names :");
            Console.WriteLine(new string('-', 40));
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
            result = AgeRange(students, 18, 24);
            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Arrange by Ages 18-24 :");
            Console.WriteLine(new string('-', 40));
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Order by names LINQ :");
            Console.WriteLine(new string('-', 40));

            //LINQ order
            var otherResult = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            foreach (var item in otherResult)
            {
                Console.WriteLine(item.ToString());
            }

            //Lambda order
            var lambdaResult =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;


            Console.WriteLine(new string('-', 40));
            Console.WriteLine("Order by names LAMBDA:");
            Console.WriteLine(new string('-', 40));
            foreach (var item in lambdaResult)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine(new string('-', 40));

        }


        private static IEnumerable<Student> FirstNameBeforeLast(Student[] students)
        {
            IEnumerable<Student> result =
                from student in students
                where student.FirstName.CompareTo(student.LastName) < 0
                select student;
            return result;
        }
        private static IEnumerable<Student> AgeRange(Student[] students, int startAge, int endAge)
        {
            IEnumerable<Student> result =
                from student in students
                where student.Age >= startAge && student.Age <= endAge
                select student;
            return result;
        }
    }
}
