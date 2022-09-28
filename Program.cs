using System;

namespace empWage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            int fulltimePresent = 1;
            int parttimePresent = 2;
            Random random = new Random();
            int EmpCheck = random.Next(0, 3);
            int empHr;
            int empRatePerHr = 20;
            if (EmpCheck == fulltimePresent)
            {
                Console.WriteLine("Employee is fulltime present");
                empHr = 8;
            }
            else if (EmpCheck == parttimePresent)
            {
                Console.WriteLine("Employee is parttime present");
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