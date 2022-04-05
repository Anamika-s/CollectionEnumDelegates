using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{
    class StudentMain
    { 
        static void Main()
        {// Arrays / Not rec
         //Student[] list = new Student[10];

            // Non generic collection / Not rec
            //ArrayList list = new ArrayList();
            //list.Add(new Student() { RollNo = 1, Name = "Deepak" });
            //list.Add(1);

            // generic collection / Not rec
            //List<Student> list = new List<Student>();
            //list.Add(new Student() { });
            //list.Add(1);

            //List<Student> list = new List<Student>();
            //list.Add(new Student() { RollNo = 1, Name = "A", Dob = Convert.ToDateTime("12/12/2002"), Marks = 90 });

            //list.Add(new Student() { RollNo = 2, Name = "A", Dob = Convert.ToDateTime("12/12/2002"), Marks = 90 });

            //list.Add(new Student() { RollNo = 3, Name = "A", Dob = Convert.ToDateTime("12/12/2002"), Marks = 90 });

            // Collection Initializer

            List<Student> list = new List<Student>()
            {
               new Student() { RollNo = 1, Name = "A", Dob = Convert.ToDateTime("12/12/2002"), Marks = 90 },

                new Student() { RollNo = 2, Name = "A", Dob = Convert.ToDateTime("12/12/2002"), Marks = 90 },

                new Student() { RollNo = 3, Name = "A", Dob = Convert.ToDateTime("12/12/2002"), Marks = 90 }


            };
            foreach(Student student in list)
            {
                Console.WriteLine(student.RollNo + " "+ student.Name + " " + student.Dob + " " + student.Marks);
            }


        }
    }
}
