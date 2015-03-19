
namespace _17.LongestString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class LongestString
    {
        static void Main(string[] args)
        {
            string[] theStrings = new string[] { "12", "123456", "131541513135", "15415415", "largeststringbro" };
            var result =
                from strings in theStrings
                orderby strings.Length descending
                select strings;
            Console.WriteLine(result.FirstOrDefault());
        }
    }
}
