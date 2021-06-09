using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(lbl.Text == "0")
            
                lbl.Text = "";
            
            if(btn.Text == ".") {
                if (!lbl.Text.Contains("."))
                
                    lbl.Text = lbl.Text + btn.Text;
                
            }
            else
            {
                lbl.Text += btn.Text;
            }
                
        }
        double num1, num2;
        string op;

        private void button5_Click(object sender, EventArgs e)
        {
            lbl.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string str = lbl.Text;
            lbl.Text = str.Substring(0, str.Length - 1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(lbl.Text);
            num1 = -num1;
            lbl.Text = Convert.ToString(num1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(lbl.Text);
            switch (op)
            {
                case "+":
                    lbl.Text = Convert.ToString(num1 + num2);
                    break;
                case "-":
                    lbl.Text = Convert.ToString(num1 - num2);
                    break;
                case "*":
                    lbl.Text = Convert.ToString(num1 * num2);
                    break;
                case "/":
                    lbl.Text = Convert.ToString(num1 / num2);
                    break;

            }
        }

        private void Operator(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            num1 = double.Parse(lbl.Text);
            lbl.Text = "";
            op = b.Text;
        }
    }
}
