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
        [Column("CourseId")]
        public int Id { get; set; }
        [Column("Course_Name")]
        public string CourseName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
    }
}
