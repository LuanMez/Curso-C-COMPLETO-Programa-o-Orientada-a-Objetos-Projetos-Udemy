﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseEnum.Entities
{
    class Department
    {
        public string Name { get; set; } = string.Empty;

        public Department() {
        }

        public Department(string name) {
            Name = name;
        }
    }
}
