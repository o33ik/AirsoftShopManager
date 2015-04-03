namespace CourseWorkApplication
{
    partial class HeadOfStaffForm
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
            this.exitButton = new System.Windows.Forms.Button();
            this.applicationsFormLoadButton = new System.Windows.Forms.Button();
            this.ordersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(188, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(82, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // applicationsFormLoadButton
            // 
            this.applicationsFormLoadButton.Location = new System.Drawing.Point(100, 12);
            this.applicationsFormLoadButton.Name = "applicationsFormLoadButton";
            this.applicationsFormLoadButton.Size = new System.Drawing.Size(82, 23);
            this.applicationsFormLoadButton.TabIndex = 4;
            this.applicationsFormLoadButton.Text = "Заявки";
            this.applicationsFormLoadButton.UseVisualStyleBackColor = true;
            this.applicationsFormLoadButton.Click += new System.EventHandler(this.applicationsFormLoadButton_Click);
            // 
            // ordersButton
            // 
            this.ordersButton.Location = new System.Drawing.Point(12, 12);
            this.ordersButton.Name = "ordersButton";
            this.ordersButton.Size = new System.Drawing.Size(82, 23);
            this.ordersButton.TabIndex = 5;
            this.ordersButton.Text = "Замовлення";
            this.ordersButton.UseVisualStyleBackColor = true;
            this.ordersButton.Click += new System.EventHandler(this.ordersButton_Click);
            // 
            // HeadOfStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 45);
            this.Controls.Add(this.ordersButton);
            this.Controls.Add(this.applicationsFormLoadButton);
            this.Controls.Add(this.exitButton);
            this.Name = "HeadOfStaffForm";
            this.Text = "Завідуючий складом";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button applicationsFormLoadButton;
        private System.Windows.Forms.Button ordersButton;
    }
}