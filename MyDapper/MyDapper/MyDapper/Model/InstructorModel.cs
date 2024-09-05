﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Model
{
    [Table("Instructor")]
    public class InstructorModel
    {
        [Key]
        [Column("InstructorId")]
        public int Id { get; set; }
        [Column("First_Name")]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        public string LastName { get; set; }
    }
}
