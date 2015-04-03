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
    public partial class ApplicationAddForm : Form
    {
        string userName;
        AddGoodToAppOrOrderForm addGoodToAppForm;
        public ApplicationAddForm(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(queriesTableAdapter.ApplicationInsert(userName, manufacturerComboBox.Text));
            //MessageBox.Show("" + applicationsTableAdapter.InsertQuery(userName, manufacturerComboBox.Text, null, null, false));
            //applicationsTableAdapter.InsertQuery(userName, manufacturerComboBox.Text, null, null, false);
            addGoodToAppForm = new AddGoodToAppOrOrderForm(manufacturerComboBox.Text, id, 1);
            addGoodToAppForm.ShowDialog();
            ApplicationAddForm_Load(sender, e);
        }

        private void ApplicationAddForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "airsoftDBDataSet.manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.airsoftDBDataSet.manufacturer);

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
