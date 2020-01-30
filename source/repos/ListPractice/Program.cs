using System;
using System.Collections.Generic;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> newlist = new List<string> { "Hello", "Hi", "Byee" };
            Console.WriteLine("");
            Console.WriteLine("Before Adding");
            foreach(var item in newlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("After Adding");
            newlist.Add("New element");
            foreach(var item in newlist)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("After removing");
            newlist.Remove("hi");
            newlist.RemoveAt(1);
            foreach (var item in newlist)
            {
                Console.WriteLine(item);
            }
        }
    }
}
