using System.ComponentModel;
using System.Diagnostics.Metrics;
using static CarReportSystem.CarReport;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        public Form1() {
            InitializeComponent();
            dgvRecords.DataSource = listCarReports;
        }

        //追加ボタンイベントハンドラ
        private void btAddRecord_Click(object sender, EventArgs e) {
            tsslbMessage.Text = String.Empty;

            //記録者か車名が未入力だった場合は追加しない
            if (String.IsNullOrWhiteSpace(cbAuthor.Text) || String.IsNullOrWhiteSpace(cbCarName.Text)) {
                tsslbMessage.Text = "記録者、または車名が未入力です";
                return;
            }

            var carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Meker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);

            ImputItemsALLClear();   //入力項目の全クリア
        }

        private MakerGroup GetRadioButtonMaker() {
            if (rbToyota.Checked) {
                return MakerGroup.トヨタ;
            }

            if (rbNissan.Checked) {
                return MakerGroup.日産;
            }

            if (rbHonda.Checked) {
                return MakerGroup.ホンダ;
            }

            if (rbSubaru.Checked) {
                return MakerGroup.スバル;
            }

            if (rbImport.Checked) {
                return MakerGroup.輸入車;
            }

            return MakerGroup.その他;
        }

        private void btOpenPicture_Click(object sender, EventArgs e) {
            if (ofdPicFileOpen.ShowDialog() == DialogResult.OK) {
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
            }
        }

        private void btDeletePicture_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void btNewInput_Click(object sender, EventArgs e) {
            ImputItemsALLClear();
        }

        private void ImputItemsALLClear() {
            dtpDate.Value = DateTime.Today;
            cbAuthor.Text = String.Empty;
            rbOther.Checked = true;
            cbCarName.Text = String.Empty;
            tbReport.Text = String.Empty;
            pbPicture.Image = null;
        }

        private void dgvRecords_Click(object sender, EventArgs e) {
            dtpDate.Value = (DateTime)dgvRecords.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvRecords.CurrentRow.Cells["Author"].Value;

            cbCarName.Text = (string)dgvRecords.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvRecords.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvRecords.CurrentRow.Cells["Picture"].Value;
        }
    }
}