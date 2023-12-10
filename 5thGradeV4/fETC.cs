using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5thGradeV4
{
    public partial class fETC : Form
    {
        public fETC()
        {
            InitializeComponent();
        }
            public static Dictionary<char, int> dictionaryInTen = new Dictionary<char, int>
                {
                    {'A', 10 },
                    {'B', 11 },
                    {'C', 12 },
                    {'D', 13 },
                    {'E', 14 },
                    {'F', 15 },
                    {'G', 16 },
                    {'H', 17 },
                    {'I', 18 },
                    {'J', 19 },
                    {'K', 20 },
                    {'L', 21 },
                    {'M', 22 },
                    {'N', 23},
                    {'O', 24 },
                    {'P', 25 },
                    {'Q', 26 },
                    {'R', 27},
                    {'S', 28},
                    {'T', 29},
                    {'U', 30},
                    {'V', 31},
                    {'W', 32},
                    {'X', 33},
                    {'Y', 34},
                    {'Z', 35},
                    {'a', 36},
                    {'b', 37},
                    {'c', 38},
                    {'d', 39},
                    {'e', 40},
                    {'f', 41},
                    {'g', 42},
                    {'h', 43},
                    {'i', 44},
                    {'j', 45},
                    {'k', 46},
                    {'m', 47},
                    {'n', 48},
                    {'t', 49},
                    {'0', 0},
                    {'1', 1},
                    {'2', 2},
                    {'3', 3},
                    {'4', 4},
                    {'5', 5},
                    {'6', 6},
                    {'7', 7},
                    {'8', 8},
                    {'9', 9},
                };

            public static Dictionary<double, char> dictionaryOutTen = new Dictionary<double, char>
                {
                    {0,'0'},
                    {1,'1'},
                    { 2,'2'},
                    { 3,'3'},
                    { 4,'4'},
                    { 5,'5'},
                    { 6,'6'},
                    { 7,'7'},
                    { 8,'8'},
                    { 9,'9'},
                    { 10,'A'},
                    { 11,'B'},
                    { 12,'C'},
                    { 13,'D'},
                    { 14,'E'},
                    { 15,'F'},
                    { 16,'G'},
                    { 17,'H'},
                    { 18,'I'},
                    { 19,'J'},
                    { 20,'K'},
                    { 21,'L'},
                    { 22,'M'},
                    { 23,'N'},
                    { 24,'O'},
                    { 25,'P'},
                    { 26,'Q'},
                    { 27,'R'},
                    { 28,'S'},
                    { 29,'T'},
                    { 30,'U'},
                    { 31,'V'},
                    { 32,'W'},
                    { 33,'X'},
                    { 34,'Y'},
                    { 35,'Z'},
                    { 36,'a'},
                    { 37,'b'},
                    { 38,'c'},
                    { 39,'d'},
                    { 40,'e'},
                    { 41,'f'},
                    { 42,'g'},
                    { 43,'h'},
                    { 44,'i'},
                    { 45,'j'},
                    { 46,'k'},
                    { 47,'m'},
                    { 48,'n'},
                    { 49,'t'},
                };

            private void button1_Click(object sender, EventArgs e)
                {

                        static string Printing(int[] inp)
                        {
                            StringBuilder sb = new StringBuilder();
                            for (int i = 0; i < inp.Length; i++)
                            {
                                if (i != inp.Length - 1)
                                {
                                    sb.Append(dictionaryOutTen[inp[i]]);
                                }
                                else
                                {
                                    break;
                                }
                            }
                            return sb.ToString();
                        }

                        string num1 = textBox1.Text;
                        string num2 = textBox2.Text;
                        string ccn = textBox3.Text;
                        int cc = Convert.ToInt32(ccn);

                        StringBuilder str = new StringBuilder();
                        StringBuilder help = new StringBuilder();
                        label1.Text = "Сумма во всех СС считается одинаково. Мы начиная с единиц складываем все цифры и если их сумма превысила СС то мы количество поместившихся в этом избытке СС переносим в следующий разряд, а остаток пишем в итоговое число.";
                        int len1 = num1.Length;
                        int len2 = num2.Length;
                        int mLen = Math.Abs(len1 - len2);
                        string mainStr;
                        string lowStr;
                        if (len1 > len2)
                        {
                            mainStr = num1;
                            for (int n = 0; n < mLen; n++)
                            {
                                help.Append('0');
                            }
                            help.Append(num2);
                            lowStr = help.ToString();
                        }
                        else if (len2 != len1)
                        {
                            mainStr = num2;
                            for (int n = 0; n < mLen; n++)
                            {
                                help.Append('0');
                            }
                            help.Append(num1);
                            lowStr = help.ToString();
                        }
                        else
                        {
                            mainStr = num1;
                            lowStr = num2;
                        }
                        int[] reserve = new int[mainStr.Length + 2];
                        int[] result = new int[mainStr.Length + 2];
                        label1.Text = ("Далее в расчётах над верхним числом будет идти ряд для переноса.");
                        label1.Text = ($"    {Printing(reserve)}");
                        label2.Text = ($"    {mainStr}");
                        label3.Text = ($"    {lowStr}");

                        for (int i = mainStr.Length - 1; i >= 0; i--)
                        {
                            int n1 = dictionaryInTen[mainStr[i]];
                            int n2;
                            if (lowStr[i] == ' ')
                            {
                                n2 = 0;
                            }
                            else
                            {
                                n2 = dictionaryInTen[lowStr[i]];
                            }
                            int n3 = n1 + n2 + reserve[i + 1];
                            if (n3 >= cc)
                            {
                                reserve[i] = (int)(n3 / cc);
                                n3 = n3 - reserve[i] * cc;
                            }
                            label1.Text = ($"Складывем {mainStr[i]} и {lowStr[i]}");
                            label2.Text = ($"    {Printing(reserve)}");
                            label3.Text = ($"    {mainStr}");
                            label4.Text = ($"    {lowStr}");
                            result[i] = n3;
                            label1.Text = ($"    {Printing(result)}");

                        }
                        textBox4.Text = ($"В результате получаем: {Printing(result)}");
                }
                private void textBox1_TextChanged(object sender, EventArgs e)
                {

                }

                private void textBox3_TextChanged(object sender, EventArgs e)
                {

                }

                private void textBox2_TextChanged(object sender, EventArgs e)
                {

                }

                private void textBox4_TextChanged(object sender, EventArgs e)
                {

                }

                private void textBox5_TextChanged(object sender, EventArgs e)
                {

                }

                private void label1_Click(object sender, EventArgs e)
                {
                }

                private void label2_Click(object sender, EventArgs e)
                {

                }

    }
}
