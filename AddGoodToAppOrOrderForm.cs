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
    public partial class AddGoodToAppOrOrderForm : Form
    {
        string manufacturer;
        int ID;
        int permission;
        public AddGoodToAppOrOrderForm(string manufacturer, int ID, int permission)
        {
            InitializeComponent();
            this.manufacturer = manufacturer;
            this.ID = ID;
            this.permission = permission;
        }
        private void AddGoodToAppForm_Load(object sender, EventArgs e)
        {
            this.goodsTableAdapter.Fill(this.airsoftDBDataSet.goods);//;
        }
        private void addGoodToButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (permission == 1)
                {
                    if (Convert.ToInt32(queriesTableAdapter.AssociateAppWGood(ID, articleComboBox.Text, Convert.ToInt32(numberTextBox.Text)).ToString()) == 1)
                        MessageBox.Show("Товар додано");
                    else MessageBox.Show("Відбулась невідома помилка");
                }
                if (permission == 2)
                {
                    if (Convert.ToInt32(storeNumberTextBox.Text) >= Convert.ToInt32(numberTextBox.Text))
                    {
                        if (Convert.ToInt32(queriesTableAdapter.associateOrderWGoods(ID, articleComboBox.Text, Convert.ToInt32(numberTextBox.Text)).ToString()) == 1)
                            MessageBox.Show("Товар додано");
                        else MessageBox.Show("Відбулась невідома помилка");

                    }
                    else
                    {
                        MessageBox.Show("На складі немає достатньої кількості товару!");
                    }
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Введіть кількість товару!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
