using intro.DataAccess.Abstracts;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Concretes;

public class DapperCourseDal : ICourseDal
{
    List<Course> courses = new();
    public DapperCourseDal()
    {
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "C# Kursu";
        course1.Description = ".Net 8 vs...";
        course1.Price = 0;

        Course course2 = new();
        course2.Id = 1;
        course2.Name = "JAVA Kursu";
        course2.Description = "JAVA 17 vs...";
        course2.Price = 10;

        Course course3 = new();
        course3.Id = 1;
        course3.Name = "Rust Kursu";
        course3.Description = "Rust 3.01 vs...";
        course3.Price = 20;

        courses.Add(course1);
        courses.Add(course2);
        courses.Add(course3);

        courses = new List<Course> { course1, course2, course3 };
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }
}
