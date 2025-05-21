using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_IMT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            Data.IMT = Math.Round(Convert.ToDouble(WeightTextBox.Text.Trim()) / Math.Pow(Convert.ToDouble(HeightTextBox.Text.Trim()) / 100, 2), 1);
            if (Male.Checked)
            {
                Data.Gender = "Male";
            } else
            {
                Data.Gender = "Female";
            }
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
