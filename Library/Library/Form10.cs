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
    public partial class Form10 : Form
    {
        private string searchsql = null;
        public Form10()
        {
            InitializeComponent();
        }
        private void Form10_Load(object sender, EventArgs e)
        {
        }
        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form9.form.Show();
        }
        // 查询按钮
        private void button4_Click(object sender, EventArgs e)
        {
            searchsql = "select bid 书号, bname 书名 ,bpress 出版社, author 作者,bnum-bhbnum 可借 from booktable where bborrow=1 and bnum != 0"; //不显示不可借，书本被删除(书本数量为0)
            // 如果没有填写，默认查询所有的书本
            string temp = "";
            foreach(var t in this.Controls)
            {
                if(t is TextBox && !string.IsNullOrEmpty((t as TextBox).Text.Trim()))
                {
                    temp += "and "+(t as TextBox).Name.ToString()+" like '%"+
                           (t as TextBox).Text.Trim()+"%' ";
                }
            }
            searchsql += temp;
            datalist.DataSource = OprSql.Queue(searchsql, "searchtable").Tables["searchtable"];
        }

        private void button1_Click(object sender, EventArgs e)
        {   // 借阅
            //先判断借书是否到上限
            //判断是否有罚款 否提示交罚款 有借阅成功

            string readersql = "select * from readertable where rrid = '"+Form9.form.getRid()+"'";
            DataTable dreader = OprSql.Queue(readersql, "readertable").Tables["readertable"];

            if (int.Parse(dreader.Rows[0]["rbcnum"].ToString()) -
                int.Parse(dreader.Rows[0]["rbhnum"].ToString()) == 0) { 
                    // 到借阅上限，无法再借
                    MessageBox.Show("无法再借");
                    return; 
            }
            
            // 是否有罚款
            string sql = "select * from borinfotable where fine != 0 and rrrid='" +
                Form9.form.getRid() + "'";
            DataTable dt = OprSql.Queue(sql, "bortable").Tables["bortable"];
            if (dt.Rows.Count != 0) {
                MessageBox.Show("有罚款不能借阅");
                if (MessageBox.Show("是否提交罚款？", "提示", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    // 提交罚款后，将所有的罚款进行更新为0
                    string updateFine = "update  borinfotable set fine=0 where fine != 0 and rrrid='" + Form9.form.getRid() + "'";
                    if (OprSql.ExecuteSql(updateFine) > 0)
                    {
                        MessageBox.Show("交款成功!");
                    }
                    else {
                        MessageBox.Show("交款失败，请再次尝试!");
                    }
                }
                else {
                    // 拒绝提交罚款
                    return; 
                }
            }
            else
            {
                // 借书部分  
                if(datalist.CurrentRow == null)
                {
                    MessageBox.Show("请先查询！");
                    return;
                }
                int index = datalist.CurrentRow.Index;
                string bookid = datalist.Rows[index].Cells[0].Value.ToString().Trim();

                string nowString = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd");
                string terminalString = DateTime.Parse(DateTime.Now.AddDays(60).ToShortDateString()).ToString("yyyy-MM-dd");
                // 更改表，使得同一个人可以借多本书 
                string borsql = "insert into borinfotable(rrrid,brid,bdate,bterminaldate,returndate,fine)  values('" + Form9.form.getRid() + "','" + bookid + "','" + nowString + "','" +
                    terminalString+"',"+"null"+","+0+")";
                
                // 判断是否还有书本可借
                if (int.Parse(datalist.Rows[index].Cells[4].Value.ToString().Trim())==0)
                {
                    MessageBox.Show("此本书已经被借完，请等候！");
                    return;
                }
                try
                {
                    // 已经借阅，不可重复借阅
                    string hasborrow = "select * from borinfotable where rrrid='" + Form9.form.getRid() + "' and brid='" +
                        bookid + "' and returndate is null";
                    if (OprSql.Queue(hasborrow, "hasbortable").Tables["hasbortable"].Rows.Count != 0)
                    {
                        MessageBox.Show("您已经借过此书，为了保证资源合理利用，请借其他书");
                        return;
                    }
                    
                    if (OprSql.ExecuteSql(borsql) > 0)
                    {
                        MessageBox.Show("借书成功！");
                        datalist.DataSource = OprSql.Queue(searchsql, "searchtable").Tables["searchtable"];
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("借书失败!");
                }
               
            }
    
        }
    }
}
