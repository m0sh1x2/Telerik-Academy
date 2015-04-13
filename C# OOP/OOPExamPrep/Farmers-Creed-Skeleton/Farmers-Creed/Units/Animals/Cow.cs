using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmersCreed.Interfaces;

namespace FarmersCreed.Units.Animals
{
    public class Cow : Animal
    {
        public const int BaseHealth = 15;

        public Cow(string id, int health, int productionQuantity)
            : base(id, health, productionQuantity)
        {

        }
        

    }
}
