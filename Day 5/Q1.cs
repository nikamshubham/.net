using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAssignQ1
{
    class Program
    {
        private static int flag = 0;
        static void Main(string[] args)
        {
                      
            Employee[] arr = new Employee[3];
          
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter Emp No = ");
                int eno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Emp Name = ");
                string name = Console.ReadLine();
                Console.Write("Enter Salary = ");
                decimal sal = Convert.ToDecimal(Console.ReadLine());
                arr[i] = new Employee();
                
                arr[i].empname = name;
                arr[i].empno = eno;
                arr[i].salary = sal; 
            }
            
            foreach (Employee item in arr)
            {
                item.Details();
            }

            Console.Write("Enter Emp No to be searched  - ");
            int n = Convert.ToInt32(Console.ReadLine());
            decimal dd = arr[0].salary;
           
            for (int i = 0; i < arr.Length; i++)
			{
                if(dd<arr[i].salary)
                {
                    dd = arr[i].salary; 
                }
                if(n==arr[i].empno){
                    Console.WriteLine("Employee Found");
                    Console.WriteLine("Name - "+arr[i].empname); 
                    flag = 1;
                }
                
        	}
            if(flag!=1){
                Console.WriteLine("Employee Not Found");
            }
            Console.WriteLine("====================================");
            Console.WriteLine("Max salary between all Employee = "+dd);
            
        }
    }
    public class Employee
    {
        public int empno 
        { 
            set; 
            get; 
        }
        public string empname 
        {
            set; 
            get; 
        }
        public decimal salary 
        {
            set; 
            get;
        }

        public Employee(int no=0,string name="NoName",decimal sal=0)
        {
            empno = no;
            empname = name;
            salary = sal;
            //Console.WriteLine("const");
        }

        public void Details()
        {
            Console.WriteLine("Employee No = "+empno+" ,Name = " +empname+",Salary = "+salary);
        }
    }
}
/*
  Create an array of Employee class objects
  Accept details for all Employees
  Display the Employee with highest Salary
  Accept EmpNo to be searched. Display all details for that employee.
 */
