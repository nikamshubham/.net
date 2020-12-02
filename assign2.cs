using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        { 
            GeneralManager o = new GeneralManager("abc", "SeniorManager", "Shubham", 60000, 1);
            Console.WriteLine(o.CalcNetSalary());
           // CEO o1 = new CEO("xyz", 60000, 2);
           // Console.WriteLine(o1.CalcNetSalary());
        }
    }
        public abstract class Employee
        {
            private string name;
            public string Name
            {
                set
                {
                    if (value != null)
                    {
                        name = value;
                    }
                    else
                        Console.WriteLine("Name should not be blank..!!");
                }
                get
                {
                    return name;
                }
            }

            private static int auto;
            private int empNo;
            public int EmpNo
            {
                get
                {
                    return empNo;
                }
            }

            private short deptNo;
            public short DeptNo
            {
                set
                {
                    if (value > 0)
                    {
                        deptNo = value;
                    }
                    else
                        Console.WriteLine("Dept No must be greater than 0");
                }
                get
                {
                    return deptNo;
                }
            }

            public decimal basic;
            public abstract decimal Basic
            { 
                set;
                get;
            }

            public abstract decimal CalcNetSalary();

            public Employee(string name,decimal basic,short deptno)
            {
                this.Name = name;
                this.Basic = basic;
                this.DeptNo = deptno;
                auto++;
                this.empNo = auto;
            }
        }

        public class Manager : Employee
        {
            private string designation;

            public string Designation
            {
                set
                {
                    if (value != null)
                    {
                        designation = value;
                    }
                    else
                        Console.WriteLine("Designation Cant Be null");
                }
                get
                {
                    return designation;
                }
            }

            public override decimal Basic
            {
                set
                {
                    basic = value;
                }
                get
                {
                    return basic;
                }
            }

            public override decimal CalcNetSalary()
            {
                decimal netSalary;
                netSalary = basic + 2000 + 1000;
                return netSalary;

            }
            public Manager(string designation, string name, decimal basic, short deptno) : base(name, basic, deptno)
            {
                this.Designation = designation;
            }

        }

        public class GeneralManager : Manager
        {
            public string Perks { set; get; }
            public GeneralManager(string perks, string designation, string name, decimal basic, short deptno) : base(designation, name, basic, deptno)
            {
                this.Perks = perks;
            }
        }
        public class CEO : Employee
        {
            public override decimal Basic
            {
                get
                {
                    return basic;
                }
                set
                {
                    basic = value;
                }
            }

            public sealed override decimal CalcNetSalary()
            {
                decimal netSal;
                netSal = Basic + 4000 + 10000 + 7000;
                return netSal;
            }
            public CEO(string name, decimal basic, short deptno) : base(name, basic, deptno)
            {

            }
        }
    
}
