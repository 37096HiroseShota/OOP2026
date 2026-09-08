namespace CarReportSystem {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            dtpDate = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rbOther = new RadioButton();
            rbImport = new RadioButton();
            rbSubaru = new RadioButton();
            rbHonda = new RadioButton();
            rbNissan = new RadioButton();
            rbToyota = new RadioButton();
            cbAuthor = new ComboBox();
            label4 = new Label();
            cbCarName = new ComboBox();
            label5 = new Label();
            dgvRecords = new DataGridView();
            tbReport = new TextBox();
            label6 = new Label();
            btNewInput = new Button();
            label7 = new Label();
            btOpenPicture = new Button();
            btDeletePicture = new Button();
            btAddRecord = new Button();
            btModifyRecord = new Button();
            btDeleteRecord = new Button();
            pbPicture = new PictureBox();
            menuStrip1 = new MenuStrip();
            ファイルAToolStripMenuItem = new ToolStripMenuItem();
            色設定ToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            終了ToolStripMenuItem = new ToolStripMenuItem();
            ofdPicFileOpen = new OpenFileDialog();
            tsslbMessage = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            cdColor = new ColorDialog();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(48, 56);
            label1.Name = "label1";
            label1.Size = new Size(78, 41);
            label1.TabIndex = 0;
            label1.Text = "日付";
            // 
            // dtpDate
            // 
            dtpDate.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            dtpDate.Location = new Point(134, 56);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(274, 47);
            dtpDate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(29, 217);
            label2.Name = "label2";
            label2.Size = new Size(99, 41);
            label2.TabIndex = 0;
            label2.Text = "メーカー";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(21, 135);
            label3.Name = "label3";
            label3.Size = new Size(108, 41);
            label3.TabIndex = 0;
            label3.Text = "記録者";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbOther);
            groupBox1.Controls.Add(rbImport);
            groupBox1.Controls.Add(rbSubaru);
            groupBox1.Controls.Add(rbHonda);
            groupBox1.Controls.Add(rbNissan);
            groupBox1.Controls.Add(rbToyota);
            groupBox1.Location = new Point(134, 196);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(474, 71);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // rbOther
            // 
            rbOther.AutoSize = true;
            rbOther.Font = new Font("Yu Gothic UI", 11.25F);
            rbOther.Location = new Point(389, 25);
            rbOther.Margin = new Padding(3, 4, 3, 4);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(82, 29);
            rbOther.TabIndex = 0;
            rbOther.Text = "その他";
            rbOther.UseVisualStyleBackColor = true;
            // 
            // rbImport
            // 
            rbImport.AutoSize = true;
            rbImport.Font = new Font("Yu Gothic UI", 11.25F);
            rbImport.Location = new Point(299, 25);
            rbImport.Margin = new Padding(3, 4, 3, 4);
            rbImport.Name = "rbImport";
            rbImport.Size = new Size(90, 29);
            rbImport.TabIndex = 0;
            rbImport.Text = "輸入車";
            rbImport.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            rbSubaru.AutoSize = true;
            rbSubaru.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbSubaru.Location = new Point(222, 25);
            rbSubaru.Margin = new Padding(3, 4, 3, 4);
            rbSubaru.Name = "rbSubaru";
            rbSubaru.Size = new Size(78, 29);
            rbSubaru.TabIndex = 0;
            rbSubaru.Text = "スバル";
            rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            rbHonda.AutoSize = true;
            rbHonda.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbHonda.Location = new Point(145, 25);
            rbHonda.Margin = new Padding(3, 4, 3, 4);
            rbHonda.Name = "rbHonda";
            rbHonda.Size = new Size(78, 29);
            rbHonda.TabIndex = 0;
            rbHonda.Text = "ホンダ";
            rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissan
            // 
            rbNissan.AutoSize = true;
            rbNissan.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbNissan.Location = new Point(77, 25);
            rbNissan.Margin = new Padding(3, 4, 3, 4);
            rbNissan.Name = "rbNissan";
            rbNissan.Size = new Size(71, 29);
            rbNissan.TabIndex = 0;
            rbNissan.Text = "日産";
            rbNissan.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            rbToyota.AutoSize = true;
            rbToyota.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            rbToyota.Location = new Point(7, 24);
            rbToyota.Margin = new Padding(3, 4, 3, 4);
            rbToyota.Name = "rbToyota";
            rbToyota.Size = new Size(76, 32);
            rbToyota.TabIndex = 0;
            rbToyota.Text = "トヨタ";
            rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbAuthor
            // 
            cbAuthor.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Location = new Point(134, 135);
            cbAuthor.Margin = new Padding(3, 4, 3, 4);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(337, 49);
            cbAuthor.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label4.Location = new Point(48, 288);
            label4.Name = "label4";
            label4.Size = new Size(78, 41);
            label4.TabIndex = 0;
            label4.Text = "車名";
            // 
            // cbCarName
            // 
            cbCarName.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            cbCarName.FormattingEnabled = true;
            cbCarName.Location = new Point(134, 288);
            cbCarName.Margin = new Padding(3, 4, 3, 4);
            cbCarName.Name = "cbCarName";
            cbCarName.Size = new Size(274, 49);
            cbCarName.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label5.Location = new Point(24, 373);
            label5.Name = "label5";
            label5.Size = new Size(104, 41);
            label5.TabIndex = 0;
            label5.Text = "レポート";
            // 
            // dgvRecords
            // 
            dgvRecords.AllowUserToAddRows = false;
            dgvRecords.AllowUserToDeleteRows = false;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(134, 575);
            dgvRecords.Margin = new Padding(3, 4, 3, 4);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 51;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(822, 389);
            dgvRecords.TabIndex = 4;
            dgvRecords.SelectionChanged += dgvRecords_SelectionChanged;
            // 
            // tbReport
            // 
            tbReport.Location = new Point(134, 373);
            tbReport.Margin = new Padding(3, 4, 3, 4);
            tbReport.Multiline = true;
            tbReport.Name = "tbReport";
            tbReport.Size = new Size(436, 177);
            tbReport.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label6.Location = new Point(48, 575);
            label6.Name = "label6";
            label6.Size = new Size(78, 41);
            label6.TabIndex = 0;
            label6.Text = "一覧";
            // 
            // btNewInput
            // 
            btNewInput.BackColor = Color.Silver;
            btNewInput.FlatStyle = FlatStyle.Flat;
            btNewInput.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btNewInput.Location = new Point(433, 53);
            btNewInput.Margin = new Padding(3, 4, 3, 4);
            btNewInput.Name = "btNewInput";
            btNewInput.Size = new Size(134, 55);
            btNewInput.TabIndex = 6;
            btNewInput.Text = "新規入力";
            btNewInput.UseVisualStyleBackColor = false;
            btNewInput.Click += btNewInput_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label7.Location = new Point(615, 63);
            label7.Name = "label7";
            label7.Size = new Size(78, 41);
            label7.TabIndex = 0;
            label7.Text = "画像";
            // 
            // btOpenPicture
            // 
            btOpenPicture.FlatStyle = FlatStyle.Flat;
            btOpenPicture.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btOpenPicture.Location = new Point(712, 57);
            btOpenPicture.Margin = new Padding(3, 4, 3, 4);
            btOpenPicture.Name = "btOpenPicture";
            btOpenPicture.Size = new Size(133, 51);
            btOpenPicture.TabIndex = 6;
            btOpenPicture.Text = "開く...";
            btOpenPicture.UseVisualStyleBackColor = true;
            btOpenPicture.Click += btOpenPicture_Click;
            // 
            // btDeletePicture
            // 
            btDeletePicture.FlatStyle = FlatStyle.Flat;
            btDeletePicture.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeletePicture.Location = new Point(851, 57);
            btDeletePicture.Margin = new Padding(3, 4, 3, 4);
            btDeletePicture.Name = "btDeletePicture";
            btDeletePicture.Size = new Size(104, 51);
            btDeletePicture.TabIndex = 6;
            btDeletePicture.Text = "削除";
            btDeletePicture.UseVisualStyleBackColor = true;
            btDeletePicture.Click += btDeletePicture_Click;
            // 
            // btAddRecord
            // 
            btAddRecord.BackColor = Color.PowderBlue;
            btAddRecord.FlatStyle = FlatStyle.Flat;
            btAddRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btAddRecord.Location = new Point(615, 477);
            btAddRecord.Margin = new Padding(3, 4, 3, 4);
            btAddRecord.Name = "btAddRecord";
            btAddRecord.Size = new Size(107, 75);
            btAddRecord.TabIndex = 6;
            btAddRecord.Text = "追加";
            btAddRecord.UseVisualStyleBackColor = false;
            btAddRecord.Click += btAddRecord_Click;
            // 
            // btModifyRecord
            // 
            btModifyRecord.BackColor = SystemColors.Info;
            btModifyRecord.FlatStyle = FlatStyle.Flat;
            btModifyRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btModifyRecord.Location = new Point(743, 477);
            btModifyRecord.Margin = new Padding(3, 4, 3, 4);
            btModifyRecord.Name = "btModifyRecord";
            btModifyRecord.Size = new Size(107, 75);
            btModifyRecord.TabIndex = 7;
            btModifyRecord.Text = "修正";
            btModifyRecord.UseVisualStyleBackColor = false;
            btModifyRecord.Click += btModifyRecord_Click;
            // 
            // btDeleteRecord
            // 
            btDeleteRecord.BackColor = Color.LightSalmon;
            btDeleteRecord.FlatStyle = FlatStyle.Flat;
            btDeleteRecord.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btDeleteRecord.Location = new Point(873, 477);
            btDeleteRecord.Margin = new Padding(3, 4, 3, 4);
            btDeleteRecord.Name = "btDeleteRecord";
            btDeleteRecord.Size = new Size(82, 75);
            btDeleteRecord.TabIndex = 8;
            btDeleteRecord.Text = "削除";
            btDeleteRecord.UseVisualStyleBackColor = false;
            btDeleteRecord.Click += btDeleteRecord_Click;
            // 
            // pbPicture
            // 
            pbPicture.BorderStyle = BorderStyle.FixedSingle;
            pbPicture.Location = new Point(615, 115);
            pbPicture.Margin = new Padding(3, 4, 3, 4);
            pbPicture.Name = "pbPicture";
            pbPicture.Size = new Size(340, 337);
            pbPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPicture.TabIndex = 9;
            pbPicture.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ファイルAToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(978, 30);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // ファイルAToolStripMenuItem
            // 
            ファイルAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 色設定ToolStripMenuItem, toolStripSeparator2, 終了ToolStripMenuItem });
            ファイルAToolStripMenuItem.Name = "ファイルAToolStripMenuItem";
            ファイルAToolStripMenuItem.Size = new Size(82, 24);
            ファイルAToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 色設定ToolStripMenuItem
            // 
            色設定ToolStripMenuItem.Name = "色設定ToolStripMenuItem";
            色設定ToolStripMenuItem.Size = new Size(194, 26);
            色設定ToolStripMenuItem.Text = "色設定...";
            色設定ToolStripMenuItem.Click += 色設定ToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(191, 6);
            // 
            // 終了ToolStripMenuItem
            // 
            終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            終了ToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            終了ToolStripMenuItem.Size = new Size(194, 26);
            終了ToolStripMenuItem.Text = "終了(&X)";
            終了ToolStripMenuItem.Click += 終了ToolStripMenuItem_Click;
            // 
            // tsslbMessage
            // 
            tsslbMessage.Name = "tsslbMessage";
            tsslbMessage.Size = new Size(0, 16);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslbMessage });
            statusStrip1.Location = new Point(0, 985);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(978, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 1007);
            Controls.Add(statusStrip1);
            Controls.Add(pbPicture);
            Controls.Add(btDeleteRecord);
            Controls.Add(btModifyRecord);
            Controls.Add(btDeletePicture);
            Controls.Add(btAddRecord);
            Controls.Add(btOpenPicture);
            Controls.Add(btNewInput);
            Controls.Add(tbReport);
            Controls.Add(dgvRecords);
            Controls.Add(cbCarName);
            Controls.Add(cbAuthor);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "試乗レポート管理システム";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPicture).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtpDate;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rbOther;
        private RadioButton rbImport;
        private RadioButton rbSubaru;
        private RadioButton rbHonda;
        private RadioButton rbNissan;
        private RadioButton rbToyota;
        private ComboBox cbAuthor;
        private Label label4;
        private ComboBox cbCarName;
        private Label label5;
        private DataGridView dgvRecords;
        private TextBox tbReport;
        private Label label6;
        private Button btNewInput;
        private Label label7;
        private Button btOpenPicture;
        private Button btDeletePicture;
        private Button btAddRecord;
        private Button btModifyRecord;
        private Button btDeleteRecord;
        private PictureBox pbPicture;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ファイルAToolStripMenuItem;
        private ToolStripMenuItem 色設定ToolStripMenuItem;
        private ToolStripMenuItem 終了ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private OpenFileDialog ofdPicFileOpen;
        private ToolStripStatusLabel tsslbMessage;
        private StatusStrip statusStrip1;
        private ColorDialog cdColor;
    }
}
