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
    public partial class GoodsForm : Form
    {
        GoodsInsertForm goodsInsertForm;
        GoodsUpdateForm goodsUpdateForm;
        GoodsDeleteForm goodsDeleteForm;
        ManufTypesDeleteForm manufTypesDeleteForm;
        ManufTypesInsertForm manufTypesInsertForm;
        public GoodsForm(int permission)
        {
            InitializeComponent();
            noneFilterRadioButton.Checked = true;
            switch (permission)
            {
                case 1:
                    {
                    };
                    break;
                case 2:
                    {
                        deleteGoodButton.Visible = false;
                        AddGoodButton.Visible = false;
                        deleteManufButton.Visible = false;
                        deleteTypeButton.Visible = false;
                        manufAddButton.Visible = false;
                        typeAddButton.Visible = false;
                        updateGoodButton.Visible = false;
                    };
                    break;
            }
        }
        private void GoodsForm_Load(object sender, EventArgs e)
        {
            this.extendedGoodsViewTableAdapter.Fill(this.airsoftDBDataSet.extendedGoodsView);
            this.manufacturerTableAdapter.Fill(this.airsoftDBDataSet.manufacturer);
            this.goods_typesTableAdapter.Fill(this.airsoftDBDataSet.goods_types);
        }
        private void manufRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typesDataGridView.Visible = false;
            manufDataGridView.Visible = true;
            goodsDataGridView.DataSource = manufacturerextendedGoodsViewBindingSource;
        }
        private void typesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            manufDataGridView.Visible = false;
            typesDataGridView.Visible = true;
            goodsDataGridView.DataSource = goodstypesextendedGoodsViewBindingSource;
        }
        private void noneFilterRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            goodsDataGridView.DataSource = extendedGoodsViewBindingSource;
            typesDataGridView.Visible = false;
            manufDataGridView.Visible = false;
        }
        private void AddGoodButton_Click(object sender, EventArgs e)
        {
            goodsInsertForm = new GoodsInsertForm();
            goodsInsertForm.ShowDialog();
            GoodsForm_Load(sender, e);
        }
        private void updateGoodButton_Click(object sender, EventArgs e)
        {
            goodsUpdateForm = new GoodsUpdateForm(articleLabel.Text);
            goodsUpdateForm.ShowDialog();
            GoodsForm_Load(sender, e);
        }
        private void deleteGoodButton_Click(object sender, EventArgs e)
        {
            try
            {
                goodsTableAdapter.DeleteQuery(articleLabel.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Товар не можливо видалити!");
            }
            GoodsForm_Load(sender, e);
        }
        private void manufAddButton_Click(object sender, EventArgs e)
        {
            manufTypesInsertForm = new ManufTypesInsertForm(true);
            manufTypesInsertForm.ShowDialog();
            GoodsForm_Load(sender, e);
        }
        private void typeAddButton_Click(object sender, EventArgs e)
        {
            manufTypesInsertForm = new ManufTypesInsertForm(false);
            manufTypesInsertForm.ShowDialog();
            GoodsForm_Load(sender, e);
        }
        private void deleteManufButton_Click(object sender, EventArgs e)
        {
            manufTypesDeleteForm = new ManufTypesDeleteForm(true);
            manufTypesDeleteForm.ShowDialog();
            GoodsForm_Load(sender, e);
        }
        private void deleteTypeButton_Click(object sender, EventArgs e)
        {
            manufTypesDeleteForm = new ManufTypesDeleteForm(false);
            manufTypesDeleteForm.ShowDialog();
            GoodsForm_Load(sender, e);
        }
    }
}
