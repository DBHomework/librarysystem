using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 subForm = new Form4();
            subForm.Owner = this;
            subForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 subForm = new Form5();
            subForm.Owner = this;
            subForm.Show();

        }
    }
}
