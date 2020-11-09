using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeArrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //getting data from the user
            var A = tbxInputOne.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            var B = tbxInputTwo.Text.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //creating an array with the size of equal to previous two
            var C = new string[A.Length + B.Length];
            var index = 0; //to keep track of indexs in array C

            //looping through array A
            foreach (var a in A)
            {
                //checking if array C already contains an element from array A
                if (!C.Contains(a))
                {
                    //if not adding it to array C
                    C[index] = a;
                    // and incrementing index value so that next element will be added in its order
                    index++;
                }
            }

            foreach (var b in B)
            {
                //checking if array C already contains an element from array B
                if (!C.Contains(b))
                {
                    //if not adding it to array C
                    C[index] = b;
                    // and incrementing index value so that next element will be added in its order
                    index++;
                }
            }

            //refactoring and resizing array C to get rid of not used empty placeholders
            Array.Resize(ref C, index);
            Array.Sort(C);

            var message = String.Join(", ", C);

            MessageBox.Show(message);
        }
    }
}
