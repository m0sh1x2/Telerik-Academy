using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units.Products
{
    public class Milk : Food, IProduct
    {
        private const int defaultQuantity = 6;
        private const int defaultHealthEffect = 4;

        public Milk(string id, ProductType productType, FoodType foodType, int quantity, int healthEffect)
            : base(id, productType, foodType, defaultQuantity, defaultHealthEffect)
        {
            this.ProductType = ProductType.Milk;
            this.FoodType = FoodType.Organic;
            
        }
    }
}
