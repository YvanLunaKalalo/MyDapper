using Microsoft.AspNetCore.Mvc;
using MyDapper.Model;
using MyDapper.Service;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : Controller
    {
        [HttpPost]
        public bool AddCourse(CourseModel course)
        {
            CourseService courseServices = new CourseService();
            return courseServices.AddCourse(course);
        }
    }
}
