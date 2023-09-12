using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studentcourses.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual ICollection<Cours> Courses { get; set; }

        public Student() {

            Courses = new List<Cours>();

        }
    }
}