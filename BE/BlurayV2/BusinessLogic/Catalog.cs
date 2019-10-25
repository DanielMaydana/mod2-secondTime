using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class Catalog
    {

        public CatalogStore CatalogStore { get; private set; }
        private uint CatalogCode;

        public Catalog(CatalogStore store)
        {
            this.CatalogStore = store;
            this.CatalogCode = 1000;
        }

        public Catalog()
        {
            this.CatalogStore = new CatalogStore();
            this.CatalogCode = 1000;
        }

        public CatalogMovie AddSingleMovie(object toAdd)
        {
            var movie = toAdd as Movie;

            if (!ContainsMovieDuplicates(movie))
            {
                CatalogCode++;
                CatalogMovie cataloguedMovie = new CatalogMovie(movie.Name, movie.Year, movie.Director, CatalogCode);
                return CatalogStore.AddToStore(cataloguedMovie);
            }

            throw new ArgumentException($"The movie '{movie.Name}' ({movie.Year}) was previously added to the catalog.");
        }

        private bool ContainsMovieDuplicates(Movie movie)
        {
            foreach (var catalogMovie in this.CatalogStore.Store)
            {
                if (catalogMovie == movie) return true;
            }

            return false;
        }

        private bool ContainsCatlogMovieDuplicates(CatalogStore catalog)
        {
            bool hasDuplicates = catalog.Store.GroupBy(
                    obj => new { obj.Name, obj.Year, obj.Director, obj.Code }).
                    Where(obj => obj.Skip(1).Any()
                ).Any();

            return hasDuplicates;
        }

        public void SetStore(object store)
        {
            CatalogStore storeToSet = store as CatalogStore;

            if (ContainsCatlogMovieDuplicates(storeToSet))
            {
                throw new ArgumentException($"The store intended to be assigned, contains duplicates.");
            }

            var storeCount = storeToSet.Store.Count - 1;
            this.CatalogCode = storeToSet.Store[storeCount].Code;

            this.CatalogStore = storeToSet;
        }

        public CatalogStore GetStore()
        {
            return CatalogStore;
        }

        public uint GetMovieCount()
        {
            return CatalogCode;
        }
    }
}
