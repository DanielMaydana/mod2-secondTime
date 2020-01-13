using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_test
{
    public class StudentListFactory
    {
        public static List<Student> GetStudentList()
        {
            return new List<Student>
            {
                new Student(1,"Guillermo","Espindola"),
                new Student(2,"Daniel","Maydana"),
                new Student(3,"Ariel","Arias"),
                new Student(4,"Carlos","Perez"),
                new Student(5,"Geovani","Vallejos"),
                new Student(6,"Orlando","Rivas")
            };
        }

        public static List<Grades> GetGradesList()
        {
            return new List<Grades>
            {
                new Grades(1,100,99),
                new Grades(2,100,100),
                new Grades(3,50,51),
                new Grades(4,75,75),
                new Grades(5,20,80)
            };
        }
    }
}
