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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("借书证号不能为空！");
                return;
            }

            string rrid = textBox1.Text.Trim();
            string rname = textBox2.Text.Trim();

            //性别默认为m
            string rsex = "m";
            if (textBox3.Text.Trim() != "f" && textBox3.Text.Trim() != "m")
                MessageBox.Show("无效性别，已设为默认值m");
            else if (textBox3.Text.Trim() != "f")
                rsex = "f";


            int rbcnum = 16;
            if (textBox7.Text.Trim() != "")
                rbcnum = int.Parse(textBox7.Text);
            int rbhnum = 0;
            if (textBox8.Text.Trim() != "")
                rbhnum = int.Parse(textBox8.Text);


            string rwdep = textBox6.Text.Trim();
            string rtel = textBox5.Text.Trim();
            string sql = "insert into readertable" +
                " values ('" + rrid + "', '" + rname + "', '" + rsex + "', "
                + rbcnum + ", " + rbhnum + ", '" + rwdep + "', '" + rtel + "')";

            OprSql.ExecuteSql(sql);
            this.Close();
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void textBox8_KeyPress_1(object sender, KeyPressEventArgs e)
        {
                if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                    e.Handled = true;
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("借书证号不能为空！");
                return;
            }

            string rrid = textBox1.Text.Trim();
            string rname = textBox2.Text.Trim();

            //性别默认为m
            string rsex = "m";
            if (textBox3.Text.Trim() != "f" && textBox3.Text.Trim() != "m")
                MessageBox.Show("无效性别，已设为默认值m");
            else if (textBox3.Text.Trim() != "f")
                rsex = "f";


            int rbcnum = 16;
            if (textBox7.Text.Trim() != "")
                rbcnum = int.Parse(textBox7.Text);
            int rbhnum = 0;
            if (textBox8.Text.Trim() != "")
                rbhnum = int.Parse(textBox8.Text);


            string rwdep = textBox6.Text.Trim();
            string rtel = textBox5.Text.Trim();
            string sql = "insert into readertable" +
                " values ('" + rrid + "', '" + rname + "', '" + rsex + "', "
                + rbcnum + ", " + rbhnum + ", '" + rwdep + "', '" + rtel + "')";

            OprSql.ExecuteSql(sql);
            this.Close();
        }
    }
}
