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
    }
}
