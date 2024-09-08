using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Model
{
    [Table("Course")]
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }
        public string Course_Name { get; set; }
        public string Description { get; set; }
    }
}
