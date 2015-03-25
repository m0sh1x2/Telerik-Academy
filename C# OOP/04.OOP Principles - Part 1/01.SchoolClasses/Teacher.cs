using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SchoolClasses
{
    public class Teacher : Person, ICommentable
    {
        private List<Discipline> setOfDisciplines = new List<Discipline>();
        public Teacher(string name)
        {
            base.Name = name;
        }
        public List<Discipline> SetOfDisciplines
        {
            get
            {
                return new List<Discipline>(this.setOfDisciplines);
            }
        }
        public void AddDiscipline(Discipline item)
        {
            this.setOfDisciplines.Add(item);
        }

        private string comment;
        public string Comment
        {
            get { return this.comment; }
            private set { this.comment = value; }
        }
    }
}
