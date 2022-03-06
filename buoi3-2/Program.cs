using System;

namespace buoi3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "hello world!";
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"length = {s.Length}");
            String s1 = s.Replace(" ", "");
            Console.WriteLine($"s = {s1}");
            String s2 = s.Substring(4,3);
            Console.WriteLine($"s = {s2}");

            Console.ReadLine();
        }
    }
}
