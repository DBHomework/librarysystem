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
    public partial class BorrowHistory : Form
    {
        public BorrowHistory(string rid)
        {
            InitializeComponent();
            // 初步显示数据
            reflash();
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Reader.form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

       /* private void button4_Click(object sender, EventArgs e)
        {   
            // 还书 
            if (bfdatalist.CurrentRow == null)
            {
                MessageBox.Show("请正确选择你想还的书籍！");
                return;
            }
            int index = bfdatalist.CurrentRow.Index;    
            string borid = bfdatalist.Rows[index].Cells[0].Value.ToString().Trim(); 
            string datetime = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd");
            string sql = "update borinfotable set returndate = '"+datetime+"' where id ="+borid;
            if (OprSql.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("还书成功！");
                reflash();
            }
            else
            {
                MessageBox.Show("还书失败！");
            }
        }*/

        public  void reflash()
        {
            string sql = "select bf.id 借阅单号,bf.brid 书号 , bname 书名,bdate 借书日期,bterminaldate 应归还日期,returndate 归还日期,fine 罚款 from borinfotable bf,booktable bt where bf.returndate is null and bf.brid = bt.bid and rrrid='" + Reader.form.getRid() + "'";
            DataTable dt1 = OprSql.Queue(sql, "borinfo").Tables["borinfo"];
            if(dt1.Rows.Count != 0)
            {
                bfdatalist.DataSource = dt1;
            }

            string hsql = "select bf.id 借阅单号,bf.brid 书号 , bname 书名,bdate 借书日期,bterminaldate 应归还日期,returndate 归还日期,fine 罚款 from borinfotable bf,booktable bt where bf.returndate is not null and bf.brid = bt.bid and rrrid='" + Reader.form.getRid() + "'";
           
            DataTable dt2 = OprSql.Queue(hsql, "hbortable").Tables["hbortable"];
            if(dt2.Rows.Count != 0)
            {
                hisdatalist.DataSource = dt2;
            }
        }
    }
}
