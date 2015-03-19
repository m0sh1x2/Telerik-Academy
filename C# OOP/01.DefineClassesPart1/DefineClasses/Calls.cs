namespace GSM
{
    using System;
    using System.Data;

    public class Calls
    {
        public DateTime Datetime { get; set; }
        public double Duration { get; set; }
        public string DailedPhoneNumber { get; set; }

        public Calls(DateTime datetime, double duration, string phoneNumber)
        {
            this.Datetime = datetime;
            this.Duration = duration;
            this.DailedPhoneNumber = phoneNumber;
        }



    }
}
