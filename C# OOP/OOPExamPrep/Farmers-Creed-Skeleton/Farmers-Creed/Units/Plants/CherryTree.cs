namespace FarmersCreed.Units.Plants
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CherryTree : FoodPlant
    {
        private const int defaultHealth = 14;

        public CherryTree(string id, int health, int productionQuantity, int growTime)
            : base(id, health, productionQuantity, growTime)
        {
            this.DefaultGrowTime = 3;
        }
    }
}
