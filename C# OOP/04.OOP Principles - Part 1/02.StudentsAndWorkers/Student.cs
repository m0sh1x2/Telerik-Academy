using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.StudentsAndWorkers
{
    public class Student : Human
    {

        private int grade;
        public Student(string firstName, string lastName, int conGrade)
        {
            this.FirstName = firstName;
            this.LasttName = lastName;
            this.Grade = conGrade;
        }

        public int Grade
        {
            get { return this.grade; }
            set { this.grade = value; }
        }
        public override string FirstName { get; set; }

        public override string LasttName { get; set; }

    }
}
