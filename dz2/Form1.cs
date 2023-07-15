using dz2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz2
{
    public partial class Form1 : Form
    {
        DbVegFruits db = null;
        public Form1()
        {
            InitializeComponent();
            db = new DbVegFruits();
            textBoxForEnter.ReadOnly = true;
            textBoxForEnterForList.ReadOnly = true;
        }

        private void comboBoxForList_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxForList.SelectedIndex)
            {
                case 0:
                    labelForList.Text = " ";
                    textBoxForEnterForList.ReadOnly = true;
                    listBox1.DataSource = null;
                    listBox1.DataSource = db.ShowAllInfo();
                    break;
                case 1:
                    labelForList.Text = " ";
                    textBoxForEnterForList.ReadOnly = true;
                    listBox1.DataSource = null;
                    listBox1.DataSource = db.ShowNames();
                    listBox1.DisplayMember = "Name";
                    break;
                case 2:
                    labelForList.Text = " ";
                    textBoxForEnterForList.ReadOnly = true;
                    listBox1.DataSource = null;
                    listBox1.DataSource = db.ShowAllColors();
                    listBox1.DisplayMember = "Color";
                    break;
                case 3:
                    labelForList.Text = " ";
                    textBoxForEnterForList.ReadOnly = true;
                    listBox1.DataSource = null;
                    listBox1.DataSource = db.CountAllColors();
                    listBox1.DisplayMember = "Color";
                    break;
                case 4:
                    listBox1.DataSource = null;
                    labelForList.Text = "Введите калорийность ниже:";
                    textBoxForEnterForList.ReadOnly = false;
                    if (textBoxForEnterForList.Text == string.Empty)
                        textBoxForEnterForList.Text = 0.ToString();
                    break;
                case 5:
                    listBox1.DataSource = null;
                    labelForList.Text = "Введите калорийность ниже:";
                    textBoxForEnterForList.ReadOnly = false;
                    if (textBoxForEnterForList.Text == string.Empty)
                        textBoxForEnterForList.Text = 0.ToString();
                    break;
            }
        }
        private void buttonForList_Click(object sender, EventArgs e)
        {
            switch (comboBoxForList.SelectedIndex)
            {
                case 4:
                    double x = Convert.ToDouble(textBoxForEnterForList.Text);
                    listBox1.DataSource = null;
                    listBox1.DataSource = db.CaloryLessThen(x);
                    listBox1.DisplayMember = "Name";
                    break;
                case 5:
                    double y = Convert.ToDouble(textBoxForEnterForList.Text);
                    listBox1.DataSource = null;
                    listBox1.DataSource = db.CaloryMoreThen(y);
                    listBox1.DisplayMember = "Name";
                    break;
            }
        }

        private void comboBoxForText_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxForText.SelectedIndex)
            {
                case 0:
                    labelForText.Text = " ";
                    textBoxForEnter.ReadOnly = true;
                    textBoxForShow.Text = db.MaxCalory().ToString();
                    break;
                case 1:
                    labelForText.Text = " ";
                    textBoxForEnter.ReadOnly = true;
                    textBoxForShow.Text = db.MinCalory().ToString();
                    break;
                case 2:
                    labelForText.Text = " ";
                    textBoxForEnter.ReadOnly = true;
                    textBoxForShow.Text = db.AvgCalory().ToString("F2");
                    break;
                case 3:
                    labelForText.Text = " ";
                    textBoxForEnter.ReadOnly = true;
                    textBoxForShow.Text = db.VegCount().ToString();
                    break;
                case 4:
                    labelForText.Text = " ";
                    textBoxForEnter.ReadOnly = true;
                    textBoxForShow.Text = db.FruitsCount().ToString();
                    break;
                case 5:
                    labelForText.Text = "Введите цвет ниже:";
                    textBoxForEnter.ReadOnly = false;
                    break;
            }
        }

        private void buttonForText_Click(object sender, EventArgs e)
        {
            switch (comboBoxForText.SelectedIndex)
            {
                case 5:
                    string str = textBoxForEnter.Text.ToString();
                    textBoxForShow.Text = db.CountThisColor(str).ToString();
                    break;
            }
        }

        private async void buttonForUpdate_Click(object sender, EventArgs e)
        {
            db.Update(textBoxNameForUpdate.Text, textBoxColorForUpdate.Text, Convert.ToDouble(textBoxCalForUpdate.Text));
        }

        private async void buttonForDelete_Click(object sender, EventArgs e)
        {
            db.Delete(textBoxNameForDelete.Text);
        }
    }
}
