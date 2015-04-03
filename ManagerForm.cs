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
    public partial class ManagerForm : Form
    {
        string userName;
        GoodsForm goodsForm;
        ApplicationForm applicationForm;
        public ManagerForm(string userName)
        {
            InitializeComponent();
            this.userName = userName;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goodsFormLoadButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            goodsForm = new GoodsForm(1);
            goodsForm.ShowDialog();
            this.Visible = true;
        }

        private void applicationsFormLoadButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            applicationForm = new ApplicationForm(userName, 1);
            applicationForm.ShowDialog();
            this.Visible = true;
        }
    }
}
