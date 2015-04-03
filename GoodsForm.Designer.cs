namespace CourseWorkApplication
{
    partial class GoodsForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.manufRadioButton = new System.Windows.Forms.RadioButton();
            this.typesRadioButton = new System.Windows.Forms.RadioButton();
            this.noneFilterRadioButton = new System.Windows.Forms.RadioButton();
            this.updateGoodButton = new System.Windows.Forms.Button();
            this.deleteGoodButton = new System.Windows.Forms.Button();
            this.AddGoodButton = new System.Windows.Forms.Button();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerextendedGoodsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.manufDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typesDataGridView = new System.Windows.Forms.DataGridView();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodstypesextendedGoodsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufAddButton = new System.Windows.Forms.Button();
            this.deleteManufButton = new System.Windows.Forms.Button();
            this.typeAddButton = new System.Windows.Forms.Button();
            this.deleteTypeButton = new System.Windows.Forms.Button();
            this.goods_typesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goods_typesTableAdapter();
            this.manufacturerTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.manufacturerTableAdapter();
            this.extendedGoodsViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.extendedGoodsViewTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.extendedGoodsViewTableAdapter();
            this.articleLabel = new System.Windows.Forms.Label();
            this.goodsTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goodsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerextendedGoodsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesextendedGoodsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedGoodsViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // manufRadioButton
            // 
            this.manufRadioButton.AutoSize = true;
            this.manufRadioButton.Location = new System.Drawing.Point(12, 300);
            this.manufRadioButton.Name = "manufRadioButton";
            this.manufRadioButton.Size = new System.Drawing.Size(174, 17);
            this.manufRadioButton.TabIndex = 3;
            this.manufRadioButton.TabStop = true;
            this.manufRadioButton.Text = "Фільтурувати за виробником";
            this.manufRadioButton.UseVisualStyleBackColor = true;
            this.manufRadioButton.CheckedChanged += new System.EventHandler(this.manufRadioButton_CheckedChanged);
            // 
            // typesRadioButton
            // 
            this.typesRadioButton.AutoSize = true;
            this.typesRadioButton.Location = new System.Drawing.Point(12, 323);
            this.typesRadioButton.Name = "typesRadioButton";
            this.typesRadioButton.Size = new System.Drawing.Size(138, 17);
            this.typesRadioButton.TabIndex = 4;
            this.typesRadioButton.TabStop = true;
            this.typesRadioButton.Text = "Фільтрувати за типом";
            this.typesRadioButton.UseVisualStyleBackColor = true;
            this.typesRadioButton.CheckedChanged += new System.EventHandler(this.typesRadioButton_CheckedChanged);
            // 
            // noneFilterRadioButton
            // 
            this.noneFilterRadioButton.AutoSize = true;
            this.noneFilterRadioButton.Location = new System.Drawing.Point(12, 277);
            this.noneFilterRadioButton.Name = "noneFilterRadioButton";
            this.noneFilterRadioButton.Size = new System.Drawing.Size(108, 17);
            this.noneFilterRadioButton.TabIndex = 5;
            this.noneFilterRadioButton.TabStop = true;
            this.noneFilterRadioButton.Text = "Відобразити все";
            this.noneFilterRadioButton.UseVisualStyleBackColor = true;
            this.noneFilterRadioButton.CheckedChanged += new System.EventHandler(this.noneFilterRadioButton_CheckedChanged);
            // 
            // updateGoodButton
            // 
            this.updateGoodButton.Location = new System.Drawing.Point(478, 283);
            this.updateGoodButton.Name = "updateGoodButton";
            this.updateGoodButton.Size = new System.Drawing.Size(87, 50);
            this.updateGoodButton.TabIndex = 6;
            this.updateGoodButton.Text = "Редагувати товар";
            this.updateGoodButton.UseVisualStyleBackColor = true;
            this.updateGoodButton.Click += new System.EventHandler(this.updateGoodButton_Click);
            // 
            // deleteGoodButton
            // 
            this.deleteGoodButton.Location = new System.Drawing.Point(478, 339);
            this.deleteGoodButton.Name = "deleteGoodButton";
            this.deleteGoodButton.Size = new System.Drawing.Size(87, 50);
            this.deleteGoodButton.TabIndex = 7;
            this.deleteGoodButton.Text = "Видалити товар";
            this.deleteGoodButton.UseVisualStyleBackColor = true;
            this.deleteGoodButton.Click += new System.EventHandler(this.deleteGoodButton_Click);
            // 
            // AddGoodButton
            // 
            this.AddGoodButton.Location = new System.Drawing.Point(478, 227);
            this.AddGoodButton.Name = "AddGoodButton";
            this.AddGoodButton.Size = new System.Drawing.Size(87, 50);
            this.AddGoodButton.TabIndex = 8;
            this.AddGoodButton.Text = "Додати товар";
            this.AddGoodButton.UseVisualStyleBackColor = true;
            this.AddGoodButton.Click += new System.EventHandler(this.AddGoodButton_Click);
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.AutoGenerateColumns = false;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn2,
            this.nameDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.goodsDataGridView.DataSource = this.manufacturerextendedGoodsViewBindingSource;
            this.goodsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.ReadOnly = true;
            this.goodsDataGridView.Size = new System.Drawing.Size(665, 212);
            this.goodsDataGridView.TabIndex = 9;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Виробник";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn2
            // 
            this.typeDataGridViewTextBoxColumn2.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn2.Name = "typeDataGridViewTextBoxColumn2";
            this.typeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Кількість";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerextendedGoodsViewBindingSource
            // 
            this.manufacturerextendedGoodsViewBindingSource.DataMember = "manufacturer_extendedGoodsView";
            this.manufacturerextendedGoodsViewBindingSource.DataSource = this.manufacturerBindingSource;
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
            // manufDataGridView
            // 
            this.manufDataGridView.AutoGenerateColumns = false;
            this.manufDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.manufDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn});
            this.manufDataGridView.DataSource = this.manufacturerBindingSource;
            this.manufDataGridView.Location = new System.Drawing.Point(202, 230);
            this.manufDataGridView.Name = "manufDataGridView";
            this.manufDataGridView.Size = new System.Drawing.Size(270, 150);
            this.manufDataGridView.TabIndex = 10;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // typesDataGridView
            // 
            this.typesDataGridView.AutoGenerateColumns = false;
            this.typesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.typeDataGridViewTextBoxColumn});
            this.typesDataGridView.DataSource = this.goodstypesBindingSource;
            this.typesDataGridView.Location = new System.Drawing.Point(244, 230);
            this.typesDataGridView.Name = "typesDataGridView";
            this.typesDataGridView.Size = new System.Drawing.Size(172, 150);
            this.typesDataGridView.TabIndex = 11;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // goodstypesBindingSource
            // 
            this.goodstypesBindingSource.DataMember = "goods_types";
            this.goodstypesBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // goodstypesextendedGoodsViewBindingSource
            // 
            this.goodstypesextendedGoodsViewBindingSource.DataMember = "goods_types_extendedGoodsView";
            this.goodstypesextendedGoodsViewBindingSource.DataSource = this.goodstypesBindingSource;
            // 
            // manufAddButton
            // 
            this.manufAddButton.Location = new System.Drawing.Point(590, 232);
            this.manufAddButton.Name = "manufAddButton";
            this.manufAddButton.Size = new System.Drawing.Size(87, 35);
            this.manufAddButton.TabIndex = 14;
            this.manufAddButton.Text = "Додати виробника";
            this.manufAddButton.UseVisualStyleBackColor = true;
            this.manufAddButton.Click += new System.EventHandler(this.manufAddButton_Click);
            // 
            // deleteManufButton
            // 
            this.deleteManufButton.Location = new System.Drawing.Point(590, 273);
            this.deleteManufButton.Name = "deleteManufButton";
            this.deleteManufButton.Size = new System.Drawing.Size(87, 35);
            this.deleteManufButton.TabIndex = 13;
            this.deleteManufButton.Text = "Видалити виробника";
            this.deleteManufButton.UseVisualStyleBackColor = true;
            this.deleteManufButton.Click += new System.EventHandler(this.deleteManufButton_Click);
            // 
            // typeAddButton
            // 
            this.typeAddButton.Location = new System.Drawing.Point(590, 313);
            this.typeAddButton.Name = "typeAddButton";
            this.typeAddButton.Size = new System.Drawing.Size(87, 35);
            this.typeAddButton.TabIndex = 12;
            this.typeAddButton.Text = "Додати тип товарів";
            this.typeAddButton.UseVisualStyleBackColor = true;
            this.typeAddButton.Click += new System.EventHandler(this.typeAddButton_Click);
            // 
            // deleteTypeButton
            // 
            this.deleteTypeButton.Location = new System.Drawing.Point(590, 354);
            this.deleteTypeButton.Name = "deleteTypeButton";
            this.deleteTypeButton.Size = new System.Drawing.Size(87, 35);
            this.deleteTypeButton.TabIndex = 15;
            this.deleteTypeButton.Text = "Видалити тип товару";
            this.deleteTypeButton.UseVisualStyleBackColor = true;
            this.deleteTypeButton.Click += new System.EventHandler(this.deleteTypeButton_Click);
            // 
            // goods_typesTableAdapter
            // 
            this.goods_typesTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // extendedGoodsViewBindingSource
            // 
            this.extendedGoodsViewBindingSource.DataMember = "extendedGoodsView";
            this.extendedGoodsViewBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // extendedGoodsViewTableAdapter
            // 
            this.extendedGoodsViewTableAdapter.ClearBeforeFill = true;
            // 
            // articleLabel
            // 
            this.articleLabel.AutoSize = true;
            this.articleLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extendedGoodsViewBindingSource, "article", true));
            this.articleLabel.Location = new System.Drawing.Point(40, 251);
            this.articleLabel.Name = "articleLabel";
            this.articleLabel.Size = new System.Drawing.Size(35, 13);
            this.articleLabel.TabIndex = 16;
            this.articleLabel.Text = "label1";
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // GoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 393);
            this.Controls.Add(this.articleLabel);
            this.Controls.Add(this.deleteTypeButton);
            this.Controls.Add(this.manufAddButton);
            this.Controls.Add(this.deleteManufButton);
            this.Controls.Add(this.typeAddButton);
            this.Controls.Add(this.typesDataGridView);
            this.Controls.Add(this.manufDataGridView);
            this.Controls.Add(this.goodsDataGridView);
            this.Controls.Add(this.AddGoodButton);
            this.Controls.Add(this.deleteGoodButton);
            this.Controls.Add(this.updateGoodButton);
            this.Controls.Add(this.noneFilterRadioButton);
            this.Controls.Add(this.typesRadioButton);
            this.Controls.Add(this.manufRadioButton);
            this.Name = "GoodsForm";
            this.Text = "Товари";
            this.Load += new System.EventHandler(this.GoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerextendedGoodsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesextendedGoodsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedGoodsViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton manufRadioButton;
        private System.Windows.Forms.RadioButton typesRadioButton;
        private System.Windows.Forms.RadioButton noneFilterRadioButton;
        private System.Windows.Forms.Button updateGoodButton;
        private System.Windows.Forms.Button deleteGoodButton;
        private System.Windows.Forms.Button AddGoodButton;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.DataGridView manufDataGridView;
        private System.Windows.Forms.DataGridView typesDataGridView;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource goodstypesBindingSource;
        private AirsoftDBDataSetTableAdapters.goods_typesTableAdapter goods_typesTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private AirsoftDBDataSetTableAdapters.manufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource extendedGoodsViewBindingSource;
        private AirsoftDBDataSetTableAdapters.extendedGoodsViewTableAdapter extendedGoodsViewTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerextendedGoodsViewBindingSource;
        private System.Windows.Forms.BindingSource goodstypesextendedGoodsViewBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button manufAddButton;
        private System.Windows.Forms.Button deleteManufButton;
        private System.Windows.Forms.Button typeAddButton;
        private System.Windows.Forms.Button deleteTypeButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label articleLabel;
        private AirsoftDBDataSetTableAdapters.goodsTableAdapter goodsTableAdapter;
    }
}

