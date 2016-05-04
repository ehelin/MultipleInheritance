using System;
using MultipleInheritance.interfaces;

namespace MultipleInheritance.concrete
{
    public class VerySpecificServiceImpl : SpecificServiceImpl, IVerySpecificService
    {
        public void Method4()
        {
            Console.WriteLine("Very Specific Service Impl Method 4 has run");
        }
    }
}
