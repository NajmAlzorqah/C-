using System;
using System.Collections.Generic;

namespace Arrays_and_lists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var numbers = new[] { 3, 7, 9, 2, 14, 6 };

            // length
            Console.WriteLine("Length: " + numbers.Length);
            

            // IndexOf()
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index Of 9: " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Copy()
            var another = new int[3];
            Array.Copy(numbers, another, 3);
            Console.WriteLine("The result of copying array");
            foreach (var item in another)
            {
                Console.WriteLine(item);
            }

            // Sort ()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            // Reverse ()
            Array.Reverse(numbers);
            Console.WriteLine("Effect of Reverse()");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }*/

            // =============Lists=========
            var numbers = new List<int>() {1,2,3,4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            Console.WriteLine("Index Of 1: " + numbers.IndexOf(1));
            Console.WriteLine();
            Console.WriteLine("Last Index Of 1: " + numbers.LastIndexOf(1));

            Console.WriteLine("Count: " + numbers.Count);

            numbers.Remove(1);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
