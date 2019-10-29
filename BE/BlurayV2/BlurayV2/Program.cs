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
            List<string> myList = new List<string>();

            //myList.Add("piledriver");
            //myList.Add("waltz");
            //myList.Add("miserable");
            //myList.Add("shoes");

            //Console.WriteLine(found == null);

            var mymy = new brmc();
            mymy.find();
        }

        public class brmc
        {
            List<string> myList;
            public brmc()
            {
            }

            public void find()
            {
                string result = myList.Find(x => x.Equals("YES"));

                Console.WriteLine("{0} {1}", result, result == null);
            }
        }

    }
}