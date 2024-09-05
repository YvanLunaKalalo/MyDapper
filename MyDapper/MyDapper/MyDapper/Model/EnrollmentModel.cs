﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Model
{
    [Table("Enrollment")]
    public class EnrollmentModel
    {
        [Key]
        [Column("EnrollmentId")]
        public int Id { get; set; }
        [Column("Status")]
        public string Status { get; set; }
        [Column("Description")]
        public string Description { get; set; }

    }
}
