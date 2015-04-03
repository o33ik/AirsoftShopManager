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
    public partial class OrdersForm : Form
    {
        string userName;
        public OrdersForm(string userName, int permission)
        {
            InitializeComponent();
            this.userName = userName;
            if (permission == 1) // seller
            {
            }
            if (permission == 2) // head of staff
            {
            }
            switch (permission)
            {
                case 1:
                    {
                        implementOrderButton.Visible = false;
                    } 
                    break;
                case 2:
                    {
                        cancelButton.Visible = false;
                        createOrderButton.Visible = false;
                    } 
                    break;
            }
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.extendedGoods_w_orderID". При необходимости она может быть перемещена или удалена.
            this.extendedGoods_w_orderIDTableAdapter.Fill(this.airsoftDBDataSet.extendedGoods_w_orderID);
            this.extendedGoods_w_orderIDTableAdapter.Fill(this.airsoftDBDataSet.extendedGoods_w_orderID);
            this.ordersTableAdapter.Fill(this.airsoftDBDataSet.orders);

        }

        private void implementOrderButton_Click(object sender, EventArgs e)
        {
            OrdersForm_Load(sender, e);
            if (statusLabel.Text == "False")
            {
                queriesTableAdapter.orderImplement(Convert.ToInt32(_IDLabel.Text));
                OrdersForm_Load(sender, e);
            }
            else MessageBox.Show("Це замовлення вже виконано!");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "False")
            {
                queriesTableAdapter.orderCancel(Convert.ToInt32(_IDLabel.Text));
                OrdersForm_Load(sender, e);
            }
            else 
                MessageBox.Show("Не можливо скасувати виконане замовлення!");
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(queriesTableAdapter.orderInsert(userName));
            AddGoodToAppOrOrderForm addGoddsToOrderForm = new AddGoodToAppOrOrderForm(null, id, 2);
            
            addGoddsToOrderForm.ShowDialog();
            queriesTableAdapter.orderPreImplement(id);
            OrdersForm_Load(sender, e);
        }
    }
}
