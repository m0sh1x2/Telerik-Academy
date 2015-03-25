using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    class MainProject
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            var workers = new List<Worker>();

            var grade = new Random();

            //generate 10 students the lazy way
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student(i + "Soraka", "Teemova", grade.Next(2, 7)));
                workers.Add(new Worker(i + "Lux", "Wrather", 2000 / (i + 1), 12 - i));
            }


            //Order students by grades
            var ascendingGrades = students.OrderBy(x => x.Grade);

            /*
            foreach (var item in ascendingGrades)
            {
                Console.WriteLine(item.Grade);
            }
             * */

            var descSalary = workers.OrderBy(x => x.MoneyPerHour());
            /*
            foreach (var item in descSalary)
            {
                Console.WriteLine(item.MoneyPerHour());
            }
            */

            //Merge the lists with dynamic :D
            var result = new List<dynamic>();
            var merged = result.Concat(students).Concat(workers).ToList();


            foreach (var item in merged)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
}
