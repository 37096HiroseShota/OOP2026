namespace Section03;

public partial class Form1 : Form {
    public Form1() {
        InitializeComponent();
    }

    private async void button1_Click(object sender, EventArgs e) {
        //Thread.Sleep(5000);
        //MessageBox.Show("Š®—¹");

        //await Task.Delay(5000);
        //MessageBox.Show("Š®—¹");

        await DoLongTimeWork();
        MessageBox.Show("Š®—¹");
    }

    private async Task DoLongTimeWork() {
        await Task.Run(() => {
            Thread.Sleep(5000);
        });
    }
}