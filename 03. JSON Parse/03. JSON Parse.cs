using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.JSON_Parse
{
    public class Student
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public List<string> Grades { get; set; }
    }
    public class Program
    {
       public static void Main()
        {
            var result = new List<Student>();
            var input = Console.ReadLine()
                .Split(new string[] { "},{" }
            , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            for (int i = 0; i < input.Count; i++)
            {
                input[i] = input[i].Replace('"', ' ')
                    .Replace('[', ' ')
                    .Replace(']', ' ')
                    .Replace('{', ' ')
                    .Replace('}', ' ')
                    .Replace(',', ' ')
                    .Trim();
            }
            foreach (var item in input)
            {
                var student = item.Split(new[] { ' ', ',', ':' }
                ,StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var studentsName = student[1];
                var studentsAge = student[3];
                var studentsGrades = student.Skip(5).ToList();

                var newStudent = new Student()
                {
                    Name = studentsName,
                    Age = studentsAge,
                    Grades = studentsGrades
                };
                result.Add(newStudent);
            }
            foreach (var student in result)
            {
                if (student.Grades.Count == 0)
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> None");
                }
                else
                {
                    Console.WriteLine($"{student.Name} : {student.Age} -> {string.Join(", ", student.Grades)}");
                }
            }
        }
    }
}