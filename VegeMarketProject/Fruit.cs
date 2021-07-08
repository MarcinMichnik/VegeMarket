using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VegeMarketProject
{
    public class Fruit : Item
    {
        public Fruit(DateTime expirationDate, float quality, float weight) : base(expirationDate, quality, weight)
        {
            Added = DateTime.Now;
            ExpirationDate = expirationDate;
            Quality = quality;
            Weight = weight;
        }
    }
}
