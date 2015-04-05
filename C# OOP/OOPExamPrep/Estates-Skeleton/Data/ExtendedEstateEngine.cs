using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estates.Engine;
using Estates.Interfaces;

namespace Estates.Data
{
    class ExtendedEstateEngine : EstateEngine
    {
        public ExtendedEstateEngine()
            : base()
        {

        }

        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "create":
                case "status":
                case "find-sales-by-location":
                    return base.ExecuteCommand(cmdName, cmdArgs);
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPrice(decimal.Parse(cmdArgs[0]), decimal.Parse(cmdArgs[1]));
                default:
                    throw new NotImplementedException("Unknown command: " + cmdName);
            }
            //return base.ExecuteCommand(cmdName, cmdArgs);
        }

        private string ExecuteFindRentsByPrice(decimal min, decimal max)
        {

            var offers = this.Offers
                .Where(o => o.Type == OfferType.Rent)
                .Cast<IRentOffer>()
                .Where(o => o.PricePerMonth >= min && o.PricePerMonth <= max)
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name);

            return FormatQueryResults(offers);
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var offers = this.Offers
                .Where(o => o.Estate.Location == location && o.Type == OfferType.Rent)
                .OrderBy(o => o.Estate.Name);
            return FormatQueryResults(offers);
        }

    }
}
