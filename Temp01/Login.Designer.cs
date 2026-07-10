namespace Temp01 {
    partial class Login {
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
            accountNameTextBox = new TextBox();
            passWordTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            loginButton = new Button();
            testTextBox = new TextBox();
            SuspendLayout();
            // 
            // accountNameTextBox
            // 
            accountNameTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            accountNameTextBox.Location = new Point(233, 61);
            accountNameTextBox.Name = "accountNameTextBox";
            accountNameTextBox.Size = new Size(228, 47);
            accountNameTextBox.TabIndex = 0;
            // 
            // passWordTextBox
            // 
            passWordTextBox.Font = new Font("Yu Gothic UI", 18F);
            passWordTextBox.Location = new Point(233, 134);
            passWordTextBox.Name = "passWordTextBox";
            passWordTextBox.Size = new Size(228, 47);
            passWordTextBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 18F);
            label3.Location = new Point(58, 67);
            label3.Name = "label3";
            label3.Size = new Size(158, 41);
            label3.TabIndex = 1;
            label3.Text = "アカウント名";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 18F);
            label4.Location = new Point(58, 140);
            label4.Name = "label4";
            label4.Size = new Size(127, 41);
            label4.TabIndex = 1;
            label4.Text = "パスワード";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            loginButton.Location = new Point(501, 74);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(147, 57);
            loginButton.TabIndex = 2;
            loginButton.Text = "ログイン";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // testTextBox
            // 
            testTextBox.Location = new Point(245, 255);
            testTextBox.Name = "testTextBox";
            testTextBox.Size = new Size(283, 27);
            testTextBox.TabIndex = 3;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(testTextBox);
            Controls.Add(loginButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(passWordTextBox);
            Controls.Add(accountNameTextBox);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox accountNameTextBox;
        private TextBox passWordTextBox;
        private Label label3;
        private Label label4;
        private Button loginButton;
        private TextBox testTextBox;
    }
}