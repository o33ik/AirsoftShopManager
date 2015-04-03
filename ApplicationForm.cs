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
    public partial class ApplicationForm : Form
    {
        string userName;
        ApplicationAddForm applicationAddForm;
        public ApplicationForm(string userName, int permission)
        {
            InitializeComponent();
            this.userName = userName;
            switch (permission)
            {
                case 1: // manager
                    {
                        implementAppButton.Visible = false;                        
                    }; 
                    break;
                case 2: // head of staff
                    {
                        addAppButton.Visible = false;
                        deleteAppButton.Visible = false;
                    };
                    break;
            }
        }

        private void ApplicationForm_Load(object sender, EventArgs e)
        {
            this.extendedgoods_w_appIDTableAdapter.Fill(this.airsoftDBDataSet.extendedgoods_w_appID);
            this.extended_applications_viewTableAdapter.Fill(this.airsoftDBDataSet.extended_applications_view);
        }

        private void addAppButton_Click(object sender, EventArgs e)
        {
            applicationAddForm = new ApplicationAddForm(userName);
            applicationAddForm.ShowDialog();
            ApplicationForm_Load(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void implementAppButton_Click(object sender, EventArgs e)
        {
            if (statusLabel.Text == "False")
            {
                queriesTableAdapter.applicationImplement(Convert.ToInt32(_IDLabel.Text));
                ApplicationForm_Load(sender, e);
            }
            else
                MessageBox.Show("Ця заявка вже опрацьована!");
        }

        private void deleteAppButton_Click(object sender, EventArgs e)
        {
            queriesTableAdapter.deleteApplication(Convert.ToInt32(_IDLabel.Text));
            ApplicationForm_Load(sender, e);
        }
    }
}
