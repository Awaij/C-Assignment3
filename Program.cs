using System;

namespace Assignment3
{
    class Employee
    {
        int empno;
        string empname;
        public void emp_info()
        {
            Console.WriteLine("Enter Employee Number: ");
            empno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            empname = Console.ReadLine();
        }
    }

    class Manager : Employee
    {
        private double salary, gsal, nsal, PA, FA, OA, PF;


        public void calculatesalary()
        {
            Console.WriteLine("Enter salary = ");
            salary = double.Parse(Console.ReadLine());

            PA = salary * 8 / 100;
            FA = salary * 13 / 100;
            OA = salary * 3 / 100;

            gsal = salary + PA + FA + OA;
            Console.WriteLine("Manager's gross salary = " + gsal);

            PF = salary * 5 / 100;
            nsal = gsal - PF;

            Console.WriteLine("Net salary of Manager = " + nsal);
        }
    }
    class marketexcu : Employee
    {
        private double salary, gsal, nsal, PF, kmtravel, Tourallowance, Teleallowance;


        public void calculatesalary()
        {
            Console.WriteLine("Enter salary: ");
            salary = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter distance travelled in KM = ");
            kmtravel = double.Parse(Console.ReadLine());

            Tourallowance = 5 * kmtravel;

            Teleallowance = 800;

            gsal = salary + Tourallowance + Teleallowance;
            Console.WriteLine("Marketing Executing's gross salary = " + gsal);

            PF = salary * 5 / 100;
            nsal = gsal - PF;

            Console.WriteLine("Net salary of Marketing Executing = " + nsal);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Employee Payroll... ");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Marketing Executing");

            Console.WriteLine("Press key 1 or 2");
            int key = int.Parse(Console.ReadLine());

            Employee obj = new Employee();

            if (key == 1)
            {
                Manager M = new Manager();
                obj.emp_info();
                M.calculatesalary();
            }
            else
            {
                marketexcu ME = new marketexcu();
                obj.emp_info();
                ME.calculatesalary();
            }
        }
    }
}
