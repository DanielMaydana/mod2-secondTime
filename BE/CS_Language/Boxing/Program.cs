using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Test();
            var tempObj = new Temp { someint = 2, somestr = "string", sometemp = new Temp { someint = 6, somestr = "innerstr" } };
            var tempint = 9;
            var temptstr = "original";

            test.TestInt(tempint);
            Console.WriteLine(tempint);

            test.TestStr(temptstr);
            Console.WriteLine(temptstr);

            test.TestInt(tempObj.someint);
            Console.WriteLine($"{ tempObj.someint}");

            //test.TestRefInt(ref tempint);
            Console.WriteLine(tempint);
        }


        public class Temp
        {
            public int someint { get; set; }
            public string somestr { get; set; }
            public Temp sometemp { get; set; }
        }

        public class Test
        {
            public void TestInt(int a)
            {
                a = 5;
            }

            public void TestStr(string a)
            {
                a = "new string";
            }

            public void TestObj(Temp obj)
            {
                //obj = new Temp { someint = 22, somestr = "stringgg", sometemp = new Temp { someint = 66, somestr = "inner stringgg" } };
                obj.someint = 666666;
            }

            public void TestRefInt(ref int a)
            {
                a = 7;
            }

        }

    }
}
