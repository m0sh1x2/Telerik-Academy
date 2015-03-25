using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        public Animal() { }
        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;

        }

        public int Age { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }


        public virtual void MakeSound()
        {
            Console.WriteLine("I am animal ! ");
        }
        public static double AverageAge(List<Animal> list)
        {
            return list.Average(x => x.Age);
        }
    }
}
