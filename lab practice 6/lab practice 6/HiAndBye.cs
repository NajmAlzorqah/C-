using System;
using System.Collections.Generic;
using System.Text;

namespace lab_practice_6
{
    class HiAndBye :  ISayHi, ISayBye
    {
        public void SayHi()
        {
            Console.WriteLine("Hi Saleh Zaid");
        }

        public void SayBye()
        {
            Console.WriteLine("Bye Saleh Zaid");
        }

         void   ISayHi.Same()
        {
            Console.WriteLine("Same Method for both Hi");
        }
          void ISayBye.Same()
        {
            Console.WriteLine("Same Method for both Bye ");
        }
    }
}
