using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Manager:Employee
    {
        public int StockOptions { get; set; }
        //public Manager()
        //{
        //    StockOptions = 667;
        //}
        public Manager()
        {

        }
        public Manager(string fullName, int age, float currPay, int empID, string ssn, int numbOfOpts)
            :base(fullName,age , currPay, empID, ssn)
        {
            StockOptions = numbOfOpts;
        }
        public override void GiveBonus(float amount)
        {
            base.GiveBonus(amount);
            Random rand = new Random();
            StockOptions += rand.Next(500);
        }
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine($"Stock Options: {StockOptions}");
        }
    }
}
