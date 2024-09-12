using MyDapper.Model;
using MyDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Service
{
    public class EnrollmentService
    {
        EnrollmentRepository enrollmentRepository;

        public EnrollmentModel GetEnrollmentById(int id)
        {
            enrollmentRepository = new EnrollmentRepository();
            return enrollmentRepository.GetbyId(id);
        }
        public bool AddEnrollment(EnrollmentModel enrollment)
        {
            enrollmentRepository = new EnrollmentRepository();
            return enrollmentRepository.Add(enrollment);
        }
    }
}
