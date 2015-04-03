namespace CourseWorkApplication
{
    partial class ManagerForm
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
            this.goodsFormLoadButton = new System.Windows.Forms.Button();
            this.applicationsFormLoadButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goodsFormLoadButton
            // 
            this.goodsFormLoadButton.Location = new System.Drawing.Point(12, 12);
            this.goodsFormLoadButton.Name = "goodsFormLoadButton";
            this.goodsFormLoadButton.Size = new System.Drawing.Size(75, 23);
            this.goodsFormLoadButton.TabIndex = 0;
            this.goodsFormLoadButton.Text = "Товари";
            this.goodsFormLoadButton.UseVisualStyleBackColor = true;
            this.goodsFormLoadButton.Click += new System.EventHandler(this.goodsFormLoadButton_Click);
            // 
            // applicationsFormLoadButton
            // 
            this.applicationsFormLoadButton.Location = new System.Drawing.Point(93, 12);
            this.applicationsFormLoadButton.Name = "applicationsFormLoadButton";
            this.applicationsFormLoadButton.Size = new System.Drawing.Size(75, 23);
            this.applicationsFormLoadButton.TabIndex = 1;
            this.applicationsFormLoadButton.Text = "Заявки";
            this.applicationsFormLoadButton.UseVisualStyleBackColor = true;
            this.applicationsFormLoadButton.Click += new System.EventHandler(this.applicationsFormLoadButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(174, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 49);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.applicationsFormLoadButton);
            this.Controls.Add(this.goodsFormLoadButton);
            this.Name = "ManagerForm";
            this.Text = "Менеджер";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goodsFormLoadButton;
        private System.Windows.Forms.Button applicationsFormLoadButton;
        private System.Windows.Forms.Button exitButton;
    }
}