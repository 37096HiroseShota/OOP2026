namespace Temp01 {
    public partial class Menu : Form {
        public Menu() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void endButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void showBuyDispButton_Click(object sender, EventArgs e) {
            BuyDisp buyDisp = new BuyDisp();
            buyDisp.Show();
            Hide();
        }
    }
}
