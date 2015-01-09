using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// NOT FINISHED :(
class Program
{
    static void Main(string[] args)
    {
        // leap or non-leap
        string year = Console.ReadLine();
        //holidays - 0-300
        double p = int.Parse(Console.ReadLine());
        // weekends 0-52
        double h = int.Parse(Console.ReadLine());


        double result = 0.0;
        //int weekends = 52;
        //int satsun = weekends * 2;

        if (year == "t")
        {
            //tired weekends
            if (p == 0 && h == 0)
            {
                result += p;
                double tired = 52.0 / 3.0;
                result += ((52 - tired) - p) * 2 / 3.0;
                result += 3.0 + 0.5;

            }
                //normal weekends
            else {
                result += p;
                

                result += (52.0 - p) * 2 / 3.0;
                result += 3.0 + 0.5;
                
            }
            //hometown weekends
           
        }

        if (year == "f")
        {
            result += p;
            result += (52.0 - p) * 2.0 / 3.0;

        }

        Console.WriteLine(Math.Round(result));
        //Console.WriteLine(result);
    }
}

