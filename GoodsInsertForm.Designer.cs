namespace CourseWorkApplication
{
    partial class GoodsInsertForm
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
            this.goodsTableAdapter1 = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goodsTableAdapter();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.goodstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.manufacturerTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.manufacturerTableAdapter();
            this.goods_typesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goods_typesTableAdapter();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // goodsTableAdapter1
            // 
            this.goodsTableAdapter1.ClearBeforeFill = true;
            // 
            // articleTextBox
            // 
            this.articleTextBox.Location = new System.Drawing.Point(111, 12);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(100, 20);
            this.articleTextBox.TabIndex = 0;
            this.articleTextBox.TextChanged += new System.EventHandler(this.articleTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(111, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(101, 20);
            this.nameTextBox.TabIndex = 1;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerComboBox.DisplayMember = "name";
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(111, 64);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(101, 21);
            this.manufacturerComboBox.TabIndex = 2;
            this.manufacturerComboBox.SelectedIndexChanged += new System.EventHandler(this.manufacturerComboBox_SelectedIndexChanged);
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "manufacturer";
            this.manufacturerBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // airsoftDBDataSet
            // 
            this.airsoftDBDataSet.DataSetName = "AirsoftDBDataSet";
            this.airsoftDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // typesComboBox
            // 
            this.typesComboBox.DataSource = this.goodstypesBindingSource;
            this.typesComboBox.DisplayMember = "type";
            this.typesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Location = new System.Drawing.Point(111, 91);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(101, 21);
            this.typesComboBox.TabIndex = 3;
            this.typesComboBox.SelectedIndexChanged += new System.EventHandler(this.typesComboBox_SelectedIndexChanged);
            // 
            // goodstypesBindingSource
            // 
            this.goodstypesBindingSource.DataMember = "goods_types";
            this.goodstypesBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(112, 118);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(99, 20);
            this.priceTextBox.TabIndex = 4;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(112, 144);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 5;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 179);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 44);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Додати товар";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(136, 179);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 44);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Вихід";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // goods_typesTableAdapter
            // 
            this.goods_typesTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Кількість";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ціна";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Виробник";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Назва";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Артикул";
            // 
            // GoodsInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 235);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typesComboBox);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.articleTextBox);
            this.Name = "GoodsInsertForm";
            this.Text = "Додати товар";
            this.Load += new System.EventHandler(this.GoodsInsertForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AirsoftDBDataSetTableAdapters.goodsTableAdapter goodsTableAdapter1;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button cancelButton;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private AirsoftDBDataSetTableAdapters.manufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource goodstypesBindingSource;
        private AirsoftDBDataSetTableAdapters.goods_typesTableAdapter goods_typesTableAdapter;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}