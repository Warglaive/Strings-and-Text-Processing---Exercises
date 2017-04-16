using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Capitalize_Words
{
   public class Program
    {
       public static void Main()
        {
            var sentence = Console.ReadLine();
            while (sentence!="end")
            {
                var result = new List<string>();
                var token = sentence.ToLower()
                    .Split(new[] { ' ', ',', '.', ':', ';', '[', ']', '{', '}', '"', '\\', '(', ')', '-', '=', '>', '<', '~', '|', '`', '?', '!', '/', '*', '%', '$', '#', '@', '^', '&' }
                , StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                for (int i = 0; i < token.Count; i++)
                {
                    if (token[i] != string.Empty)
                    {
                        token[i] = UppercaseFirst(token[i]);
                        result.Add(token[i]);
                    }
                }
                Console.WriteLine(string.Join(", ", result));
                sentence = Console.ReadLine();
            }
        }
        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }
    }
}