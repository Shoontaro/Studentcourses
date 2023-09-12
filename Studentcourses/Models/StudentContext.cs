using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Studentcourses.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Cours> Courses { get; set; }
    }

    public class CourseDbInitializer : DropCreateDatabaseAlways<StudentContext> { //Класс инициализации данных для дб
        protected override void Seed(StudentContext context) {
            Student s1 = new Student { Id = 1, Name = "Tom", Surname = "Test" };
            Student s2 = new Student { Id = 2, Name = "Jim", Surname = "Test" };
            Student s3 = new Student { Id = 3, Name = "John", Surname = "Test" };
            Student s4 = new Student { Id = 4, Name = "Mike", Surname = "Test" };

            context.Students.Add(s1);
            context.Students.Add(s2);
            context.Students.Add(s3);
            context.Students.Add(s4);

            Cours c1 = new Cours
            {
                Id = 1,
                Name = "Test cours 1",
                Students = new List<Student>() { s1, s2, s3 }
            };

            Cours c2 = new Cours
            {
                Id = 2,
                Name = "Test cours 2",
                Students = new List<Student>() { s2, s3, s4 }
            };

            Cours c3 = new Cours
            {
                Id = 3,
                Name = "Test cours 3",
                Students = new List<Student>() { s1, s4 }
            };

            

            context.Courses.Add(c1);
            context.Courses.Add(c2);
            context.Courses.Add(c3);
        }    
    }
}