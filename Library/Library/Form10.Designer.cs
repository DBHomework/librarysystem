﻿namespace Library
{
    partial class Form10
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bid = new System.Windows.Forms.TextBox();
            this.bname = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.bpress = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.datalist = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(107, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "书号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(107, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(302, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(286, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "出版社：";
            // 
            // bid
            // 
            this.bid.Location = new System.Drawing.Point(158, 43);
            this.bid.Name = "bid";
            this.bid.Size = new System.Drawing.Size(119, 21);
            this.bid.TabIndex = 10;
            // 
            // bname
            // 
            this.bname.Location = new System.Drawing.Point(158, 89);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(119, 21);
            this.bname.TabIndex = 11;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(351, 42);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(119, 21);
            this.author.TabIndex = 12;
            // 
            // bpress
            // 
            this.bpress.Location = new System.Drawing.Point(351, 89);
            this.bpress.Name = "bpress";
            this.bpress.Size = new System.Drawing.Size(119, 21);
            this.bpress.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 43);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 27);
            this.button4.TabIndex = 14;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // datalist
            // 
            this.datalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalist.Location = new System.Drawing.Point(43, 135);
            this.datalist.Name = "datalist";
            this.datalist.RowTemplate.Height = 23;
            this.datalist.Size = new System.Drawing.Size(598, 249);
            this.datalist.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(507, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 27);
            this.button1.TabIndex = 16;
            this.button1.Text = "借阅";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datalist);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bpress);
            this.Controls.Add(this.author);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.bid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form10";
            this.Text = "图书信息查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form10_FormClosed);
            this.Load += new System.EventHandler(this.Form10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bid;
        private System.Windows.Forms.TextBox bname;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox bpress;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView datalist;
        private System.Windows.Forms.Button button1;
    }
}