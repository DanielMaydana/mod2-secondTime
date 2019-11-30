using System;

namespace CS_Language
{
    class Program
    {
        delegate int AddNumber(int x);
        delegate void AddNumberRef(ref int x);
        delegate void AddNumberObject(object x);
        delegate void GetCode(Student stu);

        static void Main(string[] args)
        {
            //var del = new DelegatesLesson();

            //AddNumberRef manyOperations = del.Add10;
            //manyOperations += del.Add20;

            //int refInt = 25;

            //manyOperations.Invoke(ref refInt);

            //-------------------------------------

            //Student jose = new Student("Jose", "Ecos", "Fernandez", "M", new DateTime(1983, 1, 20));
            //Student carla = new Student("Carla", "Barrenechea", "Kuber", "F", new DateTime(1993, 7, 22));

            //CodeGenerator myCodeGen = new CodeGenerator();
            //GetCode getCode;
            //var student = jose;

            //switch (student.sex)
            //{
            //    case "M":
            //        getCode = myCodeGen.GenerateMaleCode;
            //        break;
            //    case "F":
            //        getCode = myCodeGen.GenerateFemaleCode;
            //        break;
            //    default:
            //        getCode = null;
            //        break;
            //}

            //getCode(student);

            //Console.WriteLine(student.code);

            //-------------------------------------

            //var valOutside = 7;

            //AddNumber anon1 = delegate (int x)
            //{
            //    return x + 3 + valOutside;
            //};

            //var res = anon1(5);

            //Console.WriteLine(res);

            //AddNumber anon2 = (int x) => { return x + 2; };
            //AddNumber anon3 = x => { return ++x; };
            //AddNumber anon4 = x => ++x;

            //-------------------------------------

            //var dzn = new Dozen();
            var fizz = new Fizz();
            var buzz = new Buzz();
            var person = new Person();
            var shaz = new Shazam();

            Increment.DoCount();
        }


        public static class Increment // PUBLISHER
        {
            //public delegate void EventHandler(int n); // 1 delegate
            //public static event EventHandler CountDozen; // 3 event declaration

            public delegate void WordEventHandler();
            public delegate void NumberEventHandler(int n);
            public static event WordEventHandler SayWordThree;
            public static event WordEventHandler SayWordFive;
            public static event NumberEventHandler SayNumber;

            //delegate void HandlerSpecial(object source, EventArgs args);
            public static event EventHandler SayWord7;

            public static void DoCount()
            {
                int count = 0;

                for (int i = 0; i < 100; i++)
                {
                    count++;

                    //if (CountDozen != null)
                    //{
                    if (count % 3 == 0) SayWordThree();
                    else if (count % 5 == 0) SayWordFive();
                    else if (count % 7 == 0) SayWord7(null, null);
                    else SayNumber(count);
                    //}

                    //if (CountDozen != null) CountDozen(count); // 5 rise the event 
                }
            }
        }

        public class Dozen // SUBSCRIBER
        {
            //public Dozen()
            //{
            //    Increment.CountDozen += IncrementCount; // 4 subscribe to event
            //}

            //public void IncrementCount(int n) // 2 handler
            //{
            //    Console.WriteLine("Dozen reached");
            //}
        }

        public class Person
        {
            public Person()
            {
                Increment.SayNumber += SayNumber;
            }

            public void SayNumber(int n) // 2 handler
            {
                Console.WriteLine(n);
            }
        }

        public class Fizz
        {
            public Fizz()
            {
                Increment.SayWordThree += SayFizz;
            }

            public void SayFizz()
            {
                Console.WriteLine("Fizz");
            }
        }

        public class Buzz
        {
            public Buzz()
            {
                Increment.SayWordFive += SayBuzz;
            }

            public void SayBuzz()
            {
                Console.WriteLine("Buzz");
            }
        }

        public class Shazam
        {
            public Shazam()
            {
                Increment.SayWord7 += SayShazam;
            }

            private void SayShazam(object source, EventArgs args)
            {
                Console.WriteLine("Shazam");
            }
        }
    }
}
