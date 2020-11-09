using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //receiving user inputs
            var num1 = tbxNum1.Text;
            var num2 = tbxNum2.Text;

            //doing the calculation
            int sum = wordToInt(num1) + wordToInt(num2);

            //changing result label into addition of user's inputs
            result.Text = sum.ToString();
        }

        #region Word To Integer
        /// <summary>
        /// According to user input, this method will convert it into integer number
        /// </summary>
        /// <param name="number">Where user input goes</param>
        /// <returns></returns>
        private int wordToInt(string number)
        {
            //declaring variable to store user's number value
            int n = 0;
            //checking user's input according to written numbers
            switch (number.ToLower())
            {
                case "zero":
                    n = 0;
                    break;
                case "one":
                    n = 1;
                    break;
                case "two":
                    n = 2;
                    break;
                case "three":
                    n = 3;
                    break;
                case "four":
                    n = 4;
                    break;
                case "five":
                    n = 5;
                    break;
                case "six":
                    n = 6;
                    break;
                case "seven":
                    n = 7;
                    break;
                case "eight":
                    n = 8;
                    break;
                case "nine":
                    n = 9;
                    break;
                    //showing an error message in case user's input does not match numbers above
                default:
                    MessageBox.Show("Please enter a number between 0 and 9");
                    break;
            }
            return n;
        }
        #endregion
    }
}
