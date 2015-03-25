using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalHierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string sex)
            : base(name, age, sex = "Male")
        {
            if (sex != "Male")
            {
                throw new Exception("Kittens can be only Male !");
            }
            base.Sex = "Male";
        }
    }
}
