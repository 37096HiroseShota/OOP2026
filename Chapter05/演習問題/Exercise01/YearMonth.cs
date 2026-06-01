using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise01 {
    //5.1.1
    public class YearMonth {
        public int Year { get; init; }
        public int Month { get; init; }

        //5.1.2
        public bool IS21Century { get; init; }

        public YearMonth(int year, int month) {
            Year = year;
            Month = month;
            if (Year > 2000 && Year < 2101) {
                IS21Century = true;
            }
        }

        //5.1.2
        public int AddOneMonth() {
            var yearmonth = new YearMonth(this.Year, this.Month + 1);
            if (yearmonth.Month < 13) {
                return yearmonth.Month;
            }
            return yearmonth.Month - 12;
        }
    }
}
