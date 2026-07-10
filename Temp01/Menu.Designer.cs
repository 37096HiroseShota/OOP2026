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
            depositButton = new Button();
            loginButton = new Button();
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
            // depositButton
            // 
            depositButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            depositButton.Location = new Point(327, 52);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(145, 61);
            depositButton.TabIndex = 2;
            depositButton.Text = "入金";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            loginButton.Location = new Point(708, 52);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(188, 87);
            loginButton.TabIndex = 3;
            loginButton.Text = "ログイン";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(loginButton);
            Controls.Add(depositButton);
            Controls.Add(showBuyDispButton);
            Controls.Add(endButton);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button endButton;
        private Button showBuyDispButton;
        private Button depositButton;
        private Button loginButton;
    }
}
