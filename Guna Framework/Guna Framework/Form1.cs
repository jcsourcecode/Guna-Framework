using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guna_Framework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            ucManage1.BringToFront();
        }

        private void gunaPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
