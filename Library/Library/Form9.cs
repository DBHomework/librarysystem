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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 subForm = new Form10();
            subForm.Owner = this;
            subForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 subForm = new Form11();
            subForm.Owner = this;
            subForm.Show();

        }
    }
}
