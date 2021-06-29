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
        double equals = 0.0;
        char operations;
        double input1, input2;

        public char operation { get => operations; set => operations = value; }

        public void one()
        {
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "";
            user_input += '1';
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
        public void add()
        {
            calculation_one = user_input;
            operation = '+';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "+";
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "" + operation;
            user_input = string.Empty;
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = true;
        }
        public void sub()
        {
            calculation_one = user_input;
            operation = '-';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "-";
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "" + operation;
            user_input = string.Empty;
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = true;
        }
        public void mul()
        {
            calculation_one = user_input;
            operation = '*';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "*";
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "" + operation;
            user_input = string.Empty;
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = true;
        }
        public void div()
        {
            calculation_one = user_input;
            operation = '/';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "/";
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "" + operation;
            user_input = string.Empty;
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = true;
        }
        public void exp()
        {
            calculation_one = user_input;
            operation = '^';
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = "^";
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "" + operation;
            user_input = string.Empty;
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = true;
        }
        public void ans()
        {
            basic_calculator.ActiveForm.Controls["decimal_point"].Enabled = true;
            calculation_two = user_input;
            double.TryParse(calculation_one, out input1);
            double.TryParse(calculation_two, out input2);
        }
        public void adding()
        {
            equals = input1 + input2;
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = equals.ToString();
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "+" + calculation_two + " = ";
            user_input = equals.ToString();
        }
        public void subtracting()
        {
            equals = input1 - input2;
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = equals.ToString();
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "-" + calculation_two + " = ";
            user_input = equals.ToString();
        }
        public void multiplying()
        {
            equals = input1 * input2;
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = equals.ToString();
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "*" + calculation_two + " = ";
            user_input = equals.ToString();
        }
        public void dividing()
        {
            if (input2 != 0)
            {
                equals = input1 / input2;
                basic_calculator.ActiveForm.Controls["ans_screen"].Text = equals.ToString();
                basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "/" + calculation_two + " = ";
                user_input = equals.ToString();
            }
            else
            {
                basic_calculator.ActiveForm.Controls["ans_screen"].Text = "Cannot Divide By Zero";
                basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "/" + "0" + " = " + "ERROR";

            }
        }
        public void raising()
        {
            equals = Math.Pow(input1, input2);
            basic_calculator.ActiveForm.Controls["ans_screen"].Text = equals.ToString();
            basic_calculator.ActiveForm.Controls["eqn_screen"].Text = calculation_one + "^" + calculation_two + " = ";
            user_input = equals.ToString();
        }
    }
}
