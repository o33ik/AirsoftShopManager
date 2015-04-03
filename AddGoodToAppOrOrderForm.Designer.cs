namespace CourseWorkApplication
{
    partial class AddGoodToAppOrOrderForm
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
            this.components = new System.ComponentModel.Container();
            this.addGoodToButton = new System.Windows.Forms.Button();
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.storeNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.goodsTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goodsTableAdapter();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addGoodToButton
            // 
            this.addGoodToButton.Location = new System.Drawing.Point(15, 153);
            this.addGoodToButton.Name = "addGoodToButton";
            this.addGoodToButton.Size = new System.Drawing.Size(73, 42);
            this.addGoodToButton.TabIndex = 0;
            this.addGoodToButton.Text = "Додати товар";
            this.addGoodToButton.UseVisualStyleBackColor = true;
            this.addGoodToButton.Click += new System.EventHandler(this.addGoodToButton_Click);
            // 
            // articleComboBox
            // 
            this.articleComboBox.DataSource = this.goodsBindingSource;
            this.articleComboBox.DisplayMember = "article";
            this.articleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(144, 14);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(97, 21);
            this.articleComboBox.TabIndex = 1;
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "goods";
            this.goodsBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // airsoftDBDataSet
            // 
            this.airsoftDBDataSet.DataSetName = "AirsoftDBDataSet";
            this.airsoftDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(144, 41);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.ReadOnly = true;
            this.nameTextBox.Size = new System.Drawing.Size(97, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // storeNumberTextBox
            // 
            this.storeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.goodsBindingSource, "number", true));
            this.storeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "number", true));
            this.storeNumberTextBox.Location = new System.Drawing.Point(144, 67);
            this.storeNumberTextBox.Name = "storeNumberTextBox";
            this.storeNumberTextBox.ReadOnly = true;
            this.storeNumberTextBox.Size = new System.Drawing.Size(97, 20);
            this.storeNumberTextBox.TabIndex = 3;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(144, 119);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Кількість на складі";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Потрібно замовити";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(168, 153);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(73, 42);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // AddGoodToAppOrOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 202);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.storeNumberTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(this.addGoodToButton);
            this.Name = "AddGoodToAppOrOrderForm";
            this.Text = "Додати товар";
            this.Load += new System.EventHandler(this.AddGoodToAppForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addGoodToButton;
        private System.Windows.Forms.ComboBox articleComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox storeNumberTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private AirsoftDBDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button exitButton;

    }
}