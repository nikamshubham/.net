using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] obj = new Student[5];
    
            for (int i = 0; i < obj.Length; i++)
            {
                Console.Write("Enter Name = ");
                string name = Console.ReadLine();
                Console.Write("Enter RollNo = ");
                int rollno = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Marks = ");
                int marks = Convert.ToInt32(Console.ReadLine());
                obj[i].PName = name;
                obj[i].PRollNo = rollno;
                obj[i].PMarks = marks;
            }
            //Console.WriteLine(obj.Length);
            //Console.WriteLine(obj[0]);
            //Console.WriteLine(obj[0].PName);
            //Console.WriteLine(obj[1]);
            //Console.WriteLine(obj[1].PName);

            foreach (var item in obj)
            {
                item.Display();
            }
            
        }
    }

    public struct Student
    {
        private string name;
        private int rollno;
        private decimal marks;

        public string PName
        {
            get { return name; }
            set
            {
                if (value != null)
                    name = value;
                else Console.WriteLine("Name should not be empty");
            }
        }

        public int PRollNo
        {
            get { return rollno; }
            set
            {
                if (value > 0 || value < 139)
                    rollno = value;
                else Console.WriteLine("Incorrect Rollno");
            }
        }

        public decimal PMarks
        {
            get { return marks; }
            set
            {
                if (value > 32)
                {
                    //Console.WriteLine("Passed");
                    marks = value;
                }
                    

            }
        }

        public Student(string name="NoName",int rollno=0,decimal marks=0)
        {
            this.name = "";
            this.rollno = 0;
            this.marks = 0;
            PName = name;
            PRollNo = rollno;
            PMarks = marks;
        }
      
        public void Display()
        {
            Console.WriteLine("Name = "+ name + " ,Roll no = "+rollno+" ,Marks = "+marks);
        }

    }
}

/*
Create a struct Student with the following properties. Put in appropriate validations.
string Name
int RollNo
decimal Marks

Create a parameterized constructor.

Create an array to accept details for 5 students
 */
