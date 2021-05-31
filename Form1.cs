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

        public basic_calculator()
        {
                InitializeComponent();   
        }

        private void number_one_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '1';
            ans_screen.Text += user_input;

        }

        private void number_two_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '2';
            ans_screen.Text += user_input;
        }

        private void number_three_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '3';
            ans_screen.Text += user_input;
        }

        private void number_four_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '4';
            ans_screen.Text += user_input;
        }

        private void number_five_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '5';
            ans_screen.Text += user_input;
        }

        private void number_six_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '6';
            ans_screen.Text += user_input;
        }

        private void number_seven_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '7';
            ans_screen.Text += user_input;
        }

        private void number_eight_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '8';
            ans_screen.Text += user_input;
        }

        private void number_nine_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '9';
            ans_screen.Text += user_input;
        }

        private void number_zero_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '0';
            ans_screen.Text += user_input;
        }

        private void decimal_point_Click(object sender, EventArgs e)
        {
            ans_screen.Text = "";
            user_input += '.';
            ans_screen.Text += user_input;
            decimal_point.Enabled = false;
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
        private void del_text_Click(object sender, EventArgs e)
        {

        }

        private void answer_Click(object sender, EventArgs e)
        {

        }

        private void basic_calculator_Load(object sender, EventArgs e)
        {

        }
    }

}

