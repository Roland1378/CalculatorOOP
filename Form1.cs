using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorOOP
{

    public partial class basic_calculator : Form
    {
        string user_input = string.Empty;
        string calculation_one = string.Empty;
        string calculation_two = string.Empty;
        char operation;
        double equals = 0.0;
        Buttons btn = new Buttons();

        public basic_calculator()
        {
            InitializeComponent();
        }

        private void number_one_Click(object sender, EventArgs e)
        {
            btn.one();

        }

        private void number_two_Click(object sender, EventArgs e)
        {
            btn.two();
        }

        private void number_three_Click(object sender, EventArgs e)
        {
            btn.three();
        }

        private void number_four_Click(object sender, EventArgs e)
        {
            btn.four();
        }

        private void number_five_Click(object sender, EventArgs e)
        {
            btn.five();
        }

        private void number_six_Click(object sender, EventArgs e)
        {
            btn.six();
        }

        private void number_seven_Click(object sender, EventArgs e)
        {
            btn.seven();
        }

        private void number_eight_Click(object sender, EventArgs e)
        {
            btn.eight();
        }

        private void number_nine_Click(object sender, EventArgs e)
        {
            btn.nine();
        }

        private void number_zero_Click(object sender, EventArgs e)
        {
            btn.zero();
        }

        private void decimal_point_Click(object sender, EventArgs e)
        {
            btn.point();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '+';
            ans_screen.Text = "+";
            eqn_screen.Text = calculation_one + "" + operation;
            user_input = string.Empty;
            decimal_point.Enabled = true;
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '-';
            ans_screen.Text = "-";
            eqn_screen.Text = calculation_one + "" + operation;
            user_input = string.Empty;
            decimal_point.Enabled = true;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '*';
            ans_screen.Text = "*";
            eqn_screen.Text = calculation_one + "" + operation;
            user_input = string.Empty;
            decimal_point.Enabled = true;
        }

        private void division_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '/';
            ans_screen.Text = "/";
            eqn_screen.Text = calculation_one + "" + operation;
            user_input = string.Empty;
            decimal_point.Enabled = true;
        }
        private void exponent_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '^';
            ans_screen.Text = "^";
            eqn_screen.Text = calculation_one + "" + operation;
            user_input = string.Empty;
        }
        private void del_text_Click(object sender, EventArgs e)
        {
            btn.clear();
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            btn.backspace();
        }
 
        private void answer_Click(object sender, EventArgs e)
        {
            decimal_point.Enabled = true;
            calculation_two = user_input;
            double input1, input2;
            double.TryParse(calculation_one, out input1);
            double.TryParse(calculation_two, out input2);

            if (operation == '+')
            {
                equals = input1 + input2;
                ans_screen.Text = equals.ToString();
                eqn_screen.Text = calculation_one + "+" + calculation_two + " = ";
                user_input = equals.ToString();
            }
            else if (operation == '-')
            {
                equals = input1 - input2;
                ans_screen.Text = equals.ToString();
                eqn_screen.Text = calculation_one + "-" + calculation_two + " = ";
                user_input = equals.ToString();
            }
            else if (operation == '*')
            {
                equals = input1 * input2;
                ans_screen.Text = equals.ToString();
                eqn_screen.Text = calculation_one + "*" + calculation_two + " = ";
                user_input = equals.ToString();
            }
            else if (operation == '/')
            {
                if (input2 != 0)
                {
                    equals = input1 / input2;
                    ans_screen.Text = equals.ToString();
                    eqn_screen.Text = calculation_one + "/" + calculation_two + " = ";
                    user_input = equals.ToString();
                }
                else
                {
                    ans_screen.Text = "Cannot Divide By Zero";
                    eqn_screen.Text = calculation_one + "/" + "0" + " = " + "ERROR";

                }
            }
            else if (operation == '^')
            {
                equals = Math.Pow(input1, input2);
                ans_screen.Text = equals.ToString();
                eqn_screen.Text = calculation_one + "^" + calculation_two + " = ";
                user_input = equals.ToString();
            }
        }
    }
}

