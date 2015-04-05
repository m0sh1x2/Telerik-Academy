using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    class RentOffer : Offer, IRentOffer
    {
        public RentOffer()
        {

            this.Type = OfferType.Rent;
        }

        public decimal PricePerMonth
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
    }
}
