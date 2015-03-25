using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    class AnimalMain
    {
        static void Main(string[] args)
        {

            var animals = new List<Animal>();
            animals.Add(new Kitten("Soraka", 1, "Female"));
            animals.Add(new Tomcat("Teemo", 1, "Male"));
            animals.Add(new Dog("Floky", 5, "Male"));
            animals.Add(new Dog("Inu", 9, "Female"));
            animals.Add(new Frog("Thor", 7, "Female"));
            animals.Add(new Frog("Helga", 6, "Female"));

            foreach (var item in animals)
            {
                item.MakeSound();
            }

            //var averageAge = animals.Average(x => x.Age);
            var averageAge = Animal.AverageAge(animals);
            Console.WriteLine("Average age: ");
            Console.WriteLine(averageAge);
            //animals.Add(new Cat("Hiru",5,"Male")); //Can't add abstract classes :)

        }
    }
}
