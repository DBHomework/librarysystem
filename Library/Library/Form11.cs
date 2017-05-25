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
            reflash();
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form9.form.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {   
            // 还书 
            int index = bfdatalist.CurrentRow.Index;    
            string bookid = bfdatalist.Rows[index].Cells[0].Value.ToString().Trim();
            string datetime = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd");
            
            string sql = "update borinfotable set returndate = '"+datetime+"' where rrrid ='"+Form9.form.getRid()+"' and brid = '"+bookid+"'";

            if (OprSql.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("还书成功！");
                reflash();
            }
            else
            {
                MessageBox.Show("还书失败！");
            }
        }

        public  void reflash()
        {
            string sql = "select bf.brid 书号 , bname 书名,bdate 借书日期,bterminaldate 应归还日期,returndate 归还日期,fine 罚款 from borinfotable bf,booktable bt where bf.returndate is null and bf.brid = bt.bid and rrrid='" + Form9.form.getRid() + "'";
            bfdatalist.DataSource = OprSql.Queue(sql, "borinfo").Tables["borinfo"];

            string hsql = "select bf.brid 书号 , bname 书名,bdate 借书日期,bterminaldate 应归还日期,returndate 归还日期,fine 罚款 from borinfotable bf,booktable bt where bf.returndate is not null and bf.brid = bt.bid and rrrid='" + Form9.form.getRid() + "'";

            hisdatalist.DataSource = OprSql.Queue(hsql, "hbortable").Tables["hbortable"];
        }
    }
}
