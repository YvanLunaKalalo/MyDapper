using MyDapper.Model;
using MyDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Service
{
    public class StudentService
    {
        StudentRepository studentRepository;

        public StudentModel GetStudentbyId(int id)
        {
            studentRepository = new StudentRepository();
            return studentRepository.GetbyId(id);
        }

        public bool AddStudent(StudentModel student)
        {
            studentRepository = new StudentRepository();
            return studentRepository.Add(student);
        }
    }
    
}
