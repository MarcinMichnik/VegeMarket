using System;

namespace VegeMarketProject
{
    public abstract class Item
    {
        protected Item(DateTime expirationDate, float quality, float weight)
        {
            Added = DateTime.Now;
            ExpirationDate = expirationDate;
            Quality = quality;
            Weight = weight;
        }

        protected static DateTime Added { get; set; }
        protected static DateTime ExpirationDate { get; set; }
        protected static float Quality { get; set; }
        protected static float Weight { get; set; }

        public static float GetValuability() 
        {
            float valuability = Quality * Weight;
            return valuability;
        }

        public static TimeSpan GetTimeTillExpiration()
        {
            TimeSpan timeTillExpiration = DateTime.Now - ExpirationDate;
            return timeTillExpiration;
        }

        public static TimeSpan GetLongevity()
        {
            TimeSpan longevity = ExpirationDate - Added;
            return longevity;
        }
    }
}
