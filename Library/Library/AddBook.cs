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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bid = bid1.Text.Trim();
            string bname = bname1.Text.Trim();
            string author = author1.Text.Trim();
            string bpress= bpress1.Text.Trim();
            string bnum = bnum1.Text.Trim();
            string bhbnum = bhbnum1.Text.Trim();
            string bborrow = bhbnum1.Text.Trim();
            if (bid == "" || bname == ""||author == ""||bpress == ""||bnum == ""||bhbnum == ""||bborrow =="")
            {
                MessageBox.Show("图书信息必须齐全！");
                return;
            }
            string sqlSearch = "select * from booktable where bid='" + bid +
               "'";
            DataTable dt = OprSql.Queue(sqlSearch, "logintable").Tables["logintable"];
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("图书信息输入错误！");
                bid1.Text = "";
                bname1.Text = "";
                bpress1.Text = "";
                author1.Text = "";
                bnum1.Text = "";
                bhbnum1.Text = "";
                bborrow1.Text = "";
                return;

            }
            else
            {
                string sql = "insert into booktable values('" + bid + "','" + bname + "','" + bpress + "','" + author + "','" + bnum + "','" + bhbnum + "','" + bborrow + "')";
                BooksManagement.ExecuteSql(sql);
                this.Close();
            }

        }
    }
}
