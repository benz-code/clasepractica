using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica0909
{
    class Student
    {
        public int idStudent { get; set; }
        public string firstName { get; set; }

        public string lastName { get; set; }
        public int age { get; set; }
        public string nacionalidades { get; set; }
   
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student{idStudent= 1001, firstName = "Pedro", lastName = "Hernandez", age = 25, nacionalidades="Mexicano" },
                new Student{idStudent= 1002, firstName = "Kenia", lastName = "Ventura", age = 20, nacionalidades="Salvadoreña" },
                new Student{idStudent= 1003, firstName = "Eliezer", lastName = "Diaz", age = 18, nacionalidades="Español" },
                new Student{idStudent= 1004, firstName = "Dayanna", lastName = "De la O", age = 19, nacionalidades="Italiana" },
                new Student{idStudent= 1005, firstName = "Nataly", lastName = "Ventura", age = 19, nacionalidades="Salvadoreña" },
            };
            return students; 
        }
    }
}
