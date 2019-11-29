using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Language
{
    public class CodeGenerator
    {
        public void GenerateMaleCode(Student stu)
        {
            var firstLetter = stu.firstName[0].ToString();
            var secondLetter = stu.lastName[0].ToString();
            var thirdLetter = stu.name[0].ToString();

            var day = AddZeroToNumberString(stu.birthDate.Day);
            var yearAux = stu.birthDate.Year.ToString();
            var year = yearAux.Substring(yearAux.Length - 2);
            var month = AddZeroToNumberString(stu.birthDate.Month);

            string code = $"{year}-{month}{day}-{firstLetter}{secondLetter}{thirdLetter}";
            stu.code = code;
        }

        public void GenerateFemaleCode(Student stu)
        {
            var firstLetter = stu.firstName[0].ToString();
            var secondLetter = stu.lastName[0].ToString();
            var thirdLetter = stu.name[0].ToString();

            var day = AddZeroToNumberString(stu.birthDate.Day);
            var yearAux = (stu.birthDate.Year + 10).ToString();
            var year = yearAux.Substring(yearAux.Length - 2);
            var month = AddZeroToNumberString(stu.birthDate.Month);

            string code = $"{year}-{month}{day}-{firstLetter}{secondLetter}{thirdLetter}";
            stu.code = code;
        }

        private string AddZeroToNumberString(int number)
        {
            return number < 10 ? $"0{number.ToString()}" : number.ToString();
        }
    }

    public class Student
    {
        public string name { get; private set; }
        public string firstName { get; private set; }
        public string lastName { get; private set; }
        public string sex { get; private set; }
        public DateTime birthDate { get; private set; }
        public string code { get; set; }

        public Student(string name, string firstName, string lastName, string sex, DateTime birthDate)
        {
            this.name = name;
            this.firstName = firstName;
            this.lastName = lastName;
            this.sex = sex;
            this.birthDate = birthDate;
        }
    }
}
