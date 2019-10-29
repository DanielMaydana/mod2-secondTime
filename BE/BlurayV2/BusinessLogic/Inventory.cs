using Models;
using System;

namespace BusinessLogic
{
    public class Inventory
    {
        private Store<InventoryMovie> InventoryStore { get; set; }
        private uint InventoryCount;
        private const uint DEFAULT_QTY = 1;

        public Inventory(Catalog catalog)
        {
            this.InventoryCount = 1000;
            this.InventoryStore = new Store<InventoryMovie>();
            this.InventoryStore = PopulateInventoryStore(catalog);
        }

        public Inventory()
        {
            this.InventoryCount = 1000;
            this.InventoryStore = new Store<InventoryMovie>();
        }

        private Store<InventoryMovie> PopulateInventoryStore(Catalog catalog)
        {
            var momentaryStore = new Store<InventoryMovie>();

            foreach (var catalogMovie in catalog.CatalogStore)
            {
                InventoryMovie inventoryMovie = GetInventoryMovie(catalogMovie, momentaryStore);

                if (inventoryMovie == null)
                {
                    inventoryMovie = CreateInventoryMovie(catalogMovie);
                    momentaryStore.Add(inventoryMovie);
                }
                else
                {
                    inventoryMovie.Quantity++;
                }
            }

            return momentaryStore;
        }

        private InventoryMovie CreateInventoryMovie(CatalogMovie catalogMovie)
        {
            this.InventoryCount++;

            InventoryMovie inventoryMovie = new InventoryMovie(
                catalogMovie.Name,
                catalogMovie.Year,
                catalogMovie.Director,
                catalogMovie.CatalogCode,
                this.InventoryCount,
                Inventory.DEFAULT_QTY
            );

            return inventoryMovie;
        }

        private InventoryMovie GetInventoryMovie(CatalogMovie catalogMovie, Store<InventoryMovie> store)
        {
            var movieToReturn = store.Listing.Find(
                movie => movie.Name.Equals(catalogMovie.Name)
                            && movie.Director.Equals(catalogMovie.Director)
                            && movie.Year.Equals(catalogMovie.Year)
                            && movie.CatalogCode.Equals(catalogMovie.CatalogCode)
            );

            return movieToReturn;
        }

        public InventoryMovie AddSingleMovie(CatalogMovie catalogMovie)
        {
            InventoryMovie inventoryMovie = GetInventoryMovie(catalogMovie, this.InventoryStore);

            if (inventoryMovie == null)
            {
                inventoryMovie = CreateInventoryMovie(catalogMovie);
                this.InventoryStore.Add(inventoryMovie);
            }
            else
            {
                inventoryMovie.Quantity++;
            }

            return inventoryMovie;
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
