using System;

namespace UC10
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.addCompanyEmpWage("DMart", 20, 5, 10);
            empWageBuilder.addCompanyEmpWage("TCS", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
            Console.ReadLine();
        }
    }
}
