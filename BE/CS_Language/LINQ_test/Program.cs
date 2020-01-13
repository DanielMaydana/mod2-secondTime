using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_test
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<Grades, bool> myDel = new Func<Grades, bool>(Approved);
            myDel += Cond1;
            List<Student> StudentsList = StudentListFactory.GetStudentList();
            List<Grades> GradesList = StudentListFactory.GetGradesList();

            //var joinStudentsGrades = (from stu in StudentsList
            //                          join grades_it in GradesList on stu.Id equals grades_it.Id
            //                          select new { stu.Id, stu.Name, stu.LastName, grades_it.Grade1, grades_it.Grade2 })
            //                          //.Where(Student => Student.Id == 2)
            //                          .Where(elem => myDel(new Grades(elem.Id, elem.Grade1, elem.Grade2)));
            //.Count(myDel);
            //.Count(elem => myDel(new Grades(elem.Id, elem.Grade1, elem.Grade2)));

            var joinStudentsGrades = (from stu in GradesList
                                      select stu).Where(elem => myDel(new Grades(elem.Id, elem.Grade1, elem.Grade2)));
            //            join grades_it in GradesList on stu.Id equals grades_it.Id
            //            select new { stu.Id, stu.Name, stu.LastName, grades_it.Grade1, grades_it.Grade2 })
            //.Where(Student => Student.Id == 2)

            var delCount = GradesList.Where(myDel);

            //Console.WriteLine(joinStudentsGrades);
            foreach (var elem in delCount)
            {
                Console.WriteLine(elem);
            }

            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }

        static bool Cond1(Grades grad)
        {
            int prom = (grad.Grade1 + grad.Grade2) / 2;
            return prom > 80;
        }

        static bool Approved(Grades grades)
        {
            int prom = (grades.Grade1 + grades.Grade2) / 2;
            return prom > 70;
        }
    }
}
