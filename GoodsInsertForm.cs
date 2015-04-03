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
    public partial class GoodsInsertForm : Form
    {
        public GoodsInsertForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            queriesTableAdapter.goodsInsert(articleTextBox.Text, nameTextBox.Text, manufacturerComboBox.Text, typesComboBox.Text, Convert.ToInt32(priceTextBox.Text), Convert.ToInt32(numberTextBox.Text));
            cancelButton_Click(sender, e);
        }

        private void GoodsInsertForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.goods_types". При необходимости она может быть перемещена или удалена.
            this.goods_typesTableAdapter.Fill(this.airsoftDBDataSet.goods_types);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.airsoftDBDataSet.manufacturer);

        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void manufacturerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void articleTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
