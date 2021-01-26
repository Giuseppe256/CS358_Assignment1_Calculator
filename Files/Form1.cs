using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_Calculator
{
    public partial class Form1 : Form
    {
        Double value = 0;
        String operation = "";
        bool operationPressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((result.Text == "0")||(operationPressed))
                result.Clear();
            operationPressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operationPressed = true;
            equation.Text = value + " " + operation;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void equals_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    if (result.Text == "0")
                    {
                        result.Text = "Can't Divide by Zero";
                    }
                    else
                        result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }
            operationPressed = false;
        }

        private void decimal_Click(object sender, EventArgs e)
        {
            if (result.Text.Contains("."))
            {
            }
            else
                result.Text = result.Text + ".";
        }
    }
}
