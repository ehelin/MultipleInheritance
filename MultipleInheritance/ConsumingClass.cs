using MultipleInheritance.interfaces;

namespace MultipleInheritance
{
    public class ConsumingClass
    {
        private IVerySpecificService verySpecificService = null;

        public ConsumingClass(IVerySpecificService verySpecificService)
        {
            this.verySpecificService = verySpecificService;
        }

        public void Run() 
        {
            verySpecificService.Method1();
            verySpecificService.Method2();
            verySpecificService.Method3();
            verySpecificService.Method4();
        }
    }
}
