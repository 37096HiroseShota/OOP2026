using Microsoft.VisualBasic;
using System.Globalization;

namespace Section01 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btGet_Click(object sender, EventArgs e) {
            DateTime date = dtpDate.Value;
            tbOut.Text = date.AddDays((double)nudDay.Value).ToString();
        }

        private void btBirthCalc_Click(object sender, EventArgs e) {
            DateTime birth = dtpBirth.Value;     //生まれた日付
            DateTime today = DateTime.Today;    //今日の日付

            tbOut.Text = $"あなたは{GetAge(birth, today)}歳です";

            TimeSpan ts = today.Date - birth.Date;
            tbOut2.Text = $"生まれてから{ts.Days}日目です";

            var culture = new CultureInfo("ja-jp");
            tbOut3.Text = $"生まれた{birth.Month}月{birth.Day}日は第{NthWeek(birth)}週の" +
                $"{culture.DateTimeFormat.GetDayName(birth.DayOfWeek)}です";

            Boolean todaybirrh = false;
            int nextbirth = 0;

            if (birth.Date == today.Date) {
                tbOut4.Text = "誕生日は今日です";
                todaybirrh = true;
            } else if (birth.Day - today.Day > 0) {
                nextbirth = birth.Day - today.Day;
            } else {
                nextbirth = birth.Day + 365 - today.Day;
            }

            if (!todaybirrh) {
                if (DateTime.IsLeapYear(today.Year)) {
                    nextbirth += 1;
                }
                tbOut4.Text = $"次の誕生日まで{nextbirth}日です";
            }

            tbOut5.Text = "今年";
            tbOut5.Text = $"{NthWeek(today)}";
        }

        //年齢を求めるメソッド
        private int GetAge(DateTime birthday, DateTime targetDay) {
            var age = targetDay.Year - birthday.Year;
            if (targetDay < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }

        //指定した日が第何週か求める
        static int NthWeek(DateTime date) {
            var firstDay = new DateTime(date.Year, date.Month, 1);
            var firstDayOfWeek = (int)(firstDay.DayOfWeek);
            return (date.Day + firstDayOfWeek - 1) / 7 + 1;
        }
    }
}
