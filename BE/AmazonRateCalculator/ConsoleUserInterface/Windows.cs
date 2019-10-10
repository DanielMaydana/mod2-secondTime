using BusinessLogic;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Threading;

namespace ConsoleUserInterface
{
    public class Windows
    {
        private ShippingOperation StandardOperation;
        private ShippingOperation ExpeditedOperation;
        private ShippingOperation PriorityOperation;
        private ShippingOperation CustomOperation;
        private Cart myCart;

        public Windows()
        {
            StandardOperation = new ShippingOperation();
            ExpeditedOperation = new ShippingOperation();
            PriorityOperation = new ShippingOperation();
            CustomOperation = new ShippingOperation();
            PopulateTypicalOperations();
            myCart = new Cart();
        }

        private void ShowCart(Cart myCart)
        {
            Console.Clear();
            Console.WriteLine("Products in your cart:\n");

            foreach (Product prod in myCart.productList)
            {
                Console.WriteLine(StringifyProduct(prod));
            }

            Thread.Sleep(2500);
        }

        public void Renderize()
        {
            Console.WriteLine("1. Create Order");
            Console.WriteLine("2. Exit");

            string stringedKey = Console.ReadKey().Key.ToString();

            switch (stringedKey)
            {
                case "D1":
                    while (stringedKey != "X")
                    {
                        Console.Clear();
                        Console.WriteLine("1. Register Product");
                        Console.WriteLine("2. Calculate Shipment Cost");
                        Console.WriteLine("[X] Exit");

                        stringedKey = Console.ReadKey().Key.ToString();

                        switch (stringedKey)
                        {
                            case "D1":
                                RegisterProduct();
                                ShowCart(myCart);
                                break;

                            case "D2":
                                CalculateShipmentCost();
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Option not found");
                                Thread.Sleep(1500);
                                break;
                        }
                    }
                    break;

                case "D2":
                    Console.Clear();
                    Console.WriteLine("BYE");
                    Thread.Sleep(1500);
                    break;
            }
        }

        private void RegisterProduct()
        {
            Product tempProd = new Product();
            bool typeAssign = false;
            bool weightAssign = false;
            bool qtyAssign = false;
            bool finished = false;

            while (!finished)
            {
                Console.Clear();
                Console.WriteLine("Register Product");
                Console.WriteLine("1. Type");
                Console.WriteLine("2. Weight");
                Console.WriteLine("3. Quantity");

                string stringedKey = Console.ReadKey().Key.ToString();

                switch (stringedKey)
                {
                    case "D1":
                        Console.Clear();
                        Console.WriteLine("Register Product Type");
                        tempProd.category = Console.ReadLine();
                        typeAssign = true;
                        break;

                    case "D2":
                        Console.Clear();
                        Console.WriteLine("Register Product Weight");
                        tempProd.weight = Convert.ToDouble(Console.ReadLine());
                        weightAssign = true;
                        break;

                    case "D3":
                        Console.Clear();
                        Console.WriteLine("Register Product Quantity");
                        tempProd.quantity = Convert.ToInt32(Console.ReadLine());
                        qtyAssign = true;
                        break;
                }
                if (typeAssign && weightAssign && qtyAssign) finished = true;
            }

            myCart.productList.Add(tempProd);
            Console.Clear();
            Console.WriteLine("You finished registering a product\n");
            Console.WriteLine(StringifyProduct(tempProd));
            Thread.Sleep(2500);
        }

        private void CalculateShipmentCost()
        {
            bool finished = false;

            while (!finished)
            {
                Console.Clear();
                Console.WriteLine("Calculate Shipment Cost");
                Console.WriteLine("1. Standard");
                Console.WriteLine("2. Expedited");
                Console.WriteLine("3. Priority");
                Console.WriteLine("[X] Exit");

                string stringedKey = Console.ReadKey().Key.ToString();
                ShipmentCostCalculator myCalculator = new ShipmentCostCalculator();
                double result;

                switch (stringedKey)
                {
                    case "D1":
                        Console.Clear();
                        result = myCalculator.Calculate(myCart, StandardOperation);
                        Console.WriteLine($"Cost for Standard Shipping: {result}");
                        break;

                    case "D2":
                        Console.Clear();
                        result = myCalculator.Calculate(myCart, ExpeditedOperation);
                        Console.WriteLine($"Cost for Expedited Shipping: {result}");
                        break;

                    case "D3":
                        Console.Clear();
                        result = myCalculator.Calculate(myCart, PriorityOperation);
                        Console.WriteLine($"Cost for Priority Shipping: {result}");
                        break;
                    case "X":
                        Console.Clear();
                        break;
                }

                Thread.Sleep(2500);
                finished = true;
            }

            Console.Clear();
        }

