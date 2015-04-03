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
    public partial class GoodsUpdateForm : Form
    {
        string article;
        public GoodsUpdateForm(string article)
        {
            InitializeComponent();
            this.article = article;
        }

        private void GoodsUpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.extendedGoodsView". При необходимости она может быть перемещена или удалена.
            this.extendedGoodsViewTableAdapter.Fill(this.airsoftDBDataSet.extendedGoodsView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.goods_types". При необходимости она может быть перемещена или удалена.
            this.goods_typesTableAdapter.Fill(this.airsoftDBDataSet.goods_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.airsoftDBDataSet.manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.airsoftDBDataSet.goods);
            articleComboBox.Text = article;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            queriesTableAdapter.goodsUpdate(articleComboBox.Text, nameTextBox.Text, manufacturerComboBox.Text, typesComboBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(numberTextBox.Text));
            //goodsTableAdapter.UpdateQuery(articleComboBox.Text, nameTextBox.Text, manufacturerComboBox.Text, typesComboBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(numberTextBox.Text));
            cancelButton_Click(sender, e);
        }
    }
}
