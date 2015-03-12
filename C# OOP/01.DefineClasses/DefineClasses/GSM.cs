namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Calls> callHistory = new List<Calls>();

        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
            : this(model, manufacturer, price, owner)
        {
            this.Battery = battery;
            this.Display = display;
        }

        //fake specs !
        private static readonly GSM iPhone4S = new GSM(
            "IPhone4",
            "Appe",
            400M,
            "Soraka",
            new Battery(Battery.BatteryTypes.LiLon, 10, 10),
            new Display("1280/720", 160000)
            );
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        }


        //Set model and manufacturer and default values to other
        public GSM(string model, string manufacturer) : this(model, manufacturer, 0m, null) { }

        public GSM(string model, string manufacturer, Battery battery, Display display)
            : this(manufacturer, model)
        {
            this.Battery = battery;
            this.Display = display;
        }
        public string Model
        {
            get
            { return this.model; }
            private set
            {
                if (value.Length < 3 || value == String.Empty) { throw new Exception("Model must have more than 3 symbols !"); }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set
            {
                if (value.Length < 3 || value == String.Empty) { throw new Exception("Manufacturer must have more than 3 symbols !"); }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            private set
            {
                if (value < 0) { throw new Exception("Price must be a positive number !"); }
                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            private set
            {
                if (value.Length < 3 || value == String.Empty) { throw new Exception("Owner must have more than 3 symbols !"); }
                this.owner = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            private set
            {
                this.battery = value;
            }
        }
        public Display Display
        {
            get
            {
                return this.display;
            }
            private set
            {
                this.display = value;
            }
        }

        public List<Calls> GetCallHistory
        {
            get { return new List<Calls>(this.callHistory); }

        }
        public void AddCalls(Calls cal)
        {
            this.callHistory.Add(cal);
        }

        public void RemoveCalls(Calls cal)
        {
            this.callHistory.Remove(cal);
        }

        public void ClearCalls(Calls cal)
        {
            this.callHistory.Clear();
        }
        public decimal CallPrice(decimal pricePerMinute)
        {
            //Totally not copy/paste from dentia!
            decimal result = (decimal)(this.callHistory.Select(x => x.Duration).Sum());
            return pricePerMinute * (result / 60.0m);
        }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.Append(string.Format("Model: {0}, Price: {1}, Manufacturer: {2}, Owner: {3}.", this.Model, this.Price, this.Manufacturer, this.Owner));

            return result.ToString();
        }



    }
}
