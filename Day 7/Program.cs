using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample1
{
    class Program
    {
        static void Main1()      //Simple Try block with catch block
        {
            try         
            {

                int x = Convert.ToInt32(Console.ReadLine());
                doSomething(x);
                Console.WriteLine("No Exceptions");
            }
            catch
            {
                Console.WriteLine("Cannot divide by 0 ");
            }
        }
        static void Main2()      //Try with multiple catch block
        {
            Class1 obj = new Class1();
            try     
            {
                int x = Convert.ToInt32(Console.ReadLine());
                x = 100 / x;
                Console.WriteLine(x);
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exception Occur");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred ");
            }
                     
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("DBException occurred ");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine("Cannot divide by 0 "+e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        static void Main3()      //catching base class Exception
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }

            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (DivideByZeroException ex)
            //catch (ArithmeticException ex) 
            //catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void Main4()       //Finally block - clean up code
        {
            Class1 obj = new Class1();
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Try block must be followed by catch or finally block");
            }
            try
            {
                //obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException occurred");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            //catch (DivideByZeroException ex) 
            //catch (ArithmeticException ex) 
            catch (SystemException ex) //base class exception has to caught after derived class exceptions
            {
                Console.WriteLine("DBException occurred");
            }
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            //finally runs when Exception does not occur, or Exception occurs and is handled or or Exception occurs and is NOT handled 
            finally
            {
                Console.WriteLine("finally block runs anyhow");

            }
            Console.ReadLine();
        }
        static void Main()// nested try block
        {
            Class1 obj = new Class1();
            try
            {
                obj = null;
                int x = Convert.ToInt32(Console.ReadLine());
                obj.P1 = 100 / x;
                Console.WriteLine(obj.P1);
                Console.WriteLine("No Exceptions");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NRException occurred");
            }
            catch (FormatException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
            catch (DivideByZeroException ex)
            {
                try
                {
                    Console.WriteLine("FormatException occurred. Enter only numbers");
                    int x = Convert.ToInt32(Console.ReadLine());
                    obj.P1 = 100 / x;
                    Console.WriteLine(obj.P1);
                }
                catch
                {
                    Console.WriteLine("nested try catch example");
                }
                finally
                {
                    Console.WriteLine("nested try finally example");
                }
            }
           
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("DBException occurred");
            //}
            catch (Exception ex) //catches all unhandled exceptions
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("finally");

            }
            Console.ReadLine();
        }
        public static void doSomething(int x)
        {
            int res = 100 / x;
        }
    }
    public class Class1
    {
        private int p1;
        public int P1
        {
            get { return p1; }
            set
            {
                p1 = value;
            }
        }
    }
}

namespace ExceptionExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            obj.PAge = 15;
            Console.WriteLine(obj.PAge);

        }
    }

    public class Class1
    {
        private int age;
        public int PAge
        {
            set
            {
                if (value > 18)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("HEllllooooo exception occur");
                }
            }
            get { return age; }
        }
    }
}
