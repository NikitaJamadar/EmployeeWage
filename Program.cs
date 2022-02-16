using System;

namespace UC1
{
    class Program
    {
        public static void empCheck()
        {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int result = random.Next(0, 2);

            if (result == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Problem. ");

            Program.empCheck();
        }
    }
}

