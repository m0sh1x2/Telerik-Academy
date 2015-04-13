namespace FarmersCreed.Units
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class TobaccoPlant : Plant
    {
        private const int defaultHealth = 12;
        private const int defaultGrowTime = 4;

        public TobaccoPlant(string id, int health, int productionQuantity, int growTime)
            : base(id, defaultHealth, productionQuantity, defaultGrowTime)
        {
            this.DefaultGrowTime = 2;
        }

    }
}
