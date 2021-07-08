using System;

namespace VegeMarketProject
{
    public abstract class Item
    {
        protected long _id;
        protected DateTime _added;
        protected DateTime? _expirationDate;
        protected Double _quality;
        protected Double _weight;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public DateTime Added
        {
            get { return _added; }
        }
        public DateTime? ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }
        public Double Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }
        public Double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Double GetValuability()
        {
            Double valuability = Quality * Weight;
            return valuability;
        }
        public TimeSpan? GetTimeTillExpiration()
        {
            TimeSpan? timeTillExpiration = ExpirationDate != null ? DateTime.Now - ExpirationDate : null;
            return timeTillExpiration;
        }
        public TimeSpan? GetLongevity()
        {
            TimeSpan? longevity = ExpirationDate != null ? ExpirationDate - Added : null;
            return longevity;
        }
    }
}
