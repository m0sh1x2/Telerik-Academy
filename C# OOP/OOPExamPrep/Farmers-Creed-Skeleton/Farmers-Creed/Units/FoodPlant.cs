using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmersCreed.Units
{
    public abstract class FoodPlant : Plant
    {
        public FoodPlant(string id, int health, int productuinQuantity, int growTime)
            : base(id, health, productuinQuantity, growTime)
        {
            this.DefaulWaterAmount = 1;
            this.DefaulWitherTime = 2;
        }
    }
}
