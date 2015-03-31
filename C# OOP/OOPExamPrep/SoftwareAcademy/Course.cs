using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;
        private ICollection<string> topics;

        protected Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.topics = new List<string>();
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
                    throw new ArgumentNullException("value", "Course name could not be null!");
                }
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Course canno't be null or white space !");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher { get; set; }


        public void AddTopic(string topic)
        {
            this.topics.Add(topic);
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("{0}: Name={1}", this.GetType().Name, this.name);

            if (this.Teacher != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }

            if (this.topics.Count > 0)
            {
                output.AppendFormat("; Topics={0}", string.Join(", ", this.topics));
            }

            return output.ToString();
        }
    }
}
