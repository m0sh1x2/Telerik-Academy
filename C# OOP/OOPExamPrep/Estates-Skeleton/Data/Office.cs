using Estates.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estates.Data
{
    class Office : EstateBuilding, IOffice
    {
        public Office()
        {
            this.Type = EstateType.Office;
        }
    }
}
