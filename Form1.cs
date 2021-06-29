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
            btn.add();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            btn.sub();
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            btn.mul();
        }

        private void division_Click(object sender, EventArgs e)
        {
            btn.div();
        }
        private void exponent_Click(object sender, EventArgs e)
        {
            btn.exp();
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
            btn.ans();

            if (btn.operation == '+')
            {
                btn.adding();
            }
            else if (btn.operation == '-')
            {
                btn.subtracting();
            }
            else if (btn.operation == '*')
            {
                btn.multiplying();
            }
            else if (btn.operation == '/')
            {
                btn.dividing();
            }
            else if (btn.operation == '^')
            {
                btn.raising();
            }
        }
    }
}

