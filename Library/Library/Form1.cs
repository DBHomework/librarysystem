using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 登录按钮 
         * 
         * 1.验证用户名和密码中的信息，主要是是否存在空值的情况，给出提示
         * 
         * 2.查询相关的数据库中的信息，看又没有相关的用户，没有给出提示 
         * 
         * 3. 否则跳转到相应的Form中
         */
        private void button1_Click(object sender, EventArgs e)
        {

            //1. 获取相关的信息验证
            string ln = loginname.Text.Trim();
            string pw = psw.Text.Trim();

            if(ln == "" || pw == "")
            {
                MessageBox.Show("账号密码不能为空");
                return;
            }

            string sqlSearch = "select * from logintable where account='" + ln +
                "' and psw='" + pw+"'";
            DataTable dt = OprSql.Queue(sqlSearch, "logintable").Tables["logintable"];
            if (dt.Rows.Count == 0) {
                MessageBox.Show("账号或者密码错误！");
                return;
            }
            else
            {
                DataRow dr = dt.Rows[0];
                if (int.Parse(dr["authority"].ToString()) == 1)
                { //如果是1进入管理员 2进入读者
                    Form2 subForm = new Form2();
                    this.Hide();
                    subForm.Show();
                    
                }
                else
                {
                    Form9 readerForm = new Form9(dr["rid"].ToString());
                    this.Hide();
                    readerForm.Show();
                }
            }
        }
    }

    // 同一调用此类和数据库进行交互
    // 采用静态调用 
    // 例如 OprSql.XXX();
    class OprSql 
    {
        static string connectionString = System.Configuration.ConfigurationSettings.AppSettings["connectionString"];
        
        // 执行查询语句
        // sql 为查询的sql 语句,tableName为结果的表的名字

        public static DataSet Queue(string sql,string tableName) {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql,con);
            DataSet dataSet = new DataSet();
            try
            {
                con.Open();
                sda.Fill(dataSet, tableName);
                return dataSet;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally {
                sda.Dispose();//销毁对象，垃圾回收   
                con.Close();
            }
        }
        // 执行sql语句
        public static int ExecuteSql(String sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);// 执行命令
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
    }
   
}
