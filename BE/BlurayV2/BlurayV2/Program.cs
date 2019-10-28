using BusinessLogic;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Testing.Mocks;

namespace BlurayV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory myInventory = new Inventory(new FakeCatalog());

            var inventoryStore = myInventory.GetInventoryStore();

            var expectedStore = new Store<InventoryMovie>()
            {
                new InventoryMovie("In My Time Of Dying", 1975, "Robert Plant", 1000, 1000, 0),
                new InventoryMovie("Houses of The Holy", 1975, "Jimmy Page", 1001, 1001, 0),
                new InventoryMovie("Red Dress", 2002, "Alex Turner", 1002, 1002, 0),
                new InventoryMovie("Night Flight", 1999, "Karen O", 1003, 1003, 0),
                new InventoryMovie("Sick Again", 2012,  "Matt Helders", 1004, 1004, 0)
            };

            foreach (var x in inventoryStore)
            {
                Console.WriteLine("{0} {1} {2} {3}", x.Quantity, x.Name, x.CatalogCode, x.InventoryCode);
            }

            var aux = expectedStore.Listing.Find(xx => xx.Name == "Houses of The Holy22");

            Console.WriteLine(aux.GetType());

            //var a = new InventoryMovie("Houses of The Holy", 1975, "Jimmy Page", 1001, 1001, 0);
            //var b = new InventoryMovie("Houses of The Holy", 1975, "Jimmy Page", 1001, 1001, 45);

            //Console.WriteLine(a == b);
        }
    }
}