using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temp01 {
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e) {
            UserAccount userAccount = new UserAccount
                (accountNameTextBox.Text, passWordTextBox.Text, 0);

            string[] lines = {
                $"{accountNameTextBox.Text + passWordTextBox.Text}" 
            };

            File.WriteAllLines(@"User.csv", (lines));

            foreach (var item in File.ReadAllLines(@"User.csv")) {
                testTextBox.Text = item;
            }
            
        }
    }
}
