using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, string sex) : base(name, age, sex) { }

        public override void MakeSound()
        {
            Console.WriteLine("Woof Woof C# !");
        }
    }
}
