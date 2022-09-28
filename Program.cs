using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int empPresent = 1;
            Random random = new Random();
            int EmpCheck = random.Next(0, 2);
            int empHr;
            int empRatePerHr = 20;
            if (EmpCheck == empPresent)
            {
                Console.WriteLine("Employee is present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent");
                empHr = 0;
            }
            int totalWage = empRatePerHr * empHr;
            Console.WriteLine("Total wage is " + totalWage);
        }
    }
}