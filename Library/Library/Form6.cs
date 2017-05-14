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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 subForm = new Form7();
            subForm.Owner = this;
            subForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form8 subForm = new Form8();
            subForm.Owner = this;
            subForm.Show();

        }
    }
}
