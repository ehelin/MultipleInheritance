using System;
using MultipleInheritance.interfaces;

namespace MultipleInheritance.concrete
{
    public class ServiceImpl : IService
    {
        public void Method1()
        {
            Console.WriteLine("Service Impl Method 1 has run");
        }

        public void Method2()
        {
            Console.WriteLine("Service Impl Method 2 has run");
        }
    }
}
