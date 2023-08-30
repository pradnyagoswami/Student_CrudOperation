using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_CrudOperation
{
    public class Student
    {
        public int rollno { get; set; }
        public string Name { get; set; }
        public double percentage { get; set; }

        public string clgname { get; set; }


    }
    public class Studentcrud
    {
        private List<Student> studentlist;
        public Studentcrud()
        {
            studentlist = new List<Student>()
            {
                new Student{ rollno=111  ,Name="Aditya",percentage=95.20,clgname="Dy patil"},
                new Student{ rollno=112  ,Name="Rutuja",percentage=85.30,clgname="bharati vidyapeeth"}

            };
        
        }
        public List<Student> GetStudent()
        { 
            return studentlist;

        
        }
        public Student GetStudentByRollNo(int rollno)
        {
            Student student1 = new Student();
            foreach (Student s in studentlist)
            {
                if (s.rollno == rollno)
                { 
                
                    student1= s;
                    break;
                
                }
            }
            return student1;
        
        }
        public void AddStudent(Student s)
        { 
         studentlist.Add(s);
        
        }
        public void UpdateStudent(Student s)
        { 
            foreach(Student student in studentlist) 
            {
                if (student.rollno == s.rollno)
                {
                    student.Name = s.Name;
                    student.percentage = s.percentage;
                    student.clgname = s.clgname;
                    break;
                }
            
            }

        
        }
        public void DeleteStudent(int rollno)
        {
            foreach (Student student1 in studentlist)
            {

                if (student1.rollno == rollno)
                { 
                
                studentlist.Remove(student1);
                    break;
                
                }
            
            
            
            }

        
        
        }
    
    

    
    
    
    
    
    
    
    
    }

}
