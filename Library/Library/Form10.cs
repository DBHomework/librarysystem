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
            string sql = "select bid 书号, bname 书名 ,bpress 出版社, author 作者,bnum-bhbnum 可借 from booktable where bborrow=1 ";        
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
            datalist.DataSource = OprSql.Queue(sql+temp, "searchtable").Tables["searchtable"]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {// 借阅 先判断借书是否到上限，判断是否有罚款 否提示交罚款 有借阅成功
            string readersql = "select * from readertable where rrid = '"+Form9.form.getRid()+"'";
            DataTable dreader = OprSql.Queue(readersql, "readertable").Tables["readertable"];

            if (int.Parse(dreader.Rows[0]["rbcnum"].ToString()) -
                int.Parse(dreader.Rows[0]["rbhnum"].ToString()) == 0) { 
                    // 无法再借
                    MessageBox.Show("无法再借");
                    return; 
            }
            
            //  是否有罚款
            string sql = "select * from borinfotable where fine != 0 and rrrid='" +
                Form9.form.getRid() + "'";
            DataTable dt = OprSql.Queue(sql, "bortable").Tables["bortable"];
            if (dt.Rows.Count != 0) {
                MessageBox.Show("有罚款不能借阅");
                if (MessageBox.Show("是否提交罚款？", "提示", MessageBoxButtons.YesNo)
                    == DialogResult.Yes)
                {
                    // 提交罚款后，将所有的罚款进行更新
                    string updateFine = "update  borinfotable set fine=0 where fine != 0 and rrrid='" + Form9.form.getRid() + "'";
                    if (OprSql.ExecuteSql(updateFine) > 0)
                    {
                        MessageBox.Show("提交成功!");
                    }
                    else {
                        MessageBox.Show("提交失败，请再次尝试!");
                    }
                }
                else {
                    // 拒绝提交罚款
                    return; 
                }
            }
            else
            {
                int index = datalist.CurrentRow.Index;
                string bookid = datalist.Rows[index].Cells[0].Value.ToString().Trim();
                string nowString = DateTime.Parse(DateTime.Now.ToShortDateString()).ToString("yyyy-MM-dd");
                string terminalString = DateTime.Parse(DateTime.Now.AddDays(60).ToShortDateString()).ToString("yyyy-MM-dd");
                string borsql = "insert into borinfotable values('"+Form9.form.getRid()+"','"+bookid+"','"+nowString+"','"+
                    terminalString+"',"+"null"+","+0+")";
                try
                {
                    if (OprSql.ExecuteSql(borsql) > 0)
                    {
                        MessageBox.Show("借书成功！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("借书失败，不可重复借同一本书！");
                }
               
            }
    
        }
    }
}
