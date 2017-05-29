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
    public partial class ModifyBookinfo : Form
    {
         public ModifyBookinfo(string bid, string bname, string bpress, string author,string bnum,string bhbnum,string bborrow)
        {
            InitializeComponent();
            bid1.Text = bid;
            bname1.Text = bname;
            bpress1.Text = bpress;
            author1.Text = author;
            bnum1.Text = bnum;
            bhbnum1.Text = bhbnum;
            bborrow1.Text = bborrow;
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bid = bid1.Text.Trim();
            string bname = bname1.Text.Trim();
            string author = author1.Text.Trim();
            string bpress = bpress1.Text.Trim();
            string bnum = bnum1.Text.Trim();
            string bhbnum = bhbnum1.Text.Trim();
            string bborrow = bhbnum1.Text.Trim();
            string sql = "update booktable set bname='" + bname + "',author='" + author + "',bpress='" + bpress + "',bnum='" + bnum + "',bhbnum='" + bhbnum + "',bborrow='" +bborrow + "'where bid='" + bid + "'";
            BooksManagement.ExecuteSql(sql);
            BooksManagement.form.reflash(); 
            this.Close();

        }
    }
}
