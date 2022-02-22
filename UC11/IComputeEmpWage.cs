using System;
using System.Collections.Generic;
using System.Text;

namespace UC11
{
    interface IComputeEmpWage
    {
        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void ComputeEmpWage();
    }
}
