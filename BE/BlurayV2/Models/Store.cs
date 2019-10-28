using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class Store<T>
    {
        public List<T> Listing { get; set; }

        public Store()
        {
            Listing = new List<T>();
        }

        public Store(List<T> moviesToStore)
        {
            this.Listing = moviesToStore;
        }

        public T AddToStore(T movieToAdd)
        {
            Listing.Add(movieToAdd);

            return movieToAdd;
        }

        public static bool operator ==(Store<T> catalogA, Store<T> catalogB)
        {
            if (object.ReferenceEquals(catalogA, catalogB))
            {
                return true;
            }

            if (object.ReferenceEquals(null, catalogA))
            {
                return false;
            }

            return catalogA.Equals(catalogB);
        }

        public static bool operator !=(Store<T> catalogA, Store<T> catalogB)
        {
            return !(catalogA == catalogB);
        }

        public override bool Equals(object value)
        {
            Store<T> toCompare = value as Store<T>;

            var firstNotSecond = this.Listing.Except(toCompare.Listing).ToList();
            var secondNotFirst = toCompare.Listing.Except(this.Listing).ToList();

            return !object.ReferenceEquals(null, toCompare)
                && !firstNotSecond.Any() && !secondNotFirst.Any();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                const int HashingBase = (int)2166136261;
                const int HashingMultiplier = 16777619;
                int hash = HashingBase;

                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.Listing) ? this.Listing.GetHashCode() : 0);

                return hash;
            }
        }
    }
}
