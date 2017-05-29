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
    public partial class Administrator : Form
    {
        public static Administrator form = null;
        public Administrator()
        {
            form = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            BooksManagement subForm = new BooksManagement();
            subForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReaderManagement subForm = new ReaderManagement();
            subForm.Show();

        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定退出？", "提示", MessageBoxButtons.YesNo)
                    == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 添加用户_Click(object sender, EventArgs e)
        {
            AddReader subForm = new AddReader();
            subForm.Show();
        }

        private void 查找书籍_Click(object sender, EventArgs e)
        {
            ReaderManagement subForm = new ReaderManagement();
            subForm.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            ReaderManagement subForm = new ReaderManagement();
            subForm.Show();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            ReaderManagement subForm = new ReaderManagement();
            subForm.Show();
        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 还书办理_Click(object sender, EventArgs e)
        {
            BooksManagement subForm = new BooksManagement();
            subForm.Owner = this;
            subForm.Show();
        }

        private void 添加书籍_Click(object sender, EventArgs e)
        {
            AddBook subForm = new AddBook();
            subForm.Owner = this;
            subForm.Show();
        }

        private void 查询图书信息_Click(object sender, EventArgs e)
        {
            BooksManagement subForm = new BooksManagement();
            subForm.Owner = this;
            subForm.Show();
        }

        private void 修改图书信息_Click(object sender, EventArgs e)
        {
            BooksManagement subForm = new BooksManagement();
            subForm.Owner = this;
            subForm.Show();
        }
    }
}
