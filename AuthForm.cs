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
    public partial class AuthForm : Form
    {
        ManagerForm managerForm;
        SellerForm sellerForm;
        HeadOfStaffForm headOfStaffForm;
        NewUserForm newUserForm;
        public AuthForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.airsoftDBDataSet.workers);
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (workersTableAdapter.checkPassword(loginComboBox.Text, Hash.GetMd5Hash(passwordTextBox.Text)) == true)
            {
                this.Visible = false;
                switch (workersTableAdapter.SelectPost(loginComboBox.Text))
                {
                    case "Manager": 
                        managerForm = new ManagerForm(loginComboBox.Text);
                        managerForm.ShowDialog(); 
                        break;
                    case "Seller":
                        sellerForm = new SellerForm(loginComboBox.Text);
                        sellerForm.ShowDialog(); 
                        break;
                    case "HeadOfStaff":
                        headOfStaffForm = new HeadOfStaffForm(loginComboBox.Text);
                        headOfStaffForm.ShowDialog();
                        break;
                }
                this.Visible = true;
                //this.Close();
            }
            else
            {
                MessageBox.Show("Невірний пароль!", "Помилка");
                passwordTextBox.Clear();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            newUserForm = new NewUserForm();
            newUserForm.ShowDialog();
            LoginForm_Load(sender, e);
            this.Visible = true;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
