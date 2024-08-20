using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Najm Aldeen  ";
            Console.WriteLine("Trim: '{0}'" , fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'" , fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var fName = fullName.Substring(0, index);
            var lName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + fName);
            Console.WriteLine("last Name: " + lName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            
            Console.WriteLine(fullName.Replace("Aldeen", "Alzorqah"));

            if (String.IsNullOrEmpty(null))
            {
                Console.WriteLine("1 - Invalid");
            }

            if (String.IsNullOrEmpty(" "))
            {
                Console.WriteLine("2 - Invalid");
            }
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("3 - Invalid");
            }

             


        }
    }
}
