namespace Section01 {
    public partial class Form1 : Form {
        private int count { get; set; }
        public Form1() {
            InitializeComponent();
            tbOutput.Text = $"{nudNum1.Value}";
            label3.Text = $"{DateTime.Now}";
        }

        private void button1_Click(object sender, EventArgs e) {
            tbOutput.Text = (nudNum1.Value + nudNum2.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e) {
            count++;
            label2.Text = $"ÉNÉäÉbÉNêî:{count}";
        }

        private void label3_Click(object sender, EventArgs e) {
            label3.Text = $"{DateTime.Now}";
        }

        private void nudNum1_ValueChanged(object sender, EventArgs e) {
            tbOutput.Text = $"{nudNum1.Value}";
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e) {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            ofdOpen.ShowDialog();
            pbPic.ImageLocation = ofdOpen.FileName;
        }
    }
}
