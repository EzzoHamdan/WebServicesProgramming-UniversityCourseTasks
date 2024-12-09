using StudentApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace StudentApp
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StudentService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select StudentService.svc or StudentService.svc.cs at the Solution Explorer and start debugging.
    public class StudentService : IStudentService
    {
        public List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "John Doe", City = "Amman", Average = 85.5 },
            new Student { Id = 2, Name = "Ali Hassan", City = "Zarqa", Average = 90.0 },
            new Student { Id = 3, Name = "Jane Doe", City = "Irbid", Average = 78.0 },
        };
        public Student GetStudent()
        {
            return new Student() { Id = 202110239, Name = "Ezzaldeen Hamdan", Average = 3.69, Department = "CS", City = "Amman" };
        }
        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }


    }
}
