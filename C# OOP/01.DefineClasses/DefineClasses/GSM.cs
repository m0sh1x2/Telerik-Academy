namespace GSM
{
    using System;

    class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;


        public GSM(string model, string manufacturer, decimal price, string owner)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
        }

        //Set model and manufacturer and default values to other
        public GSM(string model, string manufacturer) : this(model, manufacturer, 0m, null) { }




        public string Model
        {
            get
            { return this.model; }
            set
            {
                if (value.Length < 3 || value == String.Empty) { throw new Exception("Model must have more than 3 symbols !"); }
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value.Length < 3 || value == String.Empty) { throw new Exception("Manufacturer must have more than 3 symbols !"); }
                this.manufacturer = value;
            }
        }
        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0) { throw new Exception("Price must be a positive number !"); }
                this.price = value;
            }
        }
        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value.Length < 3 || value == String.Empty) { throw new Exception("Owner must have more than 3 symbols !"); }
                this.owner = value;
            }
        }


    }
}
