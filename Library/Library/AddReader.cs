using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class AddReader : Form
    {
        public AddReader()
        {
            InitializeComponent();
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_KeyPress_1(object sender, KeyPressEventArgs e)//输入的可解数量只能是数字
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
                e.Handled = true;             
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(add_reader_rrid.Text))
            {
                MessageBox.Show("借书证号不能为空！");
                return;
            }

            if (string.IsNullOrEmpty(add_reader_account.Text) || string.IsNullOrEmpty(add_reader_psw.Text))
            {
                MessageBox.Show("账号密码不能为空！");
                return;
            }

            string rrid = add_reader_rrid.Text.Trim();
            string rname = add_reader_rname.Text.Trim();


            //性别默认为m
            string rsex = "m";
            if (add_reader_rsex.Text.Trim() != "f" && add_reader_rsex.Text.Trim() != "m")
                MessageBox.Show("无效性别，已设为默认值m");
            else if (add_reader_rsex.Text.Trim() != "f")
                rsex = "f";


            int rbcnum = 16;
            if (add_reader_rbcnum.Text.Trim() != "")
                rbcnum = int.Parse(add_reader_rbcnum.Text);
            int rbhnum = 0;


            string rwdep = add_reader_rdep.Text.Trim();
            string rtel = add_reader_psw.Text.Trim();
            string sql = "insert into readertable(rrid, rname, rsex, rbcnum, rbhnum, rwdep, rtel)" +
                " values ('" + rrid + "', '" + rname + "', '" + rsex + "', "
                + rbcnum + ", " + rbhnum + ", '" + rwdep + "', '" + rtel + "')";

            //logintable
            string account = add_reader_account.Text.Trim();
            string psw = add_reader_psw.Text.Trim();
            int authority = 2;
            string rid = rrid;

            string sql_login = "insert into logintable(account, psw, authority, rid) " + 
                "values('" + account + "', '" + psw + "', " + authority + ", '" + rid + "')";
            try
            {
                OprSql.ExecuteSql(sql);
                OprSql.ExecuteSql(sql_login);
            }
            catch
            {
                MessageBox.Show("添加了重复的借书证号或账户名，新增失败");
                return;
            }
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
