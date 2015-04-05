using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public class House : Estate, IHouse
    {
        private const int minFloors = 0;
        private const int maxFloors = 10;

        private int numberOfFloors;
        public House()
        {
            this.Type = EstateType.House;
        }

        public int Floors
        {
            get { return this.numberOfFloors; }
            set
            {
                if (value < minFloors || value > maxFloors)
                {
                    throw new IndexOutOfRangeException(String.Format("House floors cannot be more than {0} or less than {1} !", maxFloors, minFloors));
                }
                this.numberOfFloors = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() + String.Format(", Floors: {0}", this.Floors);
        }
    }
}
