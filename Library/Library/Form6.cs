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
            Form8 subForm = new Form8();
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

            this.dataGridView1.DataSource = OprSql.Queue(sql, "readers").Tables["readers"];
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

            this.dataGridView1.DataSource = OprSql.Queue(sql, "readers").Tables["readers"];
        }
    }
}
