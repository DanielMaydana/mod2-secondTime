using Models;
using System;

namespace BusinessLogic
{
    public class Inventory
    {
        private Store<InventoryMovie> InventoryStore { get; set; }
        private uint InventoryCount;
        private const uint DEFAULT_QTY = 0;

        public Inventory(Catalog catalog)
        {
            this.InventoryCount = 1000;
            InventoryStore = PopulateInventoryStore(catalog);
        }

        private Store<InventoryMovie> PopulateInventoryStore(Catalog catalog)
        {
            var momentaryStore = new Store<InventoryMovie>();

            foreach (var catalogMovie in catalog.CatalogStore)
            {
                this.InventoryCount++;

                momentaryStore.Add(new InventoryMovie(
                    catalogMovie.Name,
                    catalogMovie.Year,
                    catalogMovie.Director,
                    catalogMovie.CatalogCode,
                    this.InventoryCount,
                    Inventory.DEFAULT_QTY
                ));
            }

            return momentaryStore;
        }

        public Store<InventoryMovie> GetInventoryStore()
        {
            return InventoryStore;
        }

        public Store<InventoryMovie> GetMoviesByName(string nameToSearch)
        {
            Store<InventoryMovie> toReturn = new Store<InventoryMovie>();

            foreach (var movie in InventoryStore.Listing)
            {
                if (movie.Name == nameToSearch) toReturn.Add(movie);
            }

            return toReturn;
        }

        public InventoryMovie GetMovieByCode(uint codeToSearch)
        {
            var toReturn = InventoryStore.Listing.Find(movie => movie.InventoryCode.Equals(codeToSearch));

            if (toReturn == null) throw new ArgumentException($"The movie with the code '{codeToSearch}' was not found in the inventory.");

            return toReturn;
        }
    }
}
