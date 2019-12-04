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

            //var game = new Game();
            //var player = new Player(game);

            //game.DoCount();

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
