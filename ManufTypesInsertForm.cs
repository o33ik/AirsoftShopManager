using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;

namespace CourseWorkApplication
{
    public partial class ManufTypesInsertForm : Form
    {
        bool b;
        public ManufTypesInsertForm(bool b)
        {
            InitializeComponent();
            this.b = b;
            if (!b)
            {
                countriesComboBox.Visible = false;
                label1.Text = "Тип";
                label2.Visible = false;
                this.Text = "Додати виробника";
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (b)//додати виробника
                {
                    queriesTableAdapter.manufacturerInsert(textBox.Text, countriesComboBox.Text);
                    //MessageBox.Show(""+ queriesTableAdapter.manufacturerInsert(textBox.Text, countriesComboBox.Text));
                }
                if(!b)//додати тип
                {
                    queriesTableAdapter.goodsTypeInsert(textBox.Text);
                    //MessageBox.Show("" + queriesTableAdapter.goodsTypeInsert(textBox.Text));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
