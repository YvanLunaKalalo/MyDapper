using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDapper.Model;
using MyDapper.Service;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public bool AddStudent(StudentModel student)
        {
            StudentService studentServices = new StudentService();
            return studentServices.AddStudent(student);
        }
    }
}
