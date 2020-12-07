using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArrayAssignQus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter No of Batches In CDAC Mumbai - ");
            int batch = Convert.ToInt32(Console.ReadLine());
            Student[][] s = new Student[batch][];
            //Console.WriteLine(s.Length);
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write("Enter No of Students in Batch "+i+" - ");
                int stu = Convert.ToInt32(Console.ReadLine());
                s[i] = new Student[stu];
                for (int j = 0; j < s[i].Length; j++)
                {
                    Console.WriteLine("Student Detail of {0} {1}",i,j);
                    s[i][j] = new Student();
                    Console.Write("Enter Roll Number - ");
                    int r = Convert.ToInt32(Console.ReadLine());
                    s[i][j].RollNo = r;
                    Console.Write("Enter Name - ");
                    string n = Console.ReadLine();
                    s[i][j].Name = n;
                    Console.Write("Enter CCEE Marks - ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    s[i][j].CCEEMarks = m;
                    
                }
            }

            for (int i = 0; i < s[i].Length; i++)
            {
                for (int j = 0; j < s[i].Length; j++)
                {
                    s[i][j].Display();
                }
            }

        }
    }
    class Student
    {
        public int RollNo { set; get; }
        public string Name { set; get; }
        public int CCEEMarks { set; get; }

        public Student()
        {

        }
        public Student(int rno,string name,int marks)
        {
            RollNo = rno;
            Name = name;
            CCEEMarks = marks;
        }

        public void Display()
        {
            Console.WriteLine("Roll No - "+RollNo+", Name - "+Name+", CC Marks - "+CCEEMarks);
        }

    }   
}
/*
 CDAC has certain number of batches. each batch has certain number of students
         accept number of batches from the user. for each batch accept number of students.
         create an array to store mark for each student. 
         accept the marks.
         display the marks. 
 */