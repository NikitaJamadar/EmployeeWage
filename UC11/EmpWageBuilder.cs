using System;
using System.Collections.Generic;
using System.Text;

namespace UC11
{
    class EmpWageBuilder:IComputeEmpWage
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        int noOfCompany = 0;
        CompanyEmpWage[] companyWages;
        public EmpWageBuilder(int size)
        {
            this.companyWages = new CompanyEmpWage[size];
        }
        public void AddCompanyEmpWage(string CompanyName, int EmpRatePerHour, int noOfWorkinDays, int MaxHrPerMonth)
        {
            companyWages[this.noOfCompany] = new CompanyEmpWage(CompanyName, EmpRatePerHour, noOfWorkinDays, MaxHrPerMonth);
            noOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                companyWages[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyWages[i]));
                Console.WriteLine(this.companyWages[i].tostring());
            }
        }
        public int ComputeEmpWage(CompanyEmpWage companyWage)
        {
            int empHours = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= companyWage.MaxHrPerMonth && totalWorkingDays < companyWage.noOfWorkinDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isPartTime:
                        empHours = 4;
                        break;
                    case isFullTime:
                        empHours = 8;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                totalEmpHrs += empHours;

            }
            return totalEmpHrs * companyWage.EmpRatePerHour;
        }
        
    }
}


