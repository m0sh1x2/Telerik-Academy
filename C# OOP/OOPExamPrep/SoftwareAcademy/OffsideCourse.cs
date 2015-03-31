using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value", "OffsiteCourse town cannot be null !");
                }

                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("OffsiteCourse town cannot be null or white space !");
                }

                this.town = value;
            }
        }
        public override string ToString()
        {
            var output = new StringBuilder(base.ToString());
            output.AppendFormat("; Town={0}", this.town);

            return output.ToString();
        }
    }
}
