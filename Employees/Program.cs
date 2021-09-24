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

            CastingExamples();
        }
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 29, 3000, 40000, "111-11-1111", 5);
            //Error: cannot convert from object to employee.
            //GivePromotion(frank);
            GivePromotion((Manager)frank);
            //Error: unable to cast object of type 'Employees.Manager' to type 'Employees.Hexagon'.
            //Hexagon hex = (Hexagon)frank;

            Hexagon hex;
            try
            {
                hex = (Hexagon)frank;
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Employee moonUnit = new Manager("MoonUnit Zappa", 22, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);
            SalesPerson jill = new PTSalesPerson("Jill", 34, 3002, 100000, "111-12-1119", 90);
            GivePromotion(jill);
            Console.WriteLine();

            //Using keyword "as".
            object[] things = new object[4];
            things[0] = new Hexagon();
            things[1] = false;
            things[2] = new Manager();
            things[3] = "Last thing";
            foreach (var item in things)
            {
                Hexagon h = item as Hexagon;
                if (h==null)
                {
                    Console.WriteLine("Item is not a Hexagon");
                }
                else
                {
                    h.Draw();
                }
            }
        }
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine($"{emp.Name} was promoted!");
            //if (emp is SalesPerson)
            //{
            //    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, ((SalesPerson)emp).SalesNumber);
            //    Console.WriteLine();
            //}
            //if (emp is Manager m)
            //{
            //    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
            //    Console.WriteLine();
            //}
            switch (emp)
            {
                case SalesPerson s when s.SalesNumber > 5:
                    Console.WriteLine("{0} made {1} sale(s)!", emp.Name, s.SalesNumber);
                    break;
                case Manager m:
                    Console.WriteLine("{0} had {1} stock options...", emp.Name, m.StockOptions);
                    break;
                //Ignore interns:
                //case Intern _:
                //    break;
                case null:
                    Console.WriteLine("Take some action in case of null.");
                    break;
            }
            Console.WriteLine();
        }
    }
}
