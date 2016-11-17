# FizzBuzz
My solution to a common interview programming question.  Show numbers from 1 to 100, but display Buzz for multiples of 3, Fizz for multiples of 5 and FizzBuzz for multiples of both.  Output can be seen in OutputFizzBuzz.pdf.  

Main code is in FizzBuzz.cs


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class FizzBuzz : Form
    {
        public FizzBuzz()
        {
            InitializeComponent();
        }

        private void FizzBuzz_Load(object sender, EventArgs e)
        {
            //Loop through integers from 1 to 100
            for (int i=1; i < 101; i++)
            {
                //Check for multiples of both 3 and 5 first
                if (i % 3 == 0 && i % 5 == 0)
                {
                    txtBxNumbers.Text += "FizzBuzz";
                }
                //Otherwise, check for each separately
                else if (i % 3 == 0)
                {
                    txtBxNumbers.Text += "Buzz";
                }
                else if (i % 5 == 0)
                {
                    txtBxNumbers.Text += "Fizz";
                }
                else
                {
                    txtBxNumbers.Text += i.ToString();
                }     
                //A lilne return makes the output more easily readable           
                txtBxNumbers.Text += "\r\n";  
            }

        }
    }
}
