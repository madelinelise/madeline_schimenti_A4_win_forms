using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace madeline_schimenti_A3_win_forms
{
    public partial class Form1 : Form
    {
        Numbers myNumbers = new Numbers();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxExponent_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClickPower_Click(object sender, EventArgs e)
        {
            int baseValue = Convert.ToInt32(textBoxBase.Text);
            int exponentValue = Convert.ToInt32(textBoxExponent.Text);

            int result = Numbers.Power(baseValue, exponentValue);
            labelPowerResult.Text = (baseValue + " to the power of " + exponentValue + " is " + result);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int count = 0; count < 10000; count++)
            {
                bool isPrime = Numbers.Prime(count);
                if (isPrime)
                {
                    listBoxPrime.Items.Add(count);

                }
            }

        }
    }
}
