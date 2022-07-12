﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    class Class
    {
        public int? ClassId { get; set; }
        public string? ClassName { get; set; }

        public Class()
        {
        }

        public Class(int? classId, string? className)
        {
            ClassId = classId;
            ClassName = className;
        }
    }
}
