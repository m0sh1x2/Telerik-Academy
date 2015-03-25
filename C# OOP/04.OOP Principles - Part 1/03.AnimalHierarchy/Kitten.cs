using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string sex)
            : base(name, age, sex = "Female")
        {
            if (sex != "Female")
            {
                throw new Exception("Kittens can be only female !");
            }
            base.Sex = "Female";
        }
    }
}
