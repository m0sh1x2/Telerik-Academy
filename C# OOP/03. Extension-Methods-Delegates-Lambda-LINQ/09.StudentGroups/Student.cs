namespace _09.StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student
    {
        public string FirstName {get;set;}
        public string LastName { get; set; }
        public string FacultyNumber { get; set; } // there are Faculty Numbers with letters
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Groups Group { get; set; }

        public Student(string fn, string ln, string facNum, int pn, string em, List<int> marks, Groups group)
        {
            FirstName = fn;
            LastName = ln;
            FacultyNumber = facNum;
            PhoneNumber = pn;
            Email = em;
            Marks = marks;
            Group = group;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3} {4} {5}",FirstName,LastName,FacultyNumber,PhoneNumber,Email,GroupNumber);
        }
    }
}
