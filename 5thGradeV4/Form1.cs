using System.Linq;
using System.Text;

namespace _5thGradeV4
{
    // public partial class Form1 : 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Translator_Click(object sender, EventArgs e)
        {
            char[] alphabet = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N' };
            string number = inputNumber.Text;
            int frominputSS;
            int fromoutputSS;
            // security
            if (number != "" && fromSS.Text != "" && toSS.Text != "")
            {
                frominputSS = Convert.ToInt32(fromSS.Text);
                fromoutputSS = Convert.ToInt32(toSS.Text);
                if (!(frominputSS > 1 && frominputSS < 51 && fromoutputSS > 1 && fromoutputSS < 51))
                {
                    MessageBox.Show("Неверная СС, введите от 2 до 50!");
                    return;
                }
                for (int i = 0; i < number.Length; i++)
                {
                    for (int j = 0; j < 50; j++)
                    {
                        if (number[i] == alphabet[j])
                        {
                            if (j > (frominputSS - 1))
                            {
                                MessageBox.Show("Число не соответствует СС");
                                return;
                            }
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
            // translate to 10-th
            int number10th = 0;
            int degree = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < 50; j++)
                {
                    if (number[i] == alphabet[j])
                    {
                        number10th += (int)(j * Math.Pow(frominputSS, degree));
                        degree++;
                        break;
                    }
                }
            }
            // to your ss
            string result = "";
            while (number10th != 0)
            {
                result = alphabet[number10th % fromoutputSS].ToString() + result;
                number10th = number10th / fromoutputSS;
            }
            textBox1.Text = "Результат: " + result;
            textBox2.Text = ($"{number[0] * 2 ^ 3} + {number[1] * 2 ^ 2}");

        }

        private void fromSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void toSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Калькулятор перевода из разных СС.\nYour Number - Ваше число. \nFrom SS - Из какой системы счисления переводить.\nInto SS - В какую систему счисления переводить.\nДиапазон от 2 до 50 СС.\nDesigned by Panov Stefan ПрИ-103");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}