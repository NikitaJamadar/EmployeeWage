using System;
using System.Collections.Generic;
using System.Text;

namespace UC11
{
    class CompanyEmpWage
    {
        public string CompanyName;
        public int EmpRatePerHour;
        public int noOfWorkinDays;
        public int MaxHrPerMonth;
        public int totalEmpWage;

        public CompanyEmpWage(string CompanyName, int EmpRatePerHour, int noOfWorkinDays, int MaxHrPerMonth)
        {
            this.CompanyName = CompanyName;
            this.EmpRatePerHour = EmpRatePerHour;
            this.noOfWorkinDays = noOfWorkinDays;
            this.MaxHrPerMonth = MaxHrPerMonth;
        }
        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "Total Employee Wage for company : " + this.CompanyName + " is : " + this.totalEmpWage;
        }
    }
}
