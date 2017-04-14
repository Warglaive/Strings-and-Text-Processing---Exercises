using System;
using System.Linq;

namespace _01.Placeholders
{
    public class Program
    {
       public static void Main()
        {
            var input = Console.ReadLine();
            while (input != "end") 
            {
                var someString = input
                    .Split(new string[] { "->" }
                    ,StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                var sentence = someString[0];
                var elements = someString[1]
                    .Split(new[] { ' ', ',' }
                , StringSplitOptions.RemoveEmptyEntries)
                .ToList();
                for (int i = 0; i < elements.Count; i++)
                {
                    var placeHolderFormat = "{" + i + "}";
                    sentence = sentence.Replace(placeHolderFormat, elements[i]);
                }
                Console.WriteLine(sentence);
                input = Console.ReadLine();
            }
        }
    }
}