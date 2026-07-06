

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
            btGet = new Button();
            dtpDate = new DateTimePicker();
            tbOut = new TextBox();
            SuspendLayout();
            // 
            // btGet
            // 
            btGet.Location = new Point(230, 5);
            btGet.Name = "btGet";
            btGet.Size = new Size(93, 40);
            btGet.TabIndex = 0;
            btGet.Text = "取得";
            btGet.UseVisualStyleBackColor = true;
            btGet.Click += btGet_Click;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(12, 12);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 1;
            // 
            // tbOut
            // 
            tbOut.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            tbOut.Location = new Point(12, 76);
            tbOut.Name = "tbOut";
            tbOut.Size = new Size(200, 39);
            tbOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 573);
            Controls.Add(tbOut);
            Controls.Add(dtpDate);
            Controls.Add(btGet);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGet;
        private DateTimePicker dtpDate;
        private TextBox tbOut;
    }
}
