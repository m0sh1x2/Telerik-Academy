namespace GSM
{
    using System;
    using System.Text;

    class GSMMain
    {
        static void Main(string[] args)
        {

            //Just simple tests ! The main tests are in CallHistoryTest.cs !!!

            /*
            GSM[] phones = new GSM[4];
            for (int i = 0; i < phones.Length; i++)
            {
                phones[i] = new GSM("GalaxyS" + i, "Samsung", 400M + i, "Teemo");
                Console.WriteLine(phones[i].ToString());
            }
            Console.WriteLine(GSM.IPhone4S);
            */
            //tests

            CallHistoryTest theTests = new CallHistoryTest();
            theTests.testCalls();
        }
    }
}
