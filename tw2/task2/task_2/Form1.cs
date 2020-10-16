using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Calculation Method
        private void Calculation(String calcOperator)
        {
            var calculation = "";
            var answer = "";

            //checking if the user input is empty or not
            try
            {
                //converting user's input into integer
                var firstNum = Convert.ToInt32(firstNumber.Text);
                var secondNum = Convert.ToInt32(secondNumber.Text);
                //checking what operation should be applied
                switch (calcOperator)
                {
                    //addition handler
                    case "plus":
                        calculation = Convert.ToString(firstNum + secondNum);
                        answer = String.Format("{0} + {1} = {2}", firstNum, secondNum, calculation);
                        break;
                    //subtraction handler
                    case "minus":
                        calculation = Convert.ToString(firstNum - secondNum);
                        answer = String.Format("{0} - {1} = {2}", firstNum, secondNum, calculation);
                        break;
                    //multiplication handler
                    case "multiply":
                        calculation = Convert.ToString(firstNum * secondNum);
                        answer = String.Format("{0} * {1} = {2}", firstNum, secondNum, calculation);
                        break;
                    //division handler
                    case "divide":
                        calculation = Convert.ToString(firstNum / secondNum);
                        answer = String.Format("{0} / {1} = {2}", firstNum, secondNum, calculation);
                        break;
                    //finding the second - number percent of the first-number
                    case "percent":
                        calculation = Convert.ToString(firstNum * (secondNum / 100));
                        answer = String.Format("{1} percent of {0} is {2}", firstNum, secondNum, calculation);
                        break;
                    //raising the power of the first number to the second one
                    case "power":
                        calculation = Convert.ToString(Math.Pow(Convert.ToDouble(firstNum), Convert.ToDouble(secondNum)));
                        answer = String.Format("{1} power of {0} is {2}", firstNum, secondNum, calculation); 
                        break;
                    //generating a message box to say that given input is not valid
                    default:
                        MessageBox.Show("Something went wrong, please try again.");
                break;
                }
                //assigning the result label to the answer
                result.Text = answer;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong, please try again.");
                }
            }
        #endregion

        #region Calculating Operations
        private void plus_Click(object sender, EventArgs e)
        {
            Calculation("plus");
        }

        private void minus_Click(object sender, EventArgs e)
        {
            Calculation("minus");
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            Calculation("multiply");
        }

        private void divide_Click(object sender, EventArgs e)
        {
            Calculation("divide");
        }

        private void percent_Click(object sender, EventArgs e)
        {
            Calculation("percent");
        }

        private void power_Click(object sender, EventArgs e)
        {
            Calculation("power");
        }
        #endregion
    }
}
