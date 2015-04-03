namespace CourseWorkApplication
{
    partial class ManufTypesDeleteForm
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
            this.manufComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airsoftDBDataSet = new CourseWorkApplication.AirsoftDBDataSet();
            this.manufacturerTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.manufacturerTableAdapter();
            this.typesComboBox = new System.Windows.Forms.ComboBox();
            this.goodstypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteButton = new System.Windows.Forms.Button();
            this.goods_typesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.goods_typesTableAdapter();
            this.queriesTableAdapter = new CourseWorkApplication.AirsoftDBDataSetTableAdapters.QueriesTableAdapter();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // manufComboBox
            // 
            this.manufComboBox.DataSource = this.manufacturerBindingSource;
            this.manufComboBox.DisplayMember = "name";
            this.manufComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufComboBox.FormattingEnabled = true;
            this.manufComboBox.Location = new System.Drawing.Point(121, 21);
            this.manufComboBox.Name = "manufComboBox";
            this.manufComboBox.Size = new System.Drawing.Size(100, 21);
            this.manufComboBox.TabIndex = 0;
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
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // typesComboBox
            // 
            this.typesComboBox.DataSource = this.goodstypesBindingSource;
            this.typesComboBox.DisplayMember = "type";
            this.typesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesComboBox.FormattingEnabled = true;
            this.typesComboBox.Location = new System.Drawing.Point(121, 21);
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.Size = new System.Drawing.Size(100, 21);
            this.typesComboBox.TabIndex = 1;
            // 
            // goodstypesBindingSource
            // 
            this.goodstypesBindingSource.DataMember = "goods_types";
            this.goodstypesBindingSource.DataSource = this.airsoftDBDataSet;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(21, 50);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(66, 34);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Видалити";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // goods_typesTableAdapter
            // 
            this.goods_typesTableAdapter.ClearBeforeFill = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(155, 48);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(66, 34);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Вихід";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // ManufTypesDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 105);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.typesComboBox);
            this.Controls.Add(this.manufComboBox);
            this.Name = "ManufTypesDeleteForm";
            this.Load += new System.EventHandler(this.ManufTypesDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airsoftDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodstypesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox manufComboBox;
        private AirsoftDBDataSet airsoftDBDataSet;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private AirsoftDBDataSetTableAdapters.manufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.ComboBox typesComboBox;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.BindingSource goodstypesBindingSource;
        private AirsoftDBDataSetTableAdapters.goods_typesTableAdapter goods_typesTableAdapter;
        private AirsoftDBDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
    }
}