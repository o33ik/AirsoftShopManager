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
        public partial class HeadOfStaffForm : Form
        {
            string userName;
            ApplicationForm applicationForm;
            OrdersForm ordersForm;
            public HeadOfStaffForm(string userName)
            {
                InitializeComponent();
                this.userName = userName;
            
            }

            private void exitButton_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            private void applicationsFormLoadButton_Click(object sender, EventArgs e)
            {
                applicationForm = new ApplicationForm(userName, 2);
                applicationForm.ShowDialog();
            }


            private void ordersButton_Click(object sender, EventArgs e)
            {
                ordersForm = new OrdersForm(userName, 2);
                ordersForm.ShowDialog();
            }
        }
    }
