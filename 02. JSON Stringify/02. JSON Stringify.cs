using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.JSON_Stringify
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
            var input = Console.ReadLine();
            while (input != "stringify")
            {
                var token = input
                    .Split(new[] { ' ', ':', '-', '>', ',' }
                , StringSplitOptions.RemoveEmptyEntries);
                var name = token[0];
                var age = token[1];
                var grades = token.Skip(2).ToList();
                var newStudents = new Student
                {
                    Name = name,
                    Age = age,
                    Grades = grades
                };
                result.Add(newStudents);

                input = Console.ReadLine();
            }
            string output = string.Empty;
            output += "[";
            for (int i = 0; i < result.Count; i++)
            {
                Student currentStudent = result[i];
                output += "{";
                output += "name:\"" + currentStudent.Name + "\"" + ",";
                output += "age:" + currentStudent.Age + ",";
                output += "grades:[" + string.Join(", ", currentStudent.Grades) + "]";
                output += "}";
                if (i < result.Count - 1) 
                {
                    output += ',';
                }
            }
            output += "]";
            Console.WriteLine(output);
        }
    }
}