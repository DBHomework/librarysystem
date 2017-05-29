namespace Library
{
    partial class BooksManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksManagement));
            this.datalist = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bid1 = new System.Windows.Forms.TextBox();
            this.bname1 = new System.Windows.Forms.TextBox();
            this.author1 = new System.Windows.Forms.TextBox();
            this.bpress1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).BeginInit();
            this.SuspendLayout();
            // 
            // datalist
            // 
            this.datalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalist.Location = new System.Drawing.Point(62, 89);
            this.datalist.Name = "datalist";
            this.datalist.RowTemplate.Height = 23;
            this.datalist.Size = new System.Drawing.Size(535, 217);
            this.datalist.TabIndex = 0;
            this.datalist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalist_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(536, 328);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(63, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "修改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(522, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 27);
            this.button4.TabIndex = 4;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "书号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(60, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(281, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "作者：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(265, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "出版社：";
            // 
            // bid1
            // 
            this.bid1.Location = new System.Drawing.Point(111, 23);
            this.bid1.Name = "bid1";
            this.bid1.Size = new System.Drawing.Size(119, 21);
            this.bid1.TabIndex = 9;
            // 
            // bname1
            // 
            this.bname1.Location = new System.Drawing.Point(111, 58);
            this.bname1.Name = "bname1";
            this.bname1.Size = new System.Drawing.Size(119, 21);
            this.bname1.TabIndex = 10;
            // 
            // author1
            // 
            this.author1.Location = new System.Drawing.Point(343, 22);
            this.author1.Name = "author1";
            this.author1.Size = new System.Drawing.Size(119, 21);
            this.author1.TabIndex = 11;
            // 
            // bpress1
            // 
            this.bpress1.Location = new System.Drawing.Point(343, 58);
            this.bpress1.Name = "bpress1";
            this.bpress1.Size = new System.Drawing.Size(119, 21);
            this.bpress1.TabIndex = 12;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(664, 367);
            this.Controls.Add(this.bpress1);
            this.Controls.Add(this.author1);
            this.Controls.Add(this.bname1);
            this.Controls.Add(this.bid1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.datalist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "图书信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datalist;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bid1;
        private System.Windows.Forms.TextBox bname1;
        private System.Windows.Forms.TextBox author1;
        private System.Windows.Forms.TextBox bpress1;
    }
}