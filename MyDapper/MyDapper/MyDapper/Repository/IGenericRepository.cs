using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetbyId(int id);
        IEnumerable<T> GetAll();
        bool Add(T entity);
        bool Update(T entity);
        public bool Delete(T entity);
    }
}
