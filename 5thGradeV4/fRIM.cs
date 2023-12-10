using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5thGradeV4
{
    public partial class fRIM : Form
    {
        public fRIM()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numberRimInput = textBox3.Text;
            int numberRim = Convert.ToInt32(numberRimInput);

            if (numberRim < 0 || numberRim > 3999)
            {
                throw new ArgumentException("Число должно быть не менее 0 и не более 3999!");
            }

            if (numberRim == 0)
            {
                return;
            }

            int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] numerals = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            StringBuilder resultRim = new StringBuilder();
            for (int i = 0; i < 13; i++)
            {
                while (numberRim >= values[i])
                {
                    numberRim -= values[i];
                    resultRim.Append(numerals[i]);
                }
            }
            textBox1.Text = "Result: " + resultRim;
        }
    }
}
