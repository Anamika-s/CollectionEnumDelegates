using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionEnumDemo
{
    class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Marks { get; set; }
        public void GetDeatils() { }
        public void DispalyDetails()
        {
            Console.Write($"RollNo is {RollNo} ");
            Console.Write($"Name is {Name} ");
            Console.Write($"Dob is {Dob} ");
            Console.Write($"Marks are {Marks} ");
        }
    }
}
