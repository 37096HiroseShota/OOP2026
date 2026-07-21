using System;
using System.Collections.Generic;
using System.Text;

namespace Temp01 {
    class UserAccount(string accountName, string password, int money) {
        public string AccountName { get; set; } = accountName;
        public string Password { get; set; } = password;
        public int Money { get; set; } = money;
    }
}
