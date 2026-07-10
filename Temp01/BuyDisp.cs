using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Temp01 {
    public partial class BuyDisp : Form {
        private Shop shop;
        private Item selectedItem;
        private UserAccount userAccount;

        public BuyDisp() {
            InitializeComponent();
        }

        private void BuyDisp_Load(object sender, EventArgs e) {
            shop = new Shop(@"Item.csv");

            //仮実装（ログイン機能実装後に変更）
            userAccount = new UserAccount("temp", "temp", 1000);

            selectedItem = shop.SaleItems[0];

            quantityNumericUpDown.Minimum = 1;
            quantityNumericUpDown.Maximum = selectedItem.Stock;
            quantityNumericUpDown.Value = 1;

            itemNameTextBox.Text = selectedItem.Name;
            itemStockTextBox.Text = $"{selectedItem.Stock}";
            moneyTextBox.Text = $"{userAccount.Money}";
        }

        private void buyButton_Click(object sender, EventArgs e) {
            int count = (int)quantityNumericUpDown.Value;

            int totalPrice = count * selectedItem.Price;

            if (userAccount.Money < totalPrice) {
                MessageBox.Show("所持金が足りません");
                return;
            }

            bool result = shop.Buy(selectedItem, count);

            if (!result) {
                MessageBox.Show("在庫が足りません");
                return;
            }

            itemStockTextBox.Text = $"{selectedItem.Stock}";

            userAccount.Money -= count * selectedItem.Price;

            moneyTextBox.Text = $"{userAccount.Money}";
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
