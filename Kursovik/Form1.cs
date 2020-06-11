using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kursovik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = 0;
            try
            {
                x = System.Convert.ToDouble(this.textBox1.Text);
                label4.Visible = false;
            }
            catch (FormatException )
            {
                label4.Visible = true;
            }
            double y = 0;
            int R = 1;
            if (x >= -3 && x < -2) y = -x - 2;
            else if (x >= -2 && x < -1) y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2) - 2 * x - 1);
            else if (x >= -1 && x < 1) y = 1;
            else if (x >= 1 && x <= 2) y = -2 * x + 3;
            else if (x >= 2 && x <= 5) y = -1;
            else if (x <= -4 || x > 5) y = 0;
this.label3.Text = System.Convert.ToString(y);
          }
    }
}
