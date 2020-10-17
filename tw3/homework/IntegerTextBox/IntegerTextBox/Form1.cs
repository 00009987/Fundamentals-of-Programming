using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userInput_KeyPress(object sender, KeyPressEventArgs e)
        {                           
                //checking if the user's input equals to a specific number character, in this case 7
                if (e.KeyChar == '7')
                {
                    //assigning label to the input
                    label1.Text = '7';
                }
                else
                    //doesn't accept user's input
                    e.Handled = true;                
        }
    }
}
