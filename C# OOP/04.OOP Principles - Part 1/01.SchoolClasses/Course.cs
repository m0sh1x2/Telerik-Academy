namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Course : ICommentable
    {
        private List<Teacher> setOfTeachers = new List<Teacher>();


        public Course(string classId)
        {
            this.ClassID = classId;
        }

        private string comment;
        public string ClassID { get; private set; }
        public string Comment
        {
            get { return this.comment; }
            private set
            {
                this.comment = value;
            }
        }
    }
}
