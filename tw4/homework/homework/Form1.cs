using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //receiving the user input as an integer
            var input = Convert.ToInt32(userInput.Text);
            //declaring my guess as an answer to the input's square root
            var guess = 1.0;

            
            for(double i = 1; i <= input / 2; i += 0.5)
            {
                //checking whether difference between the actual input and guess's square is less than 0.01,
                // if so the guess is almost the same as the actual answer
                if (Math.Abs(input - guess*guess) < 0.01)
                {
                    break;
                }
                //increasing or improving the guess to a better version
                else
                {
                    guess = (i + input / i)/2;
                }
            }

            //showing the user first actual answer and the application's guess
            MessageBox.Show(String.Format("Actual answer is {0} \nGuess is {1}", Math.Sqrt(input), guess));
        }
    }
}
