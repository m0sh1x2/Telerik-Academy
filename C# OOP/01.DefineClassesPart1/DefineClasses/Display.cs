namespace GSM
{
    using System;

    class Display
    {
        private string size { get; set; }
        private int numberOfColors;

        public Display(string size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
        //Default values for empty call
        public Display() : this(null, 0) { }

    }
}
