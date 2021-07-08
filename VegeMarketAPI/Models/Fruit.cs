using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeMarketProject
{
    public class Fruit : Item
    {
        public Fruit(DateTime? expirationDate, Double quality, Double weight)
        {
            _added = DateTime.Now;
            _expirationDate = expirationDate;
            // These fields cannot be less than 0
            _quality = quality < 0 ? 0 : quality;
            _weight = weight < 0 ? 0 : weight;
        }
    }
}
