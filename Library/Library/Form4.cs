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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string bid = bid1.Text.Trim();
            string bname = bname1.Text.Trim();
            string author = author1.Text.Trim();
            string bpress= bpress1.Text.Trim();
            string bnum = bnum1.Text.Trim();
            string bhbnum = bhbnum1.Text.Trim();
            string bborrow = bhbnum1.Text.Trim();
            string sql = "insert into booktable values('" + bid + "','" + bname + "','" + bpress + "','" + author + "','" + bnum + "','" + bhbnum + "','" + bborrow + "')";
            Form3.ExecuteSql(sql);
            this.Close();

        }
    }
}
