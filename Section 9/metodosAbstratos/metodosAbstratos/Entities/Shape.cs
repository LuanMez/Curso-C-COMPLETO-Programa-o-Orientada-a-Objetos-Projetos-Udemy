﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using metodosAbstratos.Entities.Enums;

namespace metodosAbstratos.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape (Color color) {
            Color = color;
        }

        public abstract double Area(); //tem q ser abstract a classe tbm
    }
}
