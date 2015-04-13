using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units.Products
{
    public class Tobacco : Product, IProduct
    {
        private const int defaultQuantity = 10;

        public Tobacco(string id, ProductType productType, int quantity)
            : base(id, productType, defaultQuantity)
        {
            this.ProductType = ProductType.Tobacco;
        }


    }
}
