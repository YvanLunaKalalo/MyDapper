using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Model
{
    [Table("Subject")]
    public class SubjectModel
    {
        [Key]
        [Column("SubjectId")]
        public int Id { get; set; }
        [Column("SubjectName")]
        public string SubjectName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
    }
}
