using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.DataAccess.Concretes;

public class EfCourseDal : ICourseDal
{
    List<Course> courses = new();
    public EfCourseDal()
    {
        Course course1 = new();
        course1.Id = 1;
        course1.Name = "JavaScript";
        course1.Description = "Jquery vs...";
        course1.Price = 0;

        Course course2 = new();
        course2.Id = 1;
        course2.Name = "JAVA Kursu";
        course2.Description = "JAVA 17 vs...";
        course2.Price = 10;

        Course course3 = new();
        course3.Id = 1;
        course3.Name = "Python Kursu";
        course3.Description = "Python 3.12 vs...";
        course3.Price = 20;

        courses.Add(course1);
        courses.Add(course2);
        courses.Add(course3);

        courses = new List<Course> { course1, course2, course3 };
    }
    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}
