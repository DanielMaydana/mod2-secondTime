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

            var valOutside = 7;

            AddNumber anon1 = delegate (int x)
            {
                return x + 3 + valOutside;
            };

            var res = anon1(5);

            Console.WriteLine(res);

            //-------------------------------------

            AddNumber anon2 = (int x) => { return x + 2; };
            AddNumber anon3 = x => { return ++x; };
            AddNumber anon3 = x => ++x;
        }
    }
}
