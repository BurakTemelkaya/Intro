using intro.DataAccess.Abstracts;
using intro.Entities;

namespace intro.Business;

public class CourseManager
{
    //dependancy injection
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        // business rules
        return _courseDal.GetAll();
    }
}
