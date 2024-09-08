﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDapper.Model
{
    [Table("Student")]
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
    }
}
