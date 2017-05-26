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
    public partial class Form8 : Form
    {
        private int rbhnum_p;
        public Form8(string rrid, string rname, string rsex, string rbcnum, string rbhnum, string rwdep, string rtel, string account, string psw)
        {
            InitializeComponent();
            alter_reader_rid.Text = rrid;
            alter_reader_rname.Text = rname;
            alter_reader_rsex.Text = rsex;
            alter_reader_rbcnum.Text = rbcnum;
            alter_reader_rwdep.Text = rwdep;
            alter_reader_rtel.Text = rtel;
            alter_reader_account.Text = account;
            alter_reader_psw.Text = psw;
            rbhnum_p = int.Parse(rbhnum);
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void Alter_reader_btn(object sender, EventArgs e) {
            string rrid = alter_reader_rid.Text.Trim();
            string account = alter_reader_account.Text.Trim();
            string rsex = alter_reader_rsex.Text.Trim();
            int rbcnum = int.Parse(alter_reader_rbcnum.Text);
            string rname = alter_reader_rname.Text.Trim();
            string rwdep = alter_reader_rwdep.Text.Trim();
            string rtel = alter_reader_rtel.Text.Trim();
            string psw = alter_reader_psw.Text.Trim();
            int rbhnum = rbhnum_p;
            string sql_alter_readertable = "update readertable" +
                                                " set rname = '" + rname + "', rsex = " + "'" + rsex + "', rbcnum = " + rbcnum + ", rbhnum = " + rbhnum + ", rwdep = '" + rwdep + "', rtel = '" + rtel + "' where rrid = '" + rrid + "'";
            string sql_alter_logintable = "update logintable set account = '" + account + "', psw = '" + psw + "' where rid = '" + rrid + "'";
            try
            {
                OprSql.ExecuteSql(sql_alter_readertable);
                OprSql.ExecuteSql(sql_alter_logintable);
            }
            catch
            {
                MessageBox.Show("违反约束或与数据库连接失败，修改失败");
                return;
            }
            MessageBox.Show("修改成功");
            this.Close();
        }
    }
}
