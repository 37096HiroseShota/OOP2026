using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Temp01 {
    public partial class BuyDisp : Form {
        public BuyDisp() {
            InitializeComponent();
        }

        private void BuyDisp_Load(object sender, EventArgs e) {
                itemName.Text = item.name;
                itemStock.Text = $"{item.stock}";
            Shop.Buy(item, quantity.Value);
        }

        private void buyButton_Click(object sender, EventArgs e) {
            Shop.Buy(item, quantity.Value);
            itemStock.Text = $"{item.stock}";

            UserAccount userAccount = ("temp");
            userAccount.money -= quantity.Value * item.price;
        }
    }
}
