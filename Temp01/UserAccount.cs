using System;
using System.Collections.Generic;
using System.Text;

namespace Temp01 {
    class UserAccount {
        public string AccountName { get; set; }
        public string Password { get; set; }
        public int Money { get; set; }

        public UserAccount(string accountName, string password, int money) {
            AccountName = accountName;
            Password = password;
            Money = money;
        }
    }
}
