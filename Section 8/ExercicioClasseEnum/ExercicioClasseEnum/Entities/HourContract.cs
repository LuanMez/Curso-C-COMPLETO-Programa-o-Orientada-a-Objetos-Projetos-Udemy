﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseEnum.Entities {
    class HourContract {
        public DateTime Date { get; set; }

        public double ValuePerHour { get; set; }

        public int Hours { get; set; }

        public HourContract() {

        }

        public HourContract(DateTime date, double valuePerHour, int hours) {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double totalValue() {
            return ValuePerHour * Hours;
        }
    }
}
