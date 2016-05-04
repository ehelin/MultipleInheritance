using MultipleInheritance.interfaces;
using MultipleInheritance.concrete;
using System;

namespace MultipleInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            IVerySpecificService verySpecificService = new VerySpecificServiceImpl();

            ConsumingClass consumingClass = new ConsumingClass(verySpecificService);
            consumingClass.Run();

            Console.Read(); //Hold application open til we are ready to close :)
        }
    }
}
