namespace GSM
{
    using System;
    using System.Text;
    using System.Linq;

    public class CallHistoryTest
    {
        GSM phone = new GSM("GalaxyS", "Samsung", 400M, "Teemo");

        public void testCalls()
        {
            Console.WriteLine(phone.ToString());
            Console.WriteLine(new String('-', 40));
            phone.AddCalls(new Calls(new DateTime(2015, 03, 12), 20, "359894288010"));
            phone.AddCalls(new Calls(new DateTime(2015, 03, 12), 35, "359894288010"));
            phone.AddCalls(new Calls(new DateTime(2015, 03, 12), 60, "359894288010"));
            Console.WriteLine(new String('-',40));
            //Print the calls:

            foreach (var item in phone.GetCallHistory)
            {
                Console.WriteLine(item.Datetime + " " + item.DailedPhoneNumber + " " + item.Duration);
            }

            Console.WriteLine(new String('-', 40));
            //Calculate the call price
            Console.WriteLine("{0:N3}", phone.CallPrice(0.37M));

            Calls longestCall = phone.GetCallHistory.OrderByDescending(x => x.Duration).FirstOrDefault();
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Removing the longest call : " + longestCall.Duration);

            //Remove longest call

            phone.RemoveCalls(longestCall);
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Price after removing the longest call : ");
            Console.WriteLine("{0:N3}", phone.CallPrice(0.37M));
            Console.WriteLine(new String('-', 40));
            Console.WriteLine("Thanks for viewing my homework ! ");
            Console.WriteLine(new String('-', 40));
        }

    }
}
