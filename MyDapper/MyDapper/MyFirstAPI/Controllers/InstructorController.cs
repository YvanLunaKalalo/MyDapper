using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDapper.Model;
using MyDapper.Service;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        [HttpPost]
        public bool AddInstructor(InstructorModel instructor)
        {
            InstructorService instructorServices = new InstructorService();
            return instructorServices.AddInstructor(instructor);
        }
    }
}
