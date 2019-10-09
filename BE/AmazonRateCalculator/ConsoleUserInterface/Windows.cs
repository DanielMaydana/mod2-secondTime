﻿using BusinessLogic;
using Model;
using System;
using System.Threading;

namespace ConsoleUserInterface
{
    public class Windows
    {
        private ShippingOperation StandardOperation;
        private ShippingOperation ExpeditedOperation;
        private ShippingOperation PriorityOperation;
        private Cart myCart;

        public Windows()
        {
            StandardOperation = new ShippingOperation();
            ExpeditedOperation = new ShippingOperation();
            PriorityOperation = new ShippingOperation();
            PopulateTypicalOperations();
            myCart = new Cart();
        }

        private void ShowCart(Cart myCart)
        {
            Console.Clear();
            Console.WriteLine("Products form Cart");

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
                    Console.WriteLine("Bye");
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
                }

                Thread.Sleep(2500);
                finished = true;
            }

            Console.Clear();
            //Console.WriteLine("You finished registering a product\n");
            //Console.WriteLine(StringifyProduct(tempProd));
            //Thread.Sleep(2500);
        }

        private string StringifyProduct(Product prod)
        {
            return $"Category: {prod.category} - Weight: {prod.weight} - Qty: {prod.quantity}";
        }

        private void PopulateTypicalOperations()
        {
            StandardOperation.name = "Standard";
            StandardOperation.oneTimeCharge = 2.99;
            StandardOperation.perOverweightSurcharge = 1.99;
            StandardOperation.setCategoryRates("Book", 3.99);
            StandardOperation.setCategoryRates("CDs", 2.99);
            StandardOperation.setCategoryRates("Jewelry", 0, 1.99, false);
            StandardOperation.setCategoryRates("Automotive", 0, 1.99, false);

            ExpeditedOperation.name = "Expedited";
            ExpeditedOperation.oneTimeCharge = 7.99;
            ExpeditedOperation.perOverweightSurcharge = 1.99;
            ExpeditedOperation.setCategoryRates("Book", 4.99);
            ExpeditedOperation.setCategoryRates("CDs", 3.99);
            ExpeditedOperation.setCategoryRates("Jewelry", 0, 2.99, false);
            ExpeditedOperation.setCategoryRates("Kindle", 2.99, 0, false);
            ExpeditedOperation.setCategoryRates("Automotive", 0, 2.99, true);
            ExpeditedOperation.setCategoryRates("Luggage", 0, 2.99, false);

            PriorityOperation.name = "Priority";
            PriorityOperation.oneTimeCharge = 29.99;
            PriorityOperation.perOverweightSurcharge = 2.49;
            PriorityOperation.setCategoryRates("Book", 6.99);
            PriorityOperation.setCategoryRates("CDs", 2.99);
            PriorityOperation.setCategoryRates("Apparel", 0, 3.99, false);
            PriorityOperation.setCategoryRates("Automotive", 0, 3.99, false);
            PriorityOperation.setCategoryRates("Kindle", 6.99, 0, false);
        }
    }
}
