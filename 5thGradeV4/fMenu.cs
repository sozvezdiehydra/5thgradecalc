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
    public partial class fMenu : Form
    {
        Form1 fMain = new Form1();
        fRIM fRim = new fRIM();
        fETC fETC = new fETC();
        public fMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fMain.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fRim.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fETC.ShowDialog();
        }
    }
}
