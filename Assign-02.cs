using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee o1 = new Employee("Shubham", 10, 10000);
            Manager o1 = new Manager("Shubham", 2, 12000, "Sen.Managaer");
            Console.WriteLine(o1);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o1.CalcNetSalary());
            Console.ReadLine();
            CEO o2 = new CEO("ABC", 4, 25000);
            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o2.CalcNetSalary());
            Console.ReadLine();
            Employee o3 = new GeneralManager("Nikam", 3, 15000, "Gen Manager", "None");
            Console.WriteLine(o3);
            Console.WriteLine(o3.EmpNo);
            Console.WriteLine(o3.CalcNetSalary());
        }
    }

    public abstract class Employee
    {
        private string name;
        private int empno;
        private short deptno;
        public decimal basic;
        public static int count = 0;
        public string Name
        {
            set {
                if (value!=null)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Name should not empty");
                }
            }
            get { return name; }
        }

        public int EmpNo 
        {
            get{ return empno; }
        }

        public short DeptNo
        {
            set
            {
                if (value>0)
                {
                    deptno = value;
                }
                else
                {
                    Console.WriteLine("Dept no should not less than 0");
                }
            }
        }

        public abstract decimal Basic
        {
            set; 
            get;
        }

        public abstract decimal CalcNetSalary();

        public Employee(string Name="NoName", short DeptNo=10,decimal Basic=1000)
        {
            empno = ++count;
            this.Name = Name;
            this.DeptNo = DeptNo;
            this.Basic = Basic;
        }

    }

    public class Manager : Employee
    {
        
        private string designation;
        public override decimal Basic 
        {
            get { return basic; }
            set 
            {
                basic = value * 5;
            }
        }

        public string Designation
        {
            set
            {
                if (value!=null)
                {
                    designation = value;
                }
                else
                {
                    Console.WriteLine("Designation should not empty");
                }
            }
            get { return designation; }
        }
        public override decimal CalcNetSalary()
        {
            Console.WriteLine("Manager cal net salary");
            return Basic + 2000;// (Basic * 10);
            
        }

        

        public Manager(string Name="NoName", short DeptNo=2, decimal Basic=12000,string Designation="Manager") : base(Name,DeptNo,Basic)
        {
            this.Designation = Designation;
        }

    }

    public class GeneralManager : Manager
    {
        public string perks
        {
            set;get;
        }

        public override decimal CalcNetSalary()
        {
            Console.WriteLine("GeneralManager cal net salary");
            return basic + (basic * 10);
        }

        public GeneralManager(string Name="NoName", short DeptNo=3, decimal Basic=15000, string Designation="GM",string perks="undefined") : base(Name, DeptNo, Basic, Designation)
        {
            this.perks = perks;
        }

    }

    public class CEO : Employee
    {
        public CEO(string Name="NoName", short DeptNo=4, decimal Basic=20000): base(Name,DeptNo,Basic)
        {
            
        }

        public override decimal Basic 
        { 
            get { return basic; } 
            set 
            {
                basic = value * 7;
            } 
        }

        public override decimal CalcNetSalary()
        {
            Console.WriteLine("CEO cal net salary");
            return Basic + (Basic * 10);
        }
    }


}
