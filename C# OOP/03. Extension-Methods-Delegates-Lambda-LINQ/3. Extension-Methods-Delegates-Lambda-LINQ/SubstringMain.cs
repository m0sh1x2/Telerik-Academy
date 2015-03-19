namespace _3.Extension_Methods_Delegates_Lambda_LINQ
{
    using System;
    using System.Text;

    class SubstringMain
    {
        static void Main(string[] args)
        {
            StringBuilder test = new StringBuilder("Hello lets test this !");
            var result = StringBuilderSubstring.Substring(test,1,5);
            Console.WriteLine(result.ToString());

        }
    }
}
