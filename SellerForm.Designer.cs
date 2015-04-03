namespace CourseWorkApplication
{
    partial class SellerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.goodsButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goodsButton
            // 
            this.goodsButton.Location = new System.Drawing.Point(12, 12);
            this.goodsButton.Name = "goodsButton";
            this.goodsButton.Size = new System.Drawing.Size(82, 23);
            this.goodsButton.TabIndex = 0;
            this.goodsButton.Text = "Товари";
            this.goodsButton.UseVisualStyleBackColor = true;
            this.goodsButton.Click += new System.EventHandler(this.goodsButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(102, 12);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(82, 23);
            this.ordersButton.TabIndex = 1;
            this.ordersButton.Text = "Замовлення";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(190, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 52);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.goodsButton);
            this.Name = "SellerForm";
            this.Text = "Продавець";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goodsButton;
        private System.Windows.Forms.Button ordersButton;
        private System.Windows.Forms.Button exitButton;
    }
}