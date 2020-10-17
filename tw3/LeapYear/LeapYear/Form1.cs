using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYear
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            var input = userInput.Value;
            var message = "";

            if (input > 1582)
            {
                message = input + " is a leap year";

                if (input % 4 == 0)
                {
                    message = input + " is a leap year";
                    if (input % 100 == 0)
                    {
                        message = input + " is not a leap year";
                        if (input % 400 == 0)
                        {
                            message = input + " is a leap year";

                        }
                        else
                            message = input + " is not a leap year";
                    }
                    else
                        message = input + " is a leap year";                    
                }
                else
                    message = input + " is not a leap year";
            }
            else
                message = input + " is not a leap year";

            MessageBox.Show(message);            
        }
    }
}
