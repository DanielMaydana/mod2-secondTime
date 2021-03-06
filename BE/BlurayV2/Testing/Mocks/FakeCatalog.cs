﻿using BusinessLogic;
using Models;

namespace Testing.Mocks
{
    public class FakeCatalog : Catalog
    {
        public FakeCatalog()
        {
            this.CatalogStore = new Store<CatalogMovie>()
            {
                new CatalogMovie("In My Time Of Dying", 1975, "Robert Plant", 1001),
                new CatalogMovie("Houses of The Holy", 1975, "Jimmy Page", 1002),
                new CatalogMovie("Red Dress", 2002, "Jon Paul Jones", 1003),
                new CatalogMovie("Night Flight", 1999, "Jeff Buckley", 1004),
                new CatalogMovie("Alice in Wonderland", 1969, "Caroll Lewis", 1005),
                new CatalogMovie("Alice in Wonderland", 2008, "Alan Moore", 1006)
            };
        }
    }
}