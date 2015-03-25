
namespace _01.SchoolClasses
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    //Disciplines have name, number of lectures and number of exercises.
    public class Discipline
    {
        public Discipline(string name, int lectures, int exercises)
        {
            this.Name = name;
            this.NumberOfLectures = lectures;
            this.NumberOfExercies = exercises;
        }
        public string Name { get; set; }
        public int NumberOfLectures { get; set; }
        public int NumberOfExercies { get; set; }

    }
}
