﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library
{
    public partial class Form9 : Form
    {
        private string rid;
        public static Form9 form = null;
        public Form9(string ridString)
        {
            rid = ridString;
            form = this;//用于返回
            InitializeComponent();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            Form10 subForm = new Form10();
            this.Hide();
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form11 subForm = new Form11(rid);
            this.Hide();
            subForm.Show();

        }*/

        private void Form9_Load(object sender, EventArgs e)
        {
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); 
        }

        public string getRid() {
            return rid;
        }

        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.YesNo)
                   == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void 查询图书信息_Click(object sender, EventArgs e)
        {// 查书
            Form10 subForm = new Form10();
            subForm.Show();
        }

        private void 添加书籍_Click(object sender, EventArgs e)
        {
            // 借书  
            Form10 subForm = new Form10();
            subForm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            // 借阅历史
            Form11 subForm = new Form11(rid);
            subForm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {   // 还书 
            Form12 subForm = new Form12();
            subForm.Show();
        }

        private void 查书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 subForm = new Form10();
            subForm.Show();
        }
        private void 借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //借书  
            Form10 subForm = new Form10();
            subForm.Show();
        }

        private void 借阅历史ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //借阅历史
            Form11 subForm = new Form11(rid);
            subForm.Show();
        }

        private void 归还图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {   //还书 
            Form12 subForm = new Form12();
            subForm.Show();
        }
     
        


    }
}
