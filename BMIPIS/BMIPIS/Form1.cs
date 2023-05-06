using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMIPIS
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.male_icon;
        }

        private void button4_Click(object sender, EventArgs e, object textBox1, object textBox2)
        {
            double rost = Convert.ToDouble(textBox1.Text) / 100;
            double ves = Convert.ToDouble(textBox2.Text);
            int BMI = Convert.ToInt32(ves / (rost * rost));
            label16.Text = BMI.ToString();
            //trackBar1.Value = Convert.ToInt32(BMI) ;
            if (BMI < 10)
            { trackBar1.Value = 10; label16.Text = "недостаточный"; }
            if (BMI < 18.5 && BMI >= 10)
            { trackBar1.Value = Convert.ToInt32(BMI); label17.Text = "недостаточный"; }
            if (BMI >= 18.5 && BMI <= 24.9)
            { trackBar1.Value = Convert.ToInt32(BMI); label17.Text = "здоровый"; }
            if (BMI <= 30 && BMI > 24.9)
            { trackBar1.Value = Convert.ToInt32(BMI); label17.Text = "избыточный"; }
            if (BMI > 30)
            { trackBar1.Value = Convert.ToInt32(BMI); label17.Text = "ожирение"; }
        }

        private void button5_Click(object sender, EventArgs e, object textBox2)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.female_icon;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
