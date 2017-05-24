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
        private string rid;
        public static Form9 form = null;
        public Form9(string ridString)
        {
            rid = ridString;
            form = this;//用于返回
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //OprSql.ExecuteSql("select * from logintable");
            Form10 subForm = new Form10();
            this.Hide();
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 subForm = new Form11();
            this.Hide();
            subForm.Show();

        }

        private void Form9_Load(object sender, EventArgs e)
        {
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }
       
    }
}
