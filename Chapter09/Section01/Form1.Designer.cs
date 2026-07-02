namespace Section01 {
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
            Button = new Button();
            label1 = new Label();
            button2 = new Button();
            tbOutput = new TextBox();
            label2 = new Label();
            nudNum1 = new NumericUpDown();
            label3 = new Label();
            nudNum2 = new NumericUpDown();
            pbPic = new PictureBox();
            button1 = new Button();
            ofdOpen = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)nudNum1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNum2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbPic).BeginInit();
            SuspendLayout();
            // 
            // Button
            // 
            Button.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            Button.Location = new Point(54, 25);
            Button.Name = "Button";
            Button.Size = new Size(149, 85);
            Button.TabIndex = 0;
            Button.Text = "ボタン";
            Button.UseVisualStyleBackColor = true;
            Button.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label1.Location = new Point(260, 40);
            label1.Name = "label1";
            label1.Size = new Size(166, 45);
            label1.TabIndex = 1;
            label1.Text = "Chapter09";
            // 
            // button2
            // 
            button2.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button2.Location = new Point(54, 129);
            button2.Name = "button2";
            button2.Size = new Size(149, 61);
            button2.TabIndex = 2;
            button2.Text = "クリック";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbOutput
            // 
            tbOutput.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOutput.Location = new Point(20, 525);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(272, 35);
            tbOutput.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label2.Location = new Point(260, 137);
            label2.Name = "label2";
            label2.Size = new Size(167, 45);
            label2.TabIndex = 4;
            label2.Text = "クリック数:0";
            // 
            // nudNum1
            // 
            nudNum1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudNum1.Location = new Point(20, 462);
            nudNum1.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudNum1.Name = "nudNum1";
            nudNum1.Size = new Size(120, 33);
            nudNum1.TabIndex = 5;
            nudNum1.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nudNum1.ValueChanged += nudNum1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label3.Location = new Point(711, 45);
            label3.Name = "label3";
            label3.Size = new Size(75, 40);
            label3.TabIndex = 6;
            label3.Text = "日時";
            label3.Click += label3_Click;
            // 
            // nudNum2
            // 
            nudNum2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 128);
            nudNum2.Location = new Point(172, 462);
            nudNum2.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            nudNum2.Name = "nudNum2";
            nudNum2.Size = new Size(120, 33);
            nudNum2.TabIndex = 5;
            nudNum2.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nudNum2.ValueChanged += nudNum1_ValueChanged;
            // 
            // pbPic
            // 
            pbPic.BorderStyle = BorderStyle.FixedSingle;
            pbPic.Location = new Point(480, 183);
            pbPic.Name = "pbPic";
            pbPic.Size = new Size(649, 387);
            pbPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPic.TabIndex = 7;
            pbPic.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            button1.Location = new Point(283, 315);
            button1.Name = "button1";
            button1.Size = new Size(159, 77);
            button1.TabIndex = 8;
            button1.Text = "開く...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // ofdOpen
            // 
            ofdOpen.FileName = "openFileDialog1";
            ofdOpen.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 582);
            Controls.Add(button1);
            Controls.Add(pbPic);
            Controls.Add(label3);
            Controls.Add(nudNum2);
            Controls.Add(nudNum1);
            Controls.Add(label2);
            Controls.Add(tbOutput);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(Button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudNum1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNum2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button;
        private Label label1;
        private Button button2;
        private TextBox tbOutput;
        private Label label2;
        private NumericUpDown nudNum1;
        private Label label3;
        private NumericUpDown nudNum2;
        private PictureBox pbPic;
        private Button button1;
        private OpenFileDialog ofdOpen;
    }
}
