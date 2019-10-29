using BusinessLogic;
using Models;

namespace Testing.Mocks
{
    public class FakeDuplicatesCatalog : Catalog
    {
        public FakeDuplicatesCatalog()
        {
            this.CatalogStore = new Store<CatalogMovie>()
            {
                new CatalogMovie("In My Time Of Dying", 1975, "Robert Plant", 1023),
                new CatalogMovie("In My Time Of Dying", 1975, "Robert Plant", 1023),
                new CatalogMovie("Red Dress", 2002, "Jon Paul Jones", 1031),
                new CatalogMovie("Red Dress", 2002, "Jon Paul Jones", 1031),
                new CatalogMovie("Red Dress", 2002, "Jon Paul Jones", 1031),
                new CatalogMovie("Night Flight", 1999, "Jeff Buckley", 1004),
                new CatalogMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005),
                new CatalogMovie("Alice in Wonderland", 2008, "Alan Moore", 1006)
            };
        }
    }
}