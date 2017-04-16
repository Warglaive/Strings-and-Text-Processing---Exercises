using System;

namespace _04.Sentence_Split
{
    public class Program
    {
        public static void Main()
        {
            var sentence = Console.ReadLine();
            var delimiter = Console.ReadLine();
            var splitted = sentence.Split(new string[] { delimiter }, StringSplitOptions.None);
            Console.WriteLine("[" + string.Join(", ", splitted) + "]");
        }
    }
}