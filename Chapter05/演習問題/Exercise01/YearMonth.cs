using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01 {
    //5.1.1
    public class YearMonth(int year, int month) {
        public int Year { get; init; } = year;
        public int Month { get; init; } = month;
        public bool IS21Century { get; init; }

        public YearMonth()
    }
}
