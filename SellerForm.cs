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
    public partial class SellerForm : Form
    {        
        string userName;
        GoodsForm goodsForm;
        OrdersForm ordersForm;
        public SellerForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }
        public SellerForm()
        {
            InitializeComponent();
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goodsButton_Click(object sender, EventArgs e)
        {
            goodsForm = new GoodsForm(2);
            goodsForm.ShowDialog();
        }

        private void ordersButton_Click(object sender, EventArgs e)
        {
            ordersForm = new OrdersForm(this.userName, 1);
            ordersForm.ShowDialog();
        }
    }
}
