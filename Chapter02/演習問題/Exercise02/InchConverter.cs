using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    public static class InchConverter {
        private static readonly double ratio = 0.0254;   //定数

        //インチからメートルを求める
        public static double ToMeter(int meter) {
            return meter * ratio;
        }

        //メートルからインチを求める
        public static double FromMeter(int inch) {
            return inch / ratio;
        }
    }
}