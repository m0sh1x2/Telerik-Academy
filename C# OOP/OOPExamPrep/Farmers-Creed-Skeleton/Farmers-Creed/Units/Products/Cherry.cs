using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Units.Products
{
    class Cherry : Product, IEdible
    {
        private const int defaultQuantity = 4;

        public Cherry(string id, ProductType productType, int quantity, FoodType foodType)
            : base(id, productType, defaultQuantity)
        {
            this.ProductType = ProductType.Cherry;
            this.FoodType = foodType;
            this.HealthEffect = 2;
        }

        public FoodType FoodType
        {
            get;
            set;
        }

        public int HealthEffect
        {
            get;
            set;
        }
    }
}
