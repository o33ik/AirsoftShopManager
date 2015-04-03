namespace CourseWorkApplication
{
    partial class ApplicationForm
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
            this.applicationsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.implementationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extendedapplicationsviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extendedapplicationsviewextendedgoodswappIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addAppButton = new System.Windows.Forms.Button();
            this.implementAppButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteAppButton = new System.Windows.Forms.Button();
            this._IDLabel = new System.Windows.Forms.Label();
            this.extended_applications_viewTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.extended_applications_viewTableAdapter();
            this.extendedgoods_w_appIDTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.extendedgoods_w_appIDTableAdapter();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedapplicationsviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedapplicationsviewextendedgoodswappIDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // applicationsDataGridView
            // 
            this.applicationsDataGridView.AutoGenerateColumns = false;
            this.applicationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.applicationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.implementationdateDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.applicationsDataGridView.DataSource = this.extendedapplicationsviewBindingSource;
            this.applicationsDataGridView.Location = new System.Drawing.Point(12, 12);
            this.applicationsDataGridView.Name = "applicationsDataGridView";
            this.applicationsDataGridView.ReadOnly = true;
            this.applicationsDataGridView.Size = new System.Drawing.Size(647, 150);
            this.applicationsDataGridView.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Виробник";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Менеджер";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // creationdateDataGridViewTextBoxColumn
            // 
            this.creationdateDataGridViewTextBoxColumn.DataPropertyName = "creation_date";
            this.creationdateDataGridViewTextBoxColumn.HeaderText = "Дата створення";
            this.creationdateDataGridViewTextBoxColumn.Name = "creationdateDataGridViewTextBoxColumn";
            this.creationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // implementationdateDataGridViewTextBoxColumn
            // 
            this.implementationdateDataGridViewTextBoxColumn.DataPropertyName = "implementation_date";
            this.implementationdateDataGridViewTextBoxColumn.HeaderText = "Дата виконання";
            this.implementationdateDataGridViewTextBoxColumn.Name = "implementationdateDataGridViewTextBoxColumn";
            this.implementationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.FalseValue = "Не виконано";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Статус заявки";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.statusDataGridViewCheckBoxColumn.TrueValue = "Виконано";
            // 
            // extendedapplicationsviewBindingSource
            // 
            this.extendedapplicationsviewBindingSource.DataMember = "extended_applications_view";
            this.extendedapplicationsviewBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // airsoftDBDataSet
            // 
            this.airsoftDBDataSet.DataSetName = "AirsoftDBDataSet";
            this.airsoftDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.AutoGenerateColumns = false;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.numberDataGridViewTextBoxColumn});
            this.goodsDataGridView.DataSource = this.extendedapplicationsviewextendedgoodswappIDBindingSource;
            this.goodsDataGridView.Location = new System.Drawing.Point(12, 174);
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.ReadOnly = true;
            this.goodsDataGridView.Size = new System.Drawing.Size(647, 150);
            this.goodsDataGridView.TabIndex = 1;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // extendedapplicationsviewextendedgoodswappIDBindingSource
            // 
            this.extendedapplicationsviewextendedgoodswappIDBindingSource.DataMember = "extended_applications_view_extendedgoods_w_appID";
            this.extendedapplicationsviewextendedgoodswappIDBindingSource.DataSource = this.extendedapplicationsviewBindingSource;
            // 
            // addAppButton
            // 
            this.addAppButton.Location = new System.Drawing.Point(38, 343);
            this.addAppButton.Name = "addAppButton";
            this.addAppButton.Size = new System.Drawing.Size(86, 34);
            this.addAppButton.TabIndex = 3;
            this.addAppButton.Text = "Створити заявку";
            this.addAppButton.UseVisualStyleBackColor = true;
            this.addAppButton.Click += new System.EventHandler(this.addAppButton_Click);
            // 
            // implementAppButton
            // 
            this.implementAppButton.Location = new System.Drawing.Point(38, 343);
            this.implementAppButton.Name = "implementAppButton";
            this.implementAppButton.Size = new System.Drawing.Size(86, 34);
            this.implementAppButton.TabIndex = 4;
            this.implementAppButton.Text = "Підтвердити надходження";
            this.implementAppButton.UseVisualStyleBackColor = true;
            this.implementAppButton.Click += new System.EventHandler(this.implementAppButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(548, 343);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(86, 34);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteAppButton
            // 
            this.deleteAppButton.Location = new System.Drawing.Point(146, 343);
            this.deleteAppButton.Name = "deleteAppButton";
            this.deleteAppButton.Size = new System.Drawing.Size(86, 34);
            this.deleteAppButton.TabIndex = 6;
            this.deleteAppButton.Text = "Видалити заявку";
            this.deleteAppButton.UseVisualStyleBackColor = true;
            this.deleteAppButton.Click += new System.EventHandler(this.deleteAppButton_Click);
            // 
            // _IDLabel
            // 
            this._IDLabel.AutoSize = true;
            this._IDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extendedapplicationsviewBindingSource, "id", true));
            this._IDLabel.Location = new System.Drawing.Point(35, 227);
            this._IDLabel.Name = "_IDLabel";
            this._IDLabel.Size = new System.Drawing.Size(0, 13);
            this._IDLabel.TabIndex = 7;
            // 
            // extended_applications_viewTableAdapter
            // 
            this.extended_applications_viewTableAdapter.ClearBeforeFill = true;
            // 
            // extendedgoods_w_appIDTableAdapter
            // 
            this.extendedgoods_w_appIDTableAdapter.ClearBeforeFill = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.extendedapplicationsviewBindingSource, "status", true));
            this.statusLabel.Location = new System.Drawing.Point(52, 272);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 8;
            this.statusLabel.Text = "label1";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 387);
            this.Controls.Add(this.goodsDataGridView);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this._IDLabel);
            this.Controls.Add(this.deleteAppButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.implementAppButton);
            this.Controls.Add(this.addAppButton);
            this.Controls.Add(this.applicationsDataGridView);
            this.Name = "ApplicationForm";
            this.Text = "Заявки";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.applicationsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedapplicationsviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.extendedapplicationsviewextendedgoodswappIDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView applicationsDataGridView;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource extendedapplicationsviewBindingSource;
        private AirsoftDBDataSetTableAdapters.extended_applications_viewTableAdapter extended_applications_viewTableAdapter;
        private System.Windows.Forms.BindingSource extendedapplicationsviewextendedgoodswappIDBindingSource;
        private AirsoftDBDataSetTableAdapters.extendedgoods_w_appIDTableAdapter extendedgoods_w_appIDTableAdapter;
        private System.Windows.Forms.Button addAppButton;
        private System.Windows.Forms.Button implementAppButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteAppButton;
        private System.Windows.Forms.Label _IDLabel;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn implementationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label statusLabel;

    }
}