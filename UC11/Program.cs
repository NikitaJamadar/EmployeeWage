using System;

namespace UC11
{
    class Program
    {
        static void Main(string[] args)
        {
            IComputeEmpWage computeEmpWage = new EmpWageBuilder(2);
            computeEmpWage.AddCompanyEmpWage("wipro", 20, 10, 20);
            computeEmpWage.AddCompanyEmpWage("TCS", 10, 30, 40);
            computeEmpWage.ComputeEmpWage();
        }
    }
}
