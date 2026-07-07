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
            foreach (var item in saleItem._items) {
                SaleItem1.Text = item.name;
                SaleItem2.Text = $"{item.stock}";
            }
            Shop.Buy(item, quantity.Value);
        }

        private void buyButton_Click(object sender, EventArgs e) {
            var saleItem = new Shop(@"Item.csv");
            foreach (var item in saleItem._items) {
                SaleItem1.Text = item.name;
                SaleItem2.Text = $"{item.stock}";
            }
            SaleItem2.Text = $"{int.Parse(SaleItem2.Text) - 1}";
        }
    }
}
