using System;

namespace EmpWage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWage.DisplayWelcome();
            UC1.CheckAttendance();
            UC2.DailyEmpWage();
            UC3.PartTimeWage();
            UC4.EmpWageUsingSwitchCase();
            UC5.MonthlyWage();
            UC6.EmployeeWage();
        }
    }
}
