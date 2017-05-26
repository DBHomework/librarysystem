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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 subForm = new Form7();
            subForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int reader_datalist_index = reader_datalist.CurrentRow.Index;
            string rrid = reader_datalist.Rows[reader_datalist_index].Cells[0].Value.ToString().Trim();
            string rname = reader_datalist.Rows[reader_datalist_index].Cells[1].Value.ToString().Trim();
            string rsex = reader_datalist.Rows[reader_datalist_index].Cells[2].Value.ToString().Trim();
            string rbcnum = reader_datalist.Rows[reader_datalist_index].Cells[3].Value.ToString().Trim();
            string rbhnum = reader_datalist.Rows[reader_datalist_index].Cells[4].Value.ToString().Trim();
            string rwdep = reader_datalist.Rows[reader_datalist_index].Cells[5].Value.ToString().Trim();
            string rtel = reader_datalist.Rows[reader_datalist_index].Cells[6].Value.ToString().Trim();

            string sql_fetch_account_psw = "select account, psw from logintable where rid = '" + rrid + "'";

            string account = OprSql.Queue(sql_fetch_account_psw, "account and psw").Tables["account and psw"].Rows[0][0].ToString();

            string psw = OprSql.Queue(sql_fetch_account_psw, "account and psw").Tables["account and psw"].Rows[0][1].ToString();

            Form8 subForm = new Form8(rrid, rname, rsex, rbcnum, rbhnum, rwdep, rtel, account, psw);
            subForm.Owner = this;
            subForm.Show();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2.form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string rrid = textBox1.Text.Trim();
            string rname = textBox2.Text.Trim();
            string rsex = textBox3.Text.Trim();
            string rwdep = textBox6.Text.Trim();
            string rtel = textBox5.Text.Trim();
            string sql = "select * from readertable where rrid like '%" + rrid + "%' and (rname like '%" + rname + "%'or rname is NULL) and (rsex like '%" + rsex + "%' or rsex is NULL) and (rwdep like '%" + rwdep + "%' or rwdep is NULL) and (rtel like '%" + rtel + "%' or rtel is NULL)";

            this.reader_datalist.DataSource = OprSql.Queue(sql, "readers").Tables["readers"];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            string rrid = textBox1.Text.Trim();
            string rname = textBox2.Text.Trim();
            string rsex = textBox3.Text.Trim();
            string rwdep = textBox6.Text.Trim();
            string rtel = textBox5.Text.Trim();
            string sql = "select * from readertable where rrid like '%" + rrid + "%' and (rname like '%" + rname + "%'or rname is NULL) and (rsex like '%" + rsex + "%' or rsex is NULL) and (rwdep like '%" + rwdep + "%' or rwdep is NULL) and (rtel like '%" + rtel + "%' or rtel is NULL)";

            this.reader_datalist.DataSource = OprSql.Queue(sql, "readers").Tables["readers"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delete_readerlist_index = reader_datalist.CurrentRow.Index;
            string rrid = reader_datalist.Rows[delete_readerlist_index].Cells[0].Value.ToString();
            string sql_delete_logintable = "delete logintable where rid = '" + rrid + "'";
            string sql_delete_readertable = "delete readertable where rrid = '" + rrid + "'";
            OprSql.ExecuteSql(sql_delete_logintable);
            OprSql.ExecuteSql(sql_delete_readertable);
            MessageBox.Show("删除成功！");
        }
    }
}
