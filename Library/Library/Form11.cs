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
    public partial class Form11 : Form
    {
        public Form11(string rid)
        {
            InitializeComponent();
            // 初步显示数据
            string sql = "select bf.brid 书号 , bname 书名,bdate 借书日期,bterminaldate 应归还日期,returndate 归还日期,fine 罚款 from borinfotable bf,booktable bt where bf.brid = bt.bid and rrrid='"+rid+"'";
            bfdatalist.DataSource = OprSql.Queue(sql,"borinfo").Tables["borinfo"];

        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form9.form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
