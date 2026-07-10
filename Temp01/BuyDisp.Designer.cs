namespace Temp01 {
    partial class BuyDisp {
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
            buyButton = new Button();
            itemNameTextBox = new TextBox();
            itemStockTextBox = new TextBox();
            quantityNumericUpDown = new NumericUpDown();
            closeButton = new Button();
            moneyTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buyButton.Location = new Point(12, 234);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(132, 68);
            buyButton.TabIndex = 0;
            buyButton.Text = "購入";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // itemNameTextBox
            // 
            itemNameTextBox.Location = new Point(12, 39);
            itemNameTextBox.Name = "itemNameTextBox";
            itemNameTextBox.Size = new Size(125, 27);
            itemNameTextBox.TabIndex = 1;
            // 
            // itemStockTextBox
            // 
            itemStockTextBox.Location = new Point(12, 89);
            itemStockTextBox.Name = "itemStockTextBox";
            itemStockTextBox.Size = new Size(125, 27);
            itemStockTextBox.TabIndex = 1;
            // 
            // quantityNumericUpDown
            // 
            quantityNumericUpDown.Location = new Point(12, 139);
            quantityNumericUpDown.Name = "quantityNumericUpDown";
            quantityNumericUpDown.Size = new Size(150, 27);
            quantityNumericUpDown.TabIndex = 2;
            // 
            // closeButton
            // 
            closeButton.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            closeButton.Location = new Point(190, 234);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(132, 68);
            closeButton.TabIndex = 0;
            closeButton.Text = "閉じる";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // moneyTextBox
            // 
            moneyTextBox.Location = new Point(636, 39);
            moneyTextBox.Name = "moneyTextBox";
            moneyTextBox.Size = new Size(125, 27);
            moneyTextBox.TabIndex = 3;
            // 
            // BuyDisp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(moneyTextBox);
            Controls.Add(quantityNumericUpDown);
            Controls.Add(itemStockTextBox);
            Controls.Add(itemNameTextBox);
            Controls.Add(closeButton);
            Controls.Add(buyButton);
            Name = "BuyDisp";
            Text = "Form2";
            Load += BuyDisp_Load;
            ((System.ComponentModel.ISupportInitialize)quantityNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buyButton;
        private TextBox itemNameTextBox;
        private TextBox itemStockTextBox;
        private NumericUpDown quantityNumericUpDown;
        private Button closeButton;
        private TextBox moneyTextBox;
    }
}