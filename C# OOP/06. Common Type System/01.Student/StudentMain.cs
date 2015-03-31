namespace _01.Student
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class StudentMain
    {
        public static void Main(string[] args)
        {
            var student = new Student("Ivaylo", "C#", "Kenov", "123456", "Telerik Academy", "01234567", "ivaylo@telerik.com", "4", Student._Specialities.ComputerScience, Student._Universities.SU, Student._Faculties.Mathematics);
            var student2 = new Student("Test", "testov", "testovich", "15151", "Horo Academy", "5315135", "horo@horo.com", "5", Student._Specialities.Physics, Student._Universities.TU, Student._Faculties.Mathematics);

            Console.WriteLine(student.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine("HashCode : " + student.GetHashCode());
            Console.WriteLine("Compare the students : " + student.CompareTo(student2));
            Console.WriteLine(student2 == student);
            Console.WriteLine(student != student2);
        }
    }
}
