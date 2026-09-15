namespace CarReportSystem {
    partial class AboutApp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("メイリオ", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(288, 44);
            label1.TabIndex = 0;
            label1.Text = "CarReportSystem";
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            CloseButton.Location = new Point(329, 22);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(83, 42);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "閉じる";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // AboutApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseButton);
            Controls.Add(label1);
            Name = "AboutApp";
            Text = "AboutApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button CloseButton;
    }
}