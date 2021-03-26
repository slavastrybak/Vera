using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT_laba3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxForX.Text);
            int Check1 = CheckButton();
            double Calculation1 = Count1(Check1, x);
            double y = Find_Y(Calculation1, x);
            textBoxOut.Text += $"При х = {x}";
            textBoxOut.Text += Environment.NewLine;
            textBoxOut.Text += $"y = {y}";
            textBoxOut.Text += Environment.NewLine;
        }

        public double Count1(int check, double x)
        {
            double Calculation = 0;
            switch (check)
            {
                case 1:
                    Calculation = Math.Sinh(x);
                    break;
                case 2:
                    Calculation = Math.Cosh(x);
                    break;
                case 3:
                    Calculation = Math.Exp(x);
                    break;
                default: break;
            }
            return Calculation;
        }

        public int CheckButton()
        {
            int check = 0;
            if (radioButton1.Checked == true)
            {
                check = 1;
            }
            if (radioButton1.Checked == true)
            {
                check = 2;
            }
            if (radioButton1.Checked == true)
            {
                check = 3;
            }
            return check;
        }
        public double Find_Y(double Calculation, double x)
        {
            double y = 0;
            if (x > 0)
            {
                y = Math.Sqrt(Calculation);
            }
            if ((x > -3) && (x <=0))
            {
                y = Calculation;
            }
            if (x <= -3)
            {
                y =-5;
            }
            return y;
        }


    }
}
