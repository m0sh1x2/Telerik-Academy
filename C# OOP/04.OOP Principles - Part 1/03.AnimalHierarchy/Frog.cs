using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, string sex) : base() { }
        public override void MakeSound()
        {
            Console.WriteLine("Gruh !");
        }
    }
}
