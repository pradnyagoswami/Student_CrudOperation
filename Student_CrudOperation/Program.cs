using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_CrudOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int no = 0;
            Studentcrud crud=new Studentcrud();
            do
            {
                Console.WriteLine("1.Enter student list");
                Console.WriteLine("2.Get Student By Roll Number");
                Console.WriteLine("3.Add Student");
                Console.WriteLine("4.Update Student");
                Console.WriteLine("5.Delete Student");

                Console.WriteLine("Select option");
                int option=Convert.ToInt32(Console.ReadLine());

                switch (option)
                {

                    case 1:
                        List<Student> list = crud.GetStudent();
                        Console.WriteLine("RollNo,Name,Percentage,ClgName");
                        foreach (Student student in list)
                        {

                            Console.WriteLine($"{student.rollno},{student.Name},{student.percentage},{student.clgname}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter student Rollno");
                        int rollno=Convert.ToInt32(Console.ReadLine());
                        Student s=crud.GetStudentByRollNo(rollno);
                        Console.WriteLine("RollNo,Name,Percentage,ClgName");
                        Console.WriteLine($"{s.rollno},{s.Name},{s.percentage},{s.clgname}");
                        break;
                    case 3:
                        Student s1 = new Student();
                        Console.WriteLine("Enter student Rollno you want to ADD");
                        s1.rollno=Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student Name");
                        s1.Name=Console.ReadLine();
                        Console.WriteLine("Enter Student percentage");
                        s1.percentage=Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter clg name");
                        s1.clgname=Console.ReadLine();
                        crud.AddStudent(s1);
                        Console.WriteLine("Employee Details saved");
                        break;
                    case 4:
                        Student s2 = new Student();
                        Console.WriteLine("Enter student Rollno you want to update");
                        s2.rollno = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter student Name");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter Student percentage");
                        s2.percentage = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter clg name");
                        s2.clgname = Console.ReadLine();
                        crud.UpdateStudent(s2);
                        Console.WriteLine("Employee Details Updated");
                        break;
                    case 5:
                        Console.WriteLine("Enter rollno you want to delete");
                        int rollno1=Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(rollno1);
                        Console.WriteLine($"{rollno1} Deleted");
                        break;

                
                }
                Console.WriteLine("Press 1 for continue..");
                no=Convert.ToInt32(Console.ReadLine());

            }
            while (no == 1);




        }
    }
}
