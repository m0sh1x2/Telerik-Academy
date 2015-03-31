using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {
        private string lab;

        public LocalCourse(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "LocalCourse Lab cannot be null !");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("LocalCourse Lab cannot be null or white space !");
                }

                this.lab = value;
            }
        }
        public override string ToString()
        {
            var output = new StringBuilder(base.ToString());
            output.AppendFormat("; Lab={0}", this.lab);

            return output.ToString();
        }
    }
}
