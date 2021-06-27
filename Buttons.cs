using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOOP
{
    class Buttons
    {
        string user_input = string.Empty;
        string calculation_one = string.Empty;
        string calculation_two = string.Empty;

        public void one()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += '1' ;
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void two()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += '2';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void three()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "3";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void four()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "4";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void five()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "5";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void six()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "6";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void seven()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "7";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void eight()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "8";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void nine()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "9";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void zero()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += "0";
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
        }
        public void point()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += '.';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text += user_input;
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = false;
        }
        public void backspace()
        {
            if (basic_calculator.ActiveForm.Controls["ans_screen"].Text.Length > 0)
            {
                basic_calculator.ActiveForm.Controls["ans_screen"].Text = basic_calculator.ActiveForm.Controls["ans_screen"].Text.Remove
                    (basic_calculator.ActiveForm.Controls["ans_screen"].Text.Length - 1);
                user_input = basic_calculator.ActiveForm.Controls["ans_screen"].Text;
            }
            else
                basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
        }
        public void clear()
        {
            {
                basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
                basic_calculator.ActiveForm.Controls["eqn_screen"].Text = "";
                user_input = string.Empty;
                calculation_one = string.Empty;
                calculation_two = string.Empty;
            }
        }
    }
}
