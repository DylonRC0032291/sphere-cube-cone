using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sphere_cube_cone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double r = Convert.ToDouble(textBox1.Text);

                double V = 4.0 / 3.0 * Math.PI * r * r * r;

               label2.Text = "volume = " + V.ToString("0.00");
            }
            catch
            {
                label2.Text = "volume = ";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                double a = Convert.ToDouble(textBox2.Text);

                double ans = a * a * a;

                label3.Text = "volume = " + ans.ToString("0.00");
            }

            catch
            {
                label3.Text = "volume = ";
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {


        }
    }
}
