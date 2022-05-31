﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab210.DAL.Entities
{
    public class StudentGrade
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public decimal Grade { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
