using MyDapper.Model;
using MyDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Service
{
    public class InstructorService
    {
        InstructorRepository instructorRepository;

        public InstructorModel GetInstructorById(int id)
        {
            instructorRepository = new InstructorRepository();
            return instructorRepository.GetbyId(id);
        }
        public bool AddInstructor(InstructorModel instructor)
        {
            instructorRepository = new InstructorRepository();
            return instructorRepository.Add(instructor);
        }
    }
}
