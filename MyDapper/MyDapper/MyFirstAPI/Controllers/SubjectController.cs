using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyDapper.Model;
using MyDapper.Service;

namespace MyFirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        [HttpPost]
        public bool AddSubject(SubjectModel subject)
        {
            SubjectService subjectServices = new SubjectService();
            return subjectServices.AddSubject(subject); 
        }
    }
}
