using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace calculator
{
    public partial class Main : Form
    {
        private double result = 0;
        private string currentOperation = "";
        private bool isOperationPressed = false;

        public Main()
        {
            InitializeComponent();
        }

           private void buttonClear_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            result = 0;
            currentOperation = "";
        }

        bool IsBlack = false ;
        

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (IsBlack)
                {
                    BackColor = Color.White;
                    ForeColor = Color.Black;
                    button1.BackColor = Color.Black;
                    one.ForeColor = Color.Black;
                    two.ForeColor = Color.Black;
                    three.ForeColor = Color.Black;
                    four.ForeColor = Color.Black;
                    five.ForeColor = Color.Black;
                    six.ForeColor = Color.Black;
                    seven.ForeColor = Color.Black;
                    eight.ForeColor = Color.Black;
                    nine.ForeColor = Color.Black;
                    multiplication.ForeColor = Color.Black;
                    addition.ForeColor = Color.Black;
                    division.ForeColor = Color.Black;
                    subtraction.ForeColor = Color.Black;
                    itog.ForeColor = Color.Black;

                }
                else
                {
                    BackColor = Color.Black;
                    ForeColor = Color.White;
                    button1.BackColor = Color.White;
                    one.ForeColor = Color.Black;
                    two.ForeColor = Color.Black;
                    three.ForeColor = Color.Black;
                    four.ForeColor = Color.Black;
                    five.ForeColor = Color.Black;
                    six.ForeColor = Color.Black;
                    seven.ForeColor = Color.Black;
                    eight.ForeColor = Color.Black;
                    nine.ForeColor = Color.Black;
                    multiplication.ForeColor = Color.Black;
                    addition.ForeColor = Color.Black;
                    division.ForeColor = Color.Black;
                    subtraction.ForeColor = Color.Black;
                    itog.ForeColor = Color.Black;

                }

                IsBlack = !IsBlack; 
            }

        }

        private void one_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            result = 0;
            currentOperation = "";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if ((display.Text == "0") || (isOperationPressed))
                display.Clear();

            isOperationPressed = false;
            Button button = (Button)sender;
            display.Text += button.Text;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            currentOperation = button.Text;
            result = double.Parse(display.Text);
            isOperationPressed = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            switch (currentOperation)
            {
                case "+":
                    display.Text = (result + double.Parse(display.Text)).ToString();
                    break;
                case "-":
                    display.Text = (result - double.Parse(display.Text)).ToString();
                    break;
                case "*":
                    display.Text = (result * double.Parse(display.Text)).ToString();
                    break;
                case "/":
                    display.Text = (result / double.Parse(display.Text)).ToString();
                    break;
            }
            result = double.Parse(display.Text);
            currentOperation = "";
        }
    }   
}
