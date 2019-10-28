using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Catalog
    {

        public Store<CatalogMovie> CatalogStore { get; private set; }
        private uint CatalogCode;

        public Catalog(Store<CatalogMovie> store)
        {
            this.CatalogStore = store;
            this.CatalogCode = 1000;
        }

        public Catalog()
        {
            this.CatalogStore = new Store<CatalogMovie>();
            this.CatalogCode = 1000;
        }

        public CatalogMovie AddSingleMovie(object toAdd)
        {
            var movie = toAdd as Movie;

            if (!ContainsMovieDuplicates(movie))
            {
                CatalogCode++;
                CatalogMovie cataloguedMovie = new CatalogMovie(movie.Name, movie.Year, movie.Director, CatalogCode);
                return this.CatalogStore.AddToStore(cataloguedMovie);
            }

            throw new ArgumentException($"The movie '{movie.Name}' ({movie.Year}) was previously added to the catalog.");
        }

        private bool ContainsMovieDuplicates(Movie movie)
        {
            foreach (var catalogMovie in this.CatalogStore.Listing)
            {
                if (catalogMovie == movie) return true;
            }

            return false;
        }

        private bool ContainsCatlogMovieDuplicates(Store<CatalogMovie> catalog)
        {
            bool hasDuplicates = catalog.Listing.GroupBy(
                    obj => new { obj.Name, obj.Year, obj.Director, obj.Code }).
                    Where(obj => obj.Skip(1).Any()
                ).Any();

            return hasDuplicates;
        }

        public void SetStore(object store)
        {
            Store<CatalogMovie> storeToSet = store as Store<CatalogMovie>;

            if (ContainsCatlogMovieDuplicates(storeToSet))
            {
                throw new ArgumentException($"The store intended to be assigned, contains duplicates.");
            }

            var storeCount = storeToSet.Listing.Count - 1;
            this.CatalogCode = storeToSet.Listing[storeCount].Code;

            this.CatalogStore = storeToSet;
        }

        public Store<CatalogMovie> GetStore()
        {
            return this.CatalogStore;
        }

        public uint GetMovieCount()
        {
            return CatalogCode;
        }
    }
}
