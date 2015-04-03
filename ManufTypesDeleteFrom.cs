using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWorkApplication
{
    public partial class ManufTypesDeleteForm : Form
    {
        bool b;
        public ManufTypesDeleteForm(bool b)
        {
            InitializeComponent();
            this.b = b;
            if (b)
            {
                typesComboBox.Visible = false;
                label1.Text = "Виробник";
                this.Text = "Видалити виробника";
            }
            else
            {
                label1.Text = "Тип";
                manufComboBox.Visible = false;
                this.Text = "Видалити тип";
            }
        }

        private void ManufTypesDeleteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.goods_types". При необходимости она может быть перемещена или удалена.
            this.goods_typesTableAdapter.Fill(this.airsoftDBDataSet.goods_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.airsoftDBDataSet.manufacturer);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (b)
                {
                    queriesTableAdapter.manufacturerDelete(manufComboBox.Text);
                }
                if (!b)
                {
                    queriesTableAdapter.goodsTypesDelete(typesComboBox.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                if (b)
                {
                    MessageBox.Show("Ви не можете видалити цього виробника, тому що в БД є товари повязані з ним!");
                }
                if (!b)
                {
                    MessageBox.Show("Ви не можете видалити цей тип, тому що в БД є товари повязані з ним!");
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
