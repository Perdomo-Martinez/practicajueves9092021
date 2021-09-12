using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practicajueves9092021
{
    class Student
    {
        public int idStudent { get; set; }
        public string fistName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public string Nacionalidad { get; set; }
        //metodo con la colleccion de datos 
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
               new Student{ idStudent=1001, fistName="Jose", lastName="Robles", age=25, 
                   Nacionalidad = "Salvadoreño" },
               new Student{ idStudent=1002, fistName="Ana", lastName="Lopez", age=20,
               Nacionalidad = "Alemana" },
               new Student{ idStudent=1003, fistName="Rafael", lastName="Gonzalez", age=21,
               Nacionalidad = "Canadience"},
               new Student{ idStudent=1004, fistName="Alfredo", lastName="Valladares", age=23,
               Nacionalidad = "Frances"},
               new Student{ idStudent=1005, fistName="Amanda", lastName="Florez", age=22,
               Nacionalidad = "Finlandesa" },
            };
            return students; //retornamos la colleccion
        }
    }
}
