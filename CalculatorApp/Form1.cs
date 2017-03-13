using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        CaclBrain brain = new CaclBrain();
        public Form1()
        {
            InitializeComponent();
        }

        private void digitbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            display.Text += btn.Text;
        }

        private void operationbtn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
           if(btn.Text == "+")
            {
                brain.firstoperand = double.Parse( display.Text);
                display.Text = "";
            }
            else if (btn.Text == "=")
            {
                brain.secondoperand = double.Parse(display.Text);
                display.Text = brain.Plus().ToString();
            }
        }
    }
}
