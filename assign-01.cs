using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_1
{
    class Program
    {

        static void Main()
        {
            Employee emp1 = new Employee("Shubham", 25000, 10);
            Employee emp2 = new Employee("Shubham", 123465);
            Employee emp3 = new Employee("Shubham");
            Employee emp4 = new Employee();

            Console.WriteLine("1=" + emp1.EmpNO);
            Console.WriteLine("2=" + emp2.EmpNO);
            Console.WriteLine("3=" + emp3.EmpNO);
            Console.WriteLine("4=" + emp4.EmpNO);

            Console.WriteLine("name = " + emp1.Name);
            Console.WriteLine("deptno = " + emp1.DeptNO);
            Console.WriteLine("basic = " + emp1.Basic);
            Console.WriteLine("net sal = " + emp1.GetNetSalary());

            Console.ReadLine();

        }
    }
    class Employee
    {
        private decimal basic;
        private short deptNo;
        private string name;
        private int empNo=0;
        public static int count = 0;

        public decimal Basic
        {
            set
            {
                if (basic > 10000 && basic < 80000)
                    basic = value;
                Console.WriteLine("Basic Salary must be in range 10000-80000");
            }
            get { return basic; }
        }

        
        public short DeptNO
        {
            set
            {
                if (deptNo > 0)
                    deptNo = value;
                Console.WriteLine("Dept no is invalid must be > 0");
            }
            get { return deptNo; }
        }

       
        public string Name
        {
            get { return name; }
            set 
            {
                if (value != null)
                    name = value;
                Console.WriteLine("Name should not be null");
                return;
            }
        }
  //      private int empNo = 0;
        public int EmpNO
        {
            set { empNo = value; }
            get { return empNo; }
        }

   
        public decimal GetNetSalary()
        {
            return basic + (basic * 10);
        }

        
        public Employee(string name=null, decimal basic=0, short deptNo=0)
        {
            Employee.count++;
            empNo = Employee.count;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
        }
       
    }
}
