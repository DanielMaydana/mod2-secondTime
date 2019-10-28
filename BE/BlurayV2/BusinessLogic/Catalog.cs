using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Catalog
    {
        public Store<CatalogMovie> CatalogStore { get; set; }
        private uint CatalogCount;

        public Catalog(Store<CatalogMovie> store)
        {
            this.CatalogStore = SetStore(store);
            this.CatalogCount = 1000;
        }

        public Catalog()
        {
            this.CatalogStore = new Store<CatalogMovie>();
            this.CatalogCount = 1000;
        }

        public CatalogMovie AddSingleMovie(object toAdd)
        {
            var movie = toAdd as Movie;

            if (!ContainsMovieDuplicates(movie))
            {
                this.CatalogCount++;
                CatalogMovie cataloguedMovie = new CatalogMovie(movie.Name, movie.Year, movie.Director, this.CatalogCount);
                return this.CatalogStore.AddToStore(cataloguedMovie);
            }

            throw new ArgumentException($"The movie '{movie.Name}' ({movie.Year}) was previously added to the catalog.");
        }

        private bool ContainsMovieDuplicates(Movie movie)
        {
            foreach (var catalogMovie in this.CatalogStore.Listing)
            {
                if (catalogMovie.Name == movie.Name
                    && catalogMovie.Year == movie.Year
                    && catalogMovie.Director == movie.Director)

                    return true;
            }

            return false;
        }

        private bool CheckDuplicatesInCatalog(Store<CatalogMovie> catalog)
        {
            bool hasDuplicates = catalog.Listing.GroupBy(
                    obj => new { obj.Name, obj.Year, obj.Director, obj.CatalogCode }).
                    Where(obj => obj.Skip(1).Any()
                ).Any();

            return hasDuplicates;
        }

        public Store<CatalogMovie> SetStore(object store)
        {
            Store<CatalogMovie> storeSetted = store as Store<CatalogMovie>;

            if (CheckDuplicatesInCatalog(storeSetted))
            {
                throw new ArgumentException($"The store intended to be assigned, contains duplicates.");
            }

            this.CatalogCount = GetCatalogCode(storeSetted);

            this.CatalogStore = storeSetted;

            return this.CatalogStore;
        }

        private uint GetCatalogCode(Store<CatalogMovie> storeSetted)
        {
            var storeCount = storeSetted.Listing.Count - 1;

            return storeSetted.Listing[storeCount].CatalogCode;
        }

        public Store<CatalogMovie> GetStore()
        {
            return this.CatalogStore;
        }

        public uint GetMovieCount()
        {
            return this.CatalogCount;
        }
    }
}
