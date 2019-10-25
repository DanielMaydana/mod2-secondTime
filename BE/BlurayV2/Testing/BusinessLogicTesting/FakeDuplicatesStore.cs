using Models;
using System.Collections.Generic;

namespace Testing.BusinessTesting
{
    public class FakeDuplicatesStore : CatalogStore
    {
        public FakeDuplicatesStore()
        {
            Store = new List<CatalogMovie>()
            {
                new CatalogMovie("Devil's Awaitin' ", 2004, "Peter Hayes", 1001),
                new CatalogMovie(" Dirty Ol' Town'", 2011, "Robert Levon", 1002),
                new CatalogMovie(" Dirty Ol' Town'", 2011, "Robert Levon", 1002),
                new CatalogMovie("Burning Jacob's Ladder ", 2006, "Leah Shapiro", 1003),
                new CatalogMovie(" Sound City", 2014, "Dave Grohl", 1004)
            };
        }

    }
}
