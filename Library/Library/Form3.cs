﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;

namespace Library
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        static string ID;
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public static DataSet Query(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "booktable");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }

        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string bid = bid1.Text.Trim();
            string bname = bname1.Text.Trim();
            string author = author1.Text.Trim();
            string bpress = bpress1.Text.Trim();
            this.datalist.DataSource = Query("select bid 书号, bname 书名 ,bpress 出版社, author 作者,bnum 馆藏,bhbnum 可借,bborrow 是否可借 from booktable where bid like '%" + bid + "%'and bname like '%" + bname + "%'and author like '%" + author + "%'and bpress like '%" + bpress + "%'").Tables["booktable"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 subForm = new Form4();
            subForm.Owner = this;
            subForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = datalist.CurrentRow.Index;
            string bid = datalist.Rows[a].Cells[0].Value.ToString().Trim();
            string bname = datalist.Rows[a].Cells[1].Value.ToString().Trim();
            string bpress = datalist.Rows[a].Cells[2].Value.ToString().Trim();
            string author = datalist.Rows[a].Cells[3].Value.ToString().Trim();
            string bnum = datalist.Rows[a].Cells[4].Value.ToString().Trim();
            string bhbnum = datalist.Rows[a].Cells[5].Value.ToString().Trim();
            string bborrow = datalist.Rows[a].Cells[6].Value.ToString().Trim();
            Form5 subForm = new Form5(bid, bname, bpress, author,bnum,bhbnum,bborrow);
            subForm.Owner = this;
            subForm.Show();

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.form.Show();
        }

        private void datalist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = datalist.Rows[e.RowIndex].Cells["sid"].Value.ToString().Trim();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = datalist.CurrentRow.Index; //获取当前选中行
            string bid = datalist.Rows[a].Cells[0].Value.ToString().Trim();//获取该行第0列数据
            string sql = "delete from booktable where bid='" + bid + "'";

            if (ExecuteSql(sql) > 0)
            {
                MessageBox.Show("删除成功！");
            }

        }
    }
}
