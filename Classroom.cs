using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ.Classroom
{

    public class Classroom
    {
        public List<string> Students = new List<string>();
    }

    class Program
    {
        public static void Main()
        {
            CheckStudents();
            Console.ReadKey();
        }

        public static void CheckStudents()
        {
            Classroom[] classes =
            {
                new Classroom {Students = {"Pavel", "Ivan", "Petr"},},
                new Classroom {Students = {"Anna", "Ilya", "Vladimir"},},
                new Classroom {Students = {"Bulat", "Alex", "Galina"},}
            };

            var allStudents = GetAllStudents(classes);
            Array.Sort(allStudents);
            Console.WriteLine(string.Join(" ", allStudents));
        }

        public static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(l => l.Students).ToArray();
        }
    }
}
