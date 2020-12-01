using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.ReadLine();
            Employee o1 = new Employee();
            Employee o2 = new Employee();
            Employee o3 = new Employee();
            Console.WriteLine(o1.Empno);    //1
            Console.WriteLine(o2.Empno);    //2
            Console.WriteLine(o3.Empno);    //3

            Console.WriteLine(o1.Deptno);   //1
            Console.WriteLine(o1.Basic);    //2000
            Console.WriteLine(o1.Name);     //name
        }
    }
    class Employee
    {
        #region properties
        private string name;
        public string Name
        {
            set
            {
                if (value == "" || Regex.IsMatch(value, @"\s+"))
                {
                    name = "employee name";
                }
            }
            get
            {
                return name;
            }
        }
        private static int empno1 = 0;
        private int empno;
        public int Empno
        {
            get
            {
                return empno;
            }
        }
        private decimal basic;
        public decimal Basic
        {

            set
            {
                if (value < 2000)
                {
                    basic = 2000;
                }
            }
            get { return basic; }
        }
        private short deptno;
        public short Deptno
        {
            set
            {
                if (value < 1)
                {
                    Console.WriteLine("assigned to dept no 1");
                    deptno = 1;
                }
            }
            get
            {
                return deptno;
            }
        }
        #endregion properties
        #region Methods
        public decimal GetNetSalary()
        {
            decimal salary = Basic + (Basic * 10);
            return salary;
        }
        #endregion Methods
        #region constructor
        /* Employee o1 = new Employee("Amol", 123465, 10);
         Employee o2 = new Employee("Amol", 123465);
         Employee o3 = new Employee("Amol");
         Employee o4 = new Employee();*/
        public Employee(string Name, decimal Basic, short DeptNo)
        {
            empno1++;
            empno = empno1;
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = Deptno;
        }
        public Employee(string Name, decimal Basic)
        {
            empno1++;
            empno = empno1;
            this.Name = Name;
            this.Basic = Basic;
            this.Deptno = 0;
        }
        public Employee(string Name)
        {
            empno1++;
            empno = empno1;
            this.Name = Name;
            this.Basic = 0;
            this.Deptno = 0;
        }
        public Employee()
        {
            empno1++;
            empno = empno1;
            this.Name = "";
            this.Basic = 0;
            this.Deptno = 0;

        }

        #endregion constructor


    }
}
