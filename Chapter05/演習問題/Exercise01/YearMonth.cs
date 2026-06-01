using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public required int Year { get; init; }
        public required int Month { get; init; }

        //5.1.2
        public bool IS21Century { get; init; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
            if (Year > 2000 && Year < 2101) {
                IS21Century = true;
            }
        }
    }
}
