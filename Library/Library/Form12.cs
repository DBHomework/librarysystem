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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            reflash(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        public void reflash()
        {
            string sql = "select  bf.id 借阅单号,bf.brid 书号 , bname 书名,bdate 借书日期,bterminaldate 应归还日期,returndate 归还日期,fine 罚款 from borinfotable bf,booktable bt where bf.returndate is null and bf.brid = bt.bid and rrrid='" + Form9.form.getRid() + "'";
            DataTable dt1 = OprSql.Queue(sql, "borinfo").Tables["borinfo"];
            if (dt1.Rows.Count != 0)
            {
                rbdatalist.DataSource = dt1;
            }
        }

        private void rb_bt_Click(object sender, EventArgs e)
        {
            if (rbdatalist.CurrentRow == null)
            {
                MessageBox.Show("请正确选择你想还的书籍！");
                return;
            }
            int index = rbdatalist.CurrentRow.Index;
            string borid = rbdatalist.Rows[index].Cells[0].Value.ToString().Trim();
            string datetime = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd");
            string sql = "update borinfotable set returndate = '" + datetime + "' where id =" + borid;
            if (OprSql.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("还书成功！");
                rbdatalist.DataSource = null;// 清空图书 
                reflash();
            }
            else
            {
                MessageBox.Show("还书失败！");
            }
        }

        private void rbdatalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
