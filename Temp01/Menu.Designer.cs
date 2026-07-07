namespace Temp01
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
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
            endButton = new Button();
            showBuyDispButton = new Button();
            SuspendLayout();
            // 
            // endButton
            // 
            endButton.Font = new Font("メイリオ", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            endButton.Location = new Point(12, 147);
            endButton.Name = "endButton";
            endButton.Size = new Size(172, 94);
            endButton.TabIndex = 0;
            endButton.Text = "終了";
            endButton.UseVisualStyleBackColor = true;
            endButton.Click += endButton_Click;
            // 
            // showBuyDispButton
            // 
            showBuyDispButton.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            showBuyDispButton.Location = new Point(12, 12);
            showBuyDispButton.Name = "showBuyDispButton";
            showBuyDispButton.Size = new Size(179, 119);
            showBuyDispButton.TabIndex = 1;
            showBuyDispButton.Text = "購入";
            showBuyDispButton.UseVisualStyleBackColor = true;
            showBuyDispButton.Click += showBuyDispButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(showBuyDispButton);
            Controls.Add(endButton);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button endButton;
        private Button showBuyDispButton;
    }
}
