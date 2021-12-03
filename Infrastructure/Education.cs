﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB.Infrastructure
{
    public class Education
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Grade { get; set; }
        public string? UniversityID { get; set; }

        public University? University { get; set; }
    }
}