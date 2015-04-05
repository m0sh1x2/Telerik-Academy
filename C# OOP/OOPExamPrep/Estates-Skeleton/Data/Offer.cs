using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    public abstract class Offer : IOffer
    {
        private OfferType type;
        private IEstate estate;
        protected decimal price;

        public OfferType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public IEstate Estate
        {
            get
            {
                return this.estate;
            }
            set
            {
                this.estate = value;
            }
        }

        public decimal GetPrice()
        {
            return this.price;
        }
        public override string ToString()
        {
            return String.Format("{0}: Estate = {1}, Location = {2}, Price = {3}", this.Type, this.estate.Name, this.Estate.Location, this.price);
        }
    }
}
