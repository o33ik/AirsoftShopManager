namespace CourseWorkApplication
{
    partial class GoodsUpdateForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.goodstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.articleComboBox = new System.Windows.Forms.ComboBox();
            this.goodsTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goodsTableAdapter();
            this.manufacturerTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.manufacturerTableAdapter();
            this.goods_typesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goods_typesTableAdapter();
            this.extendedGoodsViewTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.extendedGoodsViewTableAdapter();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(117, 198);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 38);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Вихід";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(9, 198);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 38);
            this.updateButton.TabIndex = 14;
            this.updateButton.Text = "Оновити інформацію";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "number", true));
            this.numberTextBox.Location = new System.Drawing.Point(106, 150);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 13;
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
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(106, 124);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(99, 20);
            this.priceTextBox.TabIndex = 12;
            // 
            // typesComboBox
            // 
            this.typesComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodstypesBindingSource, "type", true));
            this.typesComboBox.DataSource = this.goodstypesBindingSource;
            this.typesComboBox.DisplayMember = "type";
            this.typesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Location = new System.Drawing.Point(105, 97);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(101, 21);
            this.typesComboBox.TabIndex = 11;
            // 
            // goodstypesBindingSource
            // 
            this.goodstypesBindingSource.DataMember = "goods_types";
            this.goodstypesBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.manufacturerBindingSource, "name", true));
            this.manufacturerComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerComboBox.DisplayMember = "name";
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(105, 70);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(101, 21);
            this.manufacturerComboBox.TabIndex = 10;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "manufacturer";
            this.manufacturerBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.goodsBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(105, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(101, 20);
            this.nameTextBox.TabIndex = 9;
            // 
            // articleComboBox
            // 
            this.articleComboBox.DataSource = this.goodsBindingSource;
            this.articleComboBox.DisplayMember = "article";
            this.articleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.articleComboBox.FormattingEnabled = true;
            this.articleComboBox.Location = new System.Drawing.Point(106, 17);
            this.articleComboBox.Name = "articleComboBox";
            this.articleComboBox.Size = new System.Drawing.Size(101, 21);
            this.articleComboBox.TabIndex = 16;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // goods_typesTableAdapter
            // 
            this.goods_typesTableAdapter.ClearBeforeFill = true;
            // 
            // extendedGoodsViewTableAdapter
            // 
            this.extendedGoodsViewTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Артикул";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Виробник";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ціна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Кількість";
            // 
            // GoodsUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 262);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.typesComboBox);
            this.Controls.Add(this.manufacturerComboBox);
            this.Controls.Add(this.nameTextBox);
            this.Name = "GoodsUpdateForm";
            this.Text = "Редагувати товар";
            this.Load += new System.EventHandler(this.GoodsUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.ComboBox articleComboBox;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private AirsoftDBDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private AirsoftDBDataSetTableAdapters.manufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource goodstypesBindingSource;
        private AirsoftDBDataSetTableAdapters.goods_typesTableAdapter goods_typesTableAdapter;
        private AirsoftDBDataSetTableAdapters.extendedGoodsViewTableAdapter extendedGoodsViewTableAdapter;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}