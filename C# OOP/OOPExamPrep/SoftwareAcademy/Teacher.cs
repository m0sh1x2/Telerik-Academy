namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Teacher : ITeacher
    {
        private string name;
        private ICollection<ICourse> courses;



        public Teacher(string name)
        {
            this.Name = name;
            this.courses = new List<ICourse>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "Teacher name must not be null !");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Teacher name must not be null or white space !");
                }

                this.name = value;
            }
        }



        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("Teacher: Name={0}", this.Name);

            if (this.courses.Count > 0)
            {
                output.AppendFormat("; Courses=[{0}]", string.Join(", ", this.courses.Select(x => x.Name)));
            }

            return output.ToString();
        }
    }
}
