using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
        public string GetName()
        {
            return empName;
        }

        public void SetName(string name)
        {
            if (name.Length>15)
            {
                Console.WriteLine("Error.");
            }
            else
            {
                empName = name;
            }
        }
        virtual public void GiveBonus(float amount)
        {
            currPay += amount;
        }
        virtual public void DisplayStats()
        {
            Console.WriteLine($"Name: {empName}");
            Console.WriteLine($"ID: {empID}");
            Console.WriteLine($"Age: {empAge}");
            Console.WriteLine($"Pay: {currPay}");
            Console.WriteLine($"SSN: {SocialSecurityNumber}");
        }
        public string Name
        {
            get { return empName; }
            set { empName = value; }
        }
        public int Age
        {
            get { return empAge; }
            set { empAge = value; }
        }
        public int ID
        {
            get { return empID; }
            set { empID = value; }
        }
        public float Pay
        {
            get { return currPay; }
            set { currPay = value; }
        }
        protected BenefitPackage empBenefits = new BenefitPackage();
        public double GetBenefitCost()
        {
            return empBenefits.ComputePayDeduction();
        }
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }
        public class BenefitPackage
        {
            public enum BenefitPackageLevel
            {
                Standard,Gold,Platinum
            }
            public double ComputePayDeduction()
            {
                return 125.0;
            }
        }
    }
}
