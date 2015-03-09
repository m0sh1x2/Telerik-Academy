namespace GSM
{
    using System;


    public enum BatteryTypes
    {
        LiLon, NiMH, NiCd
    }

    class Battery
    {
        private string model;
        private int hoursIdle;
        private int hoursTalk;
        private string batteryType;

        public Battery(string model, int hoursIdle, int hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;

        }

        public string Model
        {
            get { return this.model; }
            set { if (value.Length < 3 || String.IsNullOrWhiteSpace(value)) { throw new ArgumentException("Invalid model value !"); } }
        }
        public int HoursIdle
        {
            get { return hoursIdle; }
            set { if (value < 0) { throw new ArgumentException("Invalid idle hours !"); } this.hoursIdle = value; }
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            set { if (value < 0) { throw new ArgumentException("Invalid idle hours !"); } this.hoursTalk = value; }
        }
    }
}
