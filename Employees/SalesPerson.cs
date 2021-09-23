using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class SalesPerson : Employee
    {
        public int SalesNumber { get; }
        public SalesPerson() {}
        public SalesPerson(string fullName, int age, float currPay, int empID, string ssn, int salesNum)
            :base(fullName, age, currPay, empID, ssn)
        {
            SalesNumber = salesNum;
        }
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if(SalesNumber>=0&&SalesNumber<=100)
            {
                salesBonus = 10;
            }
            else
            {
                if (SalesNumber>=100&&SalesNumber<=200)
                {
                    salesBonus = 15;
                }
                else
                {
                    salesBonus = 20;
                }
            }
            base.GiveBonus(amount * salesBonus);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Sales number: {SalesNumber}");
        }
    }
    sealed class PTSalesPerson: SalesPerson
    {
        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn, int salesNum)
            : base(fullName, age, currPay, empID, ssn, salesNum)
        {

        }
    }
}
