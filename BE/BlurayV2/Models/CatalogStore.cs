using System;
using System.Collections.Generic;
using System.Linq;

namespace Models
{
    public class CatalogStore
    {
        public List<CatalogMovie> Store { get; set; }

        public CatalogStore()
        {
            this.Store = new List<CatalogMovie>();
        }

        public CatalogStore(List<CatalogMovie> moviesToStore)
        {
            this.Store = moviesToStore;
        }

        public CatalogMovie AddToStore(object toAdd)
        {
            var movieToAdd = toAdd as CatalogMovie;
            Store.Add(movieToAdd);

            return movieToAdd;
        }

        public static bool operator ==(CatalogStore catalogA, CatalogStore catalogB)
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

        public static bool operator !=(CatalogStore catalogA, CatalogStore catalogB)
        {
            return !(catalogA == catalogB);
        }

        public override bool Equals(object value)
        {
            CatalogStore toCompare = value as CatalogStore;

            var firstNotSecond = this.Store.Except(toCompare.Store).ToList();
            var secondNotFirst = toCompare.Store.Except(this.Store).ToList();

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

                hash = (hash * HashingMultiplier) ^ (!object.ReferenceEquals(null, this.Store) ? this.Store.GetHashCode() : 0);

                return hash;
            }
        }
    }
}
