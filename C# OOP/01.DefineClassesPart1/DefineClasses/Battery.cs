namespace GSM
{
    using System;


    class Battery
    {

        private int hoursIdle;
        private int hoursTalk;
        private BatteryTypes batteryType;

        public Battery(BatteryTypes batteryType)
        {
            this.batteryType = batteryType;
        }

        public Battery(BatteryTypes batteryType, int hoursIdle, int hoursTalk)
            : this(batteryType)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }


        /*stack overflow exception
        public BatteryTypes BatteryType
        {
            get { return this.batteryType; }
            private set { this.BatteryType = value; }
        }
        */
        public int HoursIdle
        {
            get { return hoursIdle; }
            private set { if (value < 0) { throw new ArgumentException("Invalid idle hours !"); } this.hoursIdle = value; }
        }
        public int HoursTalk
        {
            get { return this.hoursTalk; }
            private set { if (value < 0) { throw new ArgumentException("Invalid idle hours !"); } this.hoursTalk = value; }
        }

        public enum BatteryTypes
        {
            LiLon, NiMH, NiCd
        }
    }
}
