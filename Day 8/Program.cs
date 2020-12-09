using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_Anonymous_lambda
{
    class Program
    {
        static void Main1()
        {
            //way 1 - by calling method vid class name,obj name 
            decimal x = SimpleInterest(10, 5, 2);
            Console.WriteLine("SimpleInterest = " + x);
            //way 2 - By inbuild delegate obj
            Func<decimal, decimal, decimal, decimal> o = SimpleInterest;
            Console.WriteLine("SimpleInterest = "+(o(10, 5, 2)));
            //way 3 - By Anonymous method 
            Func<decimal, decimal, decimal, decimal> o1 = delegate (decimal P, decimal N, decimal R)
               {
                   return (P * N * R) / 100;
               };
            Console.WriteLine("SimpleInterest = " + (o1(10, 5, 2))); ;
            //way 4 - by lambda method
            Func<decimal,decimal,decimal,decimal> o2 = (decimal P, decimal N, decimal R) => (P * N * R )/ 100;
            Console.WriteLine("SimpleInterest = " + (o2(10, 5, 2))); 

        }

        static void Main2()
        {
            //way - Anonymous method 
            Func<int, int, bool> o = delegate(int a,int b) {
                if (a > b)
                    return true;
                else
                    return false;
            };
            Console.WriteLine((o(10, 5)));
            Console.WriteLine();
            
            //way - lambda function
            Func<int, int, bool> o2 = (int a, int b) => a > b;
            Console.WriteLine(o2(10,15));
        }

        static void Main3()
        {
            Employee e = new Employee();
            e.NAME = "Shubham";
            e.BASIC = 10000;
            e.ID = 114;
            Func<Employee, decimal> o = emp => emp.BASIC;
            Console.WriteLine("Basic salary = "+o(e)); 

        }

        static void Main4() 
        {
            Predicate<int> o = a => (a % 2 == 0);
            Console.WriteLine(o(9));
        }

        static void Main()
        {
            Employee e = new Employee() { ID=114,NAME="Shubham",BASIC = 9000};
           
            Predicate<Employee> o = emp => emp.BASIC > 10000;
            Console.WriteLine("Salary is greater than 10000 = "+o(e));
        }
        static decimal SimpleInterest(decimal P, decimal N, decimal R)
        {
            return (P*R*N)/100;
        }
        
        //static bool IsGreater(int a, int b)
        //{
        //    if (a > b)
        //        return true;
        //    else
        //        return false;
        //}
    }
    public class Employee
    {
        public string NAME { set; get; }
        public int ID { set; get; }
        public decimal BASIC { set; get; }

        //public decimal Salary()
        //{
        //    return BASIC + 5000;
        //}
    }
}
