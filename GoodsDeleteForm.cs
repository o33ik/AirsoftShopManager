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
    public partial class GoodsDeleteForm : Form
    {
        public GoodsDeleteForm()
        {
            InitializeComponent();

        }

        private void GoodsDeleteForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.airsoftDBDataSet.goods);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            goodsTableAdapter.DeleteQuery(articleComboBox.Text);
            cancelButton_Click(sender, e);
        }
    }
}
