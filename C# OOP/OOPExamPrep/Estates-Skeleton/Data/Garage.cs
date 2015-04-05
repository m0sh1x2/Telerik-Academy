using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class Garage : Estate, IGarage
    {
        private const int minWidthAndHeight = 0;
        private const int maxWidthAndHeight = 500;

        private int width;
        private int height;
        public Garage()
        {
            this.Type = EstateType.Garage;
        }

        public int Width
        {
            get { return this.width; }
            set
            {
                if (value < minWidthAndHeight || value > maxWidthAndHeight)
                {
                    throw new IndexOutOfRangeException("Garage width cannot be more than 500 and less than 0.");
                }
                this.width = value;
            }
        }


        public int Height
        {
            get { return this.height; }
            set
            {
                if (value < minWidthAndHeight || value > maxWidthAndHeight)
                {
                    throw new IndexOutOfRangeException("Garage height cannot be more than 500 and less than 0.");
                }
                this.height = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(", Width: {0}, Height: {1}", this.Width, this.Height);
        }
    }
}
