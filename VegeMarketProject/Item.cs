using System;

namespace VegeMarketProject
{
    public abstract class Item
    {
        protected DateTime added;
        protected DateTime expirationDate;
        protected Double quality;
        protected Double weight;

        public DateTime Added { get; set; }
        public DateTime ExpirationDate { get; set; }
        public Double Quality { get; set; }
        public Double Weight { get; set; }

        public Item(DateTime expirationDate, Double quality, Double weight)
        {
            Added = DateTime.Now;
            ExpirationDate = expirationDate;
            Quality = quality;
            Weight = weight;
        }

        public Double GetValuability() 
        {
            Double valuability = Quality * Weight;
            return valuability;
        }

        public TimeSpan GetTimeTillExpiration()
        {
            TimeSpan timeTillExpiration = DateTime.Now - ExpirationDate;
            return timeTillExpiration;
        }

        public TimeSpan GetLongevity()
        {
            TimeSpan longevity = ExpirationDate - Added;
            return longevity;
        }
    }
}
