using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_IMT
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Result.Text = $"Ваш ИМТ: {Data.IMT}\r\n";
            if (Data.IMT < 18.5)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", Data.Gender, "slim.png"));
                Result.Text += Data.lowIMT;
            } else if (Data.IMT < 24.9)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", Data.Gender, "norm.png"));
                Result.Text += Data.normIMT;
            } else
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", Data.Gender, "fat.png"));
                Result.Text += Data.highIMT;
            }
        }
    }
}
