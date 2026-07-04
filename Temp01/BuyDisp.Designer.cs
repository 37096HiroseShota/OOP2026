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
            SaleItem1 = new TextBox();
            SaleItem2 = new TextBox();
            SuspendLayout();
            // 
            // buyButton
            // 
            buyButton.Font = new Font("Yu Gothic UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 128);
            buyButton.Location = new Point(91, 308);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(132, 68);
            buyButton.TabIndex = 0;
            buyButton.Text = "購入";
            buyButton.UseVisualStyleBackColor = true;
            buyButton.Click += buyButton_Click;
            // 
            // SaleItem1
            // 
            SaleItem1.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            SaleItem1.Location = new Point(98, 122);
            SaleItem1.Name = "SaleItem1";
            SaleItem1.Size = new Size(125, 38);
            SaleItem1.TabIndex = 1;
            // 
            // SaleItem2
            // 
            SaleItem2.Font = new Font("Yu Gothic UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 128);
            SaleItem2.Location = new Point(247, 122);
            SaleItem2.Name = "SaleItem2";
            SaleItem2.Size = new Size(125, 38);
            SaleItem2.TabIndex = 1;
            // 
            // BuyDisp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SaleItem2);
            Controls.Add(SaleItem1);
            Controls.Add(buyButton);
            Name = "BuyDisp";
            Text = "Form2";
            Load += BuyDisp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buyButton;
        private TextBox SaleItem1;
        private TextBox SaleItem2;
    }
}