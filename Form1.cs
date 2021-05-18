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
            user_input += '1';
        }

        private void number_two_Click(object sender, EventArgs e)
        {
            user_input += '2';
        }

        private void number_three_Click(object sender, EventArgs e)
        {
            user_input += '3';
        }

        private void number_four_Click(object sender, EventArgs e)
        {
            user_input += '4';
        }

        private void number_five_Click(object sender, EventArgs e)
        {
            user_input += '5';
        }

        private void number_six_Click(object sender, EventArgs e)
        {
            user_input += '6';
        }

        private void number_seven_Click(object sender, EventArgs e)
        {
            user_input += '7';
        }

        private void number_eight_Click(object sender, EventArgs e)
        {
            user_input += '8';
        }

        private void number_nine_Click(object sender, EventArgs e)
        {
            user_input += '9';
        }

        private void number_zero_Click(object sender, EventArgs e)
        {
            user_input += '0';
        }

        private void decimal_point_Click(object sender, EventArgs e)
        {
            user_input += '.';
        }

        private void addition_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '+';
            user_input = string.Empty;
        }
        
        private void subtraction_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '-';
            user_input = string.Empty;
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '*';
            user_input = string.Empty;
        }

        private void division_Click(object sender, EventArgs e)
        {
            calculation_one = user_input;
            operation = '/';
            user_input = string.Empty;
        }

        private void clear_all_Click(object sender, EventArgs e)
        {

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
