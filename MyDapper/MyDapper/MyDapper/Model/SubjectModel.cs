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
        public int SubjectId { get; set; }
        public string Subject_Name { get; set; }
        public string Description { get; set; }
    }
}
