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

        //5.1.2
        //設定されている西暦が21世紀か判定する
        //Yearが2001～2100年の間ならtrue、それ以外ならfalseを返す
        //以下はメソッドの例(return true/false　は使用しないで記述するP91参照)
        public bool IS21Century => Year > 2000 && Year < 2101;

        //5.1.3
        public int AddOneMonth() {
            var yearmonth = new YearMonth(this.Year, this.Month + 1);
            if (yearmonth.Month < 13) {
                return yearmonth.Month;
            }
            return yearmonth.Month - 12;
        }

        //5.1.4
        public override string ToString() => $"{Year}年{Month}月";
    }
}