        private string StringifyProduct(Product prod)
        {
            return $"+ Category: {prod.category} | Weight: {prod.weight} | Qty: {prod.quantity}";
        }

        private void PopulateTypicalOperations()
        {
            List<string> standardCategory1 = new List<string> { "Books", "VHS" };
            List<string> standardCategory2 = new List<string> { "CDs", "DVDs", "Blu-ray", "Cassettes", "Vinyl" };
            List<string> standardCategory3 = new List<string> { "Jewelry", "Watches", "Automotive", "Baby", "Computers", "Electronics", "Home", "Personal Care", "Kitchen", "Outdoor Living", "Sports", "Tools", "Toys", "Clothing Items", "Video Games" };
            StandardOperation.name = "Standard";
            StandardOperation.oneTimeCharge = 2.99;
            StandardOperation.perOverweightSurcharge = 1.99;
            StandardOperation.SetCategoryRates(standardCategory1, 3.99);
            StandardOperation.SetCategoryRates(standardCategory2, 2.99);
            StandardOperation.SetCategoryRates(standardCategory3, 0, 1.99, false);

            List<string> expeditedCategory1 = new List<string> { "Books", "VHS" };
            List<string> expeditedCategory2 = new List<string> { "CDs", "DVDs", "Blu-ray", "Cassettes", "Vinyl" };
            List<string> expeditedCategory3 = new List<string> { "Jewelry", "Watches", "Clothing Items" };
            List<string> expeditedCategory4 = new List<string> { "Kindle " };
            List<string> expeditedCategory5 = new List<string> { "Automotive", "Baby", "Computers", "Electronics", "Home", "Personal Care", "Kitchen", "Outdoor Living", "Sports", "Tools", "Toys", "Video Games" };
            List<string> expeditedCategory6 = new List<string> { "Luggage" };
            ExpeditedOperation.name = "Expedited";
            ExpeditedOperation.oneTimeCharge = 7.99;
            ExpeditedOperation.perOverweightSurcharge = 1.99;
            ExpeditedOperation.SetCategoryRates(expeditedCategory1, 4.99);
            ExpeditedOperation.SetCategoryRates(expeditedCategory2, 3.99);
            ExpeditedOperation.SetCategoryRates(expeditedCategory3, 0, 2.99, false);
            ExpeditedOperation.SetCategoryRates(expeditedCategory4, 2.99, 0, false);
            ExpeditedOperation.SetCategoryRates(expeditedCategory5, 0, 2.99, true);
            ExpeditedOperation.SetCategoryRates(expeditedCategory6, 0, 2.99, false);

            List<string> priorityCategory1 = new List<string> { "Books", "VHS" };
            List<string> priorityCategory2 = new List<string> { "CDs", "DVDs", "Blu-ray", "Cassettes", "Vinyl" };
            List<string> priorityCategory3 = new List<string> { "Apparel", "Watches" };
            List<string> priorityCategory4 = new List<string> { "Automotive", "Baby", "Computers", "Electronics", "Home", "Luggage", "Personal Care", "Kitchen", "Outdoor Living", "Sports", "Tools", "Toys" };
            List<string> priorityCategory5 = new List<string> { "Kindle" };
            PriorityOperation.name = "Priority";
            PriorityOperation.oneTimeCharge = 29.99;
            PriorityOperation.perOverweightSurcharge = 2.49;
            PriorityOperation.SetCategoryRates(priorityCategory1, 6.99);
            PriorityOperation.SetCategoryRates(priorityCategory2, 2.99);
            PriorityOperation.SetCategoryRates(priorityCategory3, 0, 3.99, false);
            PriorityOperation.SetCategoryRates(priorityCategory4, 0, 3.99, false);
            PriorityOperation.SetCategoryRates(priorityCategory5, 6.99, 0, false);
        }

        public void ReadConfiguration()
        {
            string name = Convert.ToString(ConfigurationManager.AppSettings["shipmentType"]);
            double oneTimeCharge = Convert.ToDouble(ConfigurationManager.AppSettings.Get("oneTimeCharge"));
            double perOverweightSurcharge = Convert.ToDouble(ConfigurationManager.AppSettings.Get("perOverweightSurcharge"));
            string categoryName = Convert.ToString(ConfigurationManager.AppSettings.Get("categoryName"));
            double perItemCharge = Convert.ToDouble(ConfigurationManager.AppSettings.Get("perItemCharge"));
            double perPoundCharge = 0;
            bool surchargeApplies = true;

            CustomOperation.SetCategoryRates(categoryName, perItemCharge, perPoundCharge, surchargeApplies);

            Console.WriteLine($"Name: {name} | OneTimeCharge: {oneTimeCharge} | PerOverweightSurcharge:{perOverweightSurcharge} | categoryName: {categoryName} | perItemCharge: {perItemCharge}");

        }
    }
}
