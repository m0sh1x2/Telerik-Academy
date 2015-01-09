using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isFemale
{
    class isFemale
    {
        static void Main(string[] args)
        {
            Boolean isFemale;
            String myGender = "Male";

            if (myGender == "Male")
            {
                isFemale = false;
            }
            else
            {
                isFemale = true;
            }
            Console.WriteLine(isFemale);
        }
    }
}
