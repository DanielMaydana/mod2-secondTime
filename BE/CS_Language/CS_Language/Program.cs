using System;
using System.Linq;
using System.Collections.Generic;

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

            //var game = new Game();
            //var player = new Player(game);

            //game.DoCount();

            //-------------------------------------

            //Animal a1 = new Animal();
            //Animal a2 = new Dog();

            //Console.WriteLine(a1.numberOfLegs);
            //Console.WriteLine(a2.numberOfLegs);

            //Factory<Dog> dogMaker = MakeDog;
            //Factory<Animal> animalMaker = dogMaker;

            //Console.WriteLine(animalMaker().numberOfLegs.ToString());


            //-------------------------------------

            //Action1<Animal> act1 = ActAnimal;
            //Action1<Dog> dog1 = act1;

            //dog1(new Dog());

            //-------------------------------------

            //IContravariant<object> myContrObj = new Sample<object>();
            //IContravariant<string> myContrStr = new Sample<string>();

            //myContrStr = myContrObj;

            //-------------------------------------

            //DContravariant<object> delObj = SampleObj;
            //DContravariant<string> delStr = SampleString;

            //delStr = delObj;

            //-------------------------------------

            //Factory<Animal> animal = MakeDog;
            //Factory<Dog> dog = MakeDog;

            //animal = dog;

            //Action1<object> objAct1 = SampleObj;
            //Action1<string> strAct2 = SampleString;

            //strAct2 = objAct1;

            //-------------------------------------

            //List<int> myArr = new List<int> { 1, 2, 3, 46, 5 };

            //IEnumerable<int> result = from n in myArr
            //                          where n < 10
            //                          select n;

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}


        }

        delegate T Factory<out T>();
        delegate void Action1<in T>(T arg);

        public delegate R DCovariant<out R>();

        public delegate void DContravariant<in A>(A argument);
        public static void SampleObj(object obj) { }
        public static void SampleInt(int number) { }
        public static void SampleString(string str) { }

        public interface IContravariant<in A> { }
        public interface IExtContravariant<in A> : IContravariant<A> { }
        public class Sample<A> : IContravariant<A> { }


        public static void ActAnimal(Animal a)
        {
            Console.WriteLine(a.numberOfLegs);
        }

        public class Animal
        {
            public int numberOfLegs = 6;
        }

        public class Dog : Animal
        {
            public Dog()
            {
                this.numberOfLegs = 4;
            }
        }

        public static Dog MakeDog()
        {
            return new Dog();
        }

        public class Game
        {
            public event EventHandler SayThree;
            public event EventHandler SayFive;
            public event EventHandler SaySeven;
            public event EventHandler SayNumber;
            private int counter;

            public Game()
            {
                this.counter = 0;
            }

            public void DoCount()
            {
                for (int i = 1; i <= 100; i++)
                {
                    this.counter++;

                    if (this.counter % 3 == 0) SayThree(this, null);
                    else if (this.counter % 5 == 0) SayFive(this, null);
                    else if (this.counter % 7 == 0) SaySeven(this, null);
                    else SayNumber(this, null);
                }
            }

            public int GetCounter()
            {
                return this.counter;
            }
        }

        public class Player
        {
            public Player(Game Game)
            {
                Game.SayThree += SayFizz;
                Game.SayFive += SayBuzz;
                Game.SaySeven += SayShazam;
                Game.SayNumber += SayNumber;
            }

            void SayFizz(object source, EventArgs args)
            {
                Console.WriteLine("Fizz");
            }

            void SayBuzz(object source, EventArgs args)
            {
                Console.WriteLine("Buzz");
            }

            void SayShazam(object source, EventArgs args)
            {
                Console.WriteLine("Shazam");
            }

            void SayNumber(object source, EventArgs args)
            {
                var number = ((Game)source).GetCounter();
                Console.WriteLine(number);
            }
        }
    }
}
