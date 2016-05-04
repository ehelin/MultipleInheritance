using System;
using MultipleInheritance.interfaces;
using MultipleInheritance.concrete;

namespace MultipleInheritance
{
    public class SpecificServiceImpl : ServiceImpl, ISpecificService
    {
        public void Method3()
        {
            Console.WriteLine("Specific Service Impl Method 3 has run");
        }
    }
}
