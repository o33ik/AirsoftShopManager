namespace CourseWorkApplication
{
    partial class ManufTypesInsertForm
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.insertButton = new System.Windows.Forms.Button();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(153, 11);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(119, 20);
            this.textBox.TabIndex = 0;
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(12, 65);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(77, 38);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Додати виробника";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Items.AddRange(new object[] {
            "Китай",
            "Японія",
            "Тайвань",
            "Південна Корея",
            "США",
            "Великобританія",
            "Німеччина",
            "Франція",
            "Росія",
            "Україна",
            "Білорусія",
            "Канада",
            "Мексика",
            "Польша"});
            this.countriesComboBox.Location = new System.Drawing.Point(153, 37);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(119, 21);
            this.countriesComboBox.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(183, 64);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(77, 39);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Вихід";
            this.exitButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Назва виробника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Країна";
            // 
            // ManufTypesInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 114);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.countriesComboBox);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.textBox);
            this.Name = "ManufTypesInsertForm";
            this.Text = "Додати виробника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button insertButton;
        private System.Windows.Forms.ComboBox countriesComboBox;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}