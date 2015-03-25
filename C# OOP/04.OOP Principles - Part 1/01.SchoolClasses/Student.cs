
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Person, ICommentable
    {
        public string ClassNumber { get; private set; }
        //public string Comment { get; set; }
        public Student(string name)
        {
            base.Name = name;
        }

        private string comment;
        public string Comment
        {
            get
            {
                return this.comment;
            }
            private set
            {
                this.comment = value;
            }
        }
    }
}
