using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Studentcourses.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public Cours(){
            Students = new List<Student>();
        }
    }
}