using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    abstract partial class Employee
    {
        protected string empName;
        protected int empID;
        protected float currPay;
        protected int empAge;
        protected string SocialSecurityNumber { get; }
        //public Employee()
        //{
        //    empName = "unlucky";
        //}
        public Employee()
        {

        }
        public Employee(string name, int age, float pay, int id, string ssn):this(name,age,pay,id)
        {
            SocialSecurityNumber = ssn;
        }
        public Employee(string name, int age, float pay, int id)
        {
            empName = name;
            empID = id;
            empAge = age;
            currPay = pay;
        }
    }
}
