using System;

namespace lab_practice_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            (ISayHi)HiAndBye Saleh = new HiAndBye();
            Saleh.SayHi();
            Saleh.SayBye();
            ((ISayHi)Saleh).Same();
            ((ISayBye)Saleh).Same();

            SumClass sum = new SumClass();
            Console.WriteLine("The Sum is : {0}",sum.Sum(1, 2));


        }
    }
}
