using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            //Manager fred = new Manager("Fred", 31, 1125, 2500, "5798152", 50);
            //fred.Name = "Fred";
            //fred.Age = 31;
            SalesPerson dick = new SalesPerson("Dick", 25, 1800, 1634, "5815325", 87);
            dick.DisplayStats();
            dick.GiveBonus(300);
            dick.DisplayStats();
            double cost = dick.Benefits.ComputePayDeduction();
            Console.WriteLine();

            OuterClass.PublicInnerClass inner = new OuterClass.PublicInnerClass();
            //Error:
            //OuterClass.PrivateInnerClass prInner = new OuterClass.PrivateInnerClass();

            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            Console.WriteLine(myBenefitLevel);
            Console.WriteLine("\n\n\n");

            Manager chucky = new Manager("Chucky", 34, 10000, 1289, "115468", 500);
            chucky.GiveBonus(500);
            chucky.DisplayStats();
            Console.WriteLine();

            SalesPerson fran = new SalesPerson("Fran", 27, 2000, 1357, "252125", 159);
            fran.GiveBonus(200);
            fran.DisplayStats();
            Console.WriteLine();

            //Error: cannot create an instance of abstract class.
            //Employee emp = new Employee();
        }
    }
}
