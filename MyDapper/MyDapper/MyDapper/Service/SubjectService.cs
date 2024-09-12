using MyDapper.Model;
using MyDapper.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Service
{
    public class SubjectService
    {
        SubjectRepository subjectRepository;
        public SubjectModel GetSubjectById(int id)
        {
            subjectRepository = new SubjectRepository();
            return subjectRepository.GetbyId(id);
        }
        public bool AddSubject(SubjectModel subject)
        {
            subjectRepository = new SubjectRepository();
            return subjectRepository.Add(subject);
        }
    }
}
