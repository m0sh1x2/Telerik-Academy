using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Interfaces;

namespace Estates.Data
{
    class Apartment : EstateBuilding, IApartment
    {


        public Apartment()
        {
            this.Type = EstateType.Apartment;
        }

    }
}
