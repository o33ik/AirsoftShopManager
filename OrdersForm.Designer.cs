namespace CourseWorkApplication
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.goodsDataGridView = new System.Windows.Forms.DataGridView();
            this.ordersextendedGoodsworderIDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.implementOrderButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this._IDLabel = new System.Windows.Forms.Label();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.sellerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.implementationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ordersTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.ordersTableAdapter();
            this.extendedGoods_w_orderIDTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.extendedGoods_w_orderIDTableAdapter();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.statusLabel = new System.Windows.Forms.Label();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersextendedGoodsworderIDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AutoGenerateColumns = false;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sellerDataGridViewTextBoxColumn,
            this.creationdateDataGridViewTextBoxColumn,
            this.implementationdateDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.ordersDataGridView.DataSource = this.ordersBindingSource;
            this.ordersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.Size = new System.Drawing.Size(661, 150);
            this.ordersDataGridView.TabIndex = 0;
            // 
            // goodsDataGridView
            // 
            this.goodsDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.goodsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.goodsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.articleDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn});
            this.goodsDataGridView.DataSource = this.ordersextendedGoodsworderIDBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.goodsDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.goodsDataGridView.Location = new System.Drawing.Point(12, 174);
            this.goodsDataGridView.Name = "goodsDataGridView";
            this.goodsDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.goodsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.goodsDataGridView.Size = new System.Drawing.Size(661, 144);
            this.goodsDataGridView.TabIndex = 1;
            // 
            // ordersextendedGoodsworderIDBindingSource
            // 
            this.ordersextendedGoodsworderIDBindingSource.DataMember = "orders_extendedGoods_w_orderID";
            this.ordersextendedGoodsworderIDBindingSource.DataSource = this.ordersBindingSource;
            // 
            // implementOrderButton
            // 
            this.implementOrderButton.Location = new System.Drawing.Point(23, 324);
            this.implementOrderButton.Name = "implementOrderButton";
            this.implementOrderButton.Size = new System.Drawing.Size(92, 34);
            this.implementOrderButton.TabIndex = 2;
            this.implementOrderButton.Text = "Видати товар";
            this.implementOrderButton.UseVisualStyleBackColor = true;
            this.implementOrderButton.Click += new System.EventHandler(this.implementOrderButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(23, 324);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(92, 34);
            this.createOrderButton.TabIndex = 3;
            this.createOrderButton.Text = "Створити замовлення";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.createOrderButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(121, 324);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 34);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Скасувати замовлення";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(598, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Вийти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // _IDLabel
            // 
            this._IDLabel.AutoSize = true;
            this._IDLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "id", true));
            this._IDLabel.Location = new System.Drawing.Point(99, 244);
            this._IDLabel.Name = "_IDLabel";
            this._IDLabel.Size = new System.Drawing.Size(35, 13);
            this._IDLabel.TabIndex = 6;
            this._IDLabel.Text = "label1";
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // airsoftDBDataSet
            // 
            this.airsoftDBDataSet.DataSetName = "AirsoftDBDataSet";
            this.airsoftDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sellerDataGridViewTextBoxColumn
            // 
            this.sellerDataGridViewTextBoxColumn.DataPropertyName = "seller";
            this.sellerDataGridViewTextBoxColumn.HeaderText = "Продавець";
            this.sellerDataGridViewTextBoxColumn.Name = "sellerDataGridViewTextBoxColumn";
            this.sellerDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.implementationdateDataGridViewTextBoxColumn.HeaderText = "Дата видачі";
            this.implementationdateDataGridViewTextBoxColumn.Name = "implementationdateDataGridViewTextBoxColumn";
            this.implementationdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Статус замовлення";
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // extendedGoods_w_orderIDTableAdapter
            // 
            this.extendedGoods_w_orderIDTableAdapter.ClearBeforeFill = true;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "status", true));
            this.statusLabel.Location = new System.Drawing.Point(203, 230);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(35, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "label1";
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Артикул";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Виробник";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
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
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "orderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Вибрана кількість";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 370);
            this.Controls.Add(this.goodsDataGridView);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this._IDLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createOrderButton);
            this.Controls.Add(this.implementOrderButton);
            this.Controls.Add(this.ordersDataGridView);
            this.Name = "OrdersForm";
            this.Text = "Замовлення";
            this.Load += new System.EventHandler(this.OrdersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersextendedGoodsworderIDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ordersDataGridView;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private AirsoftDBDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridView goodsDataGridView;
        private System.Windows.Forms.BindingSource ordersextendedGoodsworderIDBindingSource;
        private AirsoftDBDataSetTableAdapters.extendedGoods_w_orderIDTableAdapter extendedGoods_w_orderIDTableAdapter;
        private System.Windows.Forms.Button implementOrderButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label _IDLabel;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sellerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn implementationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
    }
}