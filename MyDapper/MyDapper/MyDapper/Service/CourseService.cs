using MyDapper.Model;
using MyDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Service
{
    public class CourseService
    {
        CourseRepository courseRepository;

        public CourseModel GetCoursebyId(int id)
        { 
            courseRepository = new CourseRepository();
            return courseRepository.GetbyId(id);
        }
        public bool AddCourse(CourseModel course)
        {
            courseRepository = new CourseRepository();
            return courseRepository.Add(course);
        }
    }
}
