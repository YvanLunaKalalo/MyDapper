using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDapper.Model;
using MyDapper.Service;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnrollmentController : ControllerBase
    {
        [HttpPost]
        public bool AddEnrollment(EnrollmentModel enrollment)
        {
            EnrollmentService enrollmentServices = new EnrollmentService();
            return enrollmentServices.AddEnrollment(enrollment);
        }
    }
}
