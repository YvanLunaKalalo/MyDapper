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
        public int EnrollmentId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

    }
}
