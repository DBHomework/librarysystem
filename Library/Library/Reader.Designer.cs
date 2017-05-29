namespace Library
{
    partial class Reader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reader));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.我的图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅历史ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.查询图书信息 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.借书 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.借阅历史 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.还书 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书信息ToolStripMenuItem,
            this.我的图书ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 图书信息ToolStripMenuItem
            // 
            this.图书信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查书ToolStripMenuItem,
            this.借书ToolStripMenuItem});
            this.图书信息ToolStripMenuItem.Name = "图书信息ToolStripMenuItem";
            this.图书信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书信息ToolStripMenuItem.Text = "图书信息";
            // 
            // 查书ToolStripMenuItem
            // 
            this.查书ToolStripMenuItem.Name = "查书ToolStripMenuItem";
            this.查书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查书ToolStripMenuItem.Text = "查书";
            this.查书ToolStripMenuItem.Click += new System.EventHandler(this.查书ToolStripMenuItem_Click);
            // 
            // 借书ToolStripMenuItem
            // 
            this.借书ToolStripMenuItem.Name = "借书ToolStripMenuItem";
            this.借书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.借书ToolStripMenuItem.Text = "借书";
            this.借书ToolStripMenuItem.Click += new System.EventHandler(this.借书ToolStripMenuItem_Click);
            // 
            // 我的图书ToolStripMenuItem
            // 
            this.我的图书ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借阅历史ToolStripMenuItem,
            this.归还图书ToolStripMenuItem});
            this.我的图书ToolStripMenuItem.Name = "我的图书ToolStripMenuItem";
            this.我的图书ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.我的图书ToolStripMenuItem.Text = "我的图书";
            // 
            // 借阅历史ToolStripMenuItem
            // 
            this.借阅历史ToolStripMenuItem.Name = "借阅历史ToolStripMenuItem";
            this.借阅历史ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.借阅历史ToolStripMenuItem.Text = "借阅信息";
            this.借阅历史ToolStripMenuItem.Click += new System.EventHandler(this.借阅历史ToolStripMenuItem_Click);
            // 
            // 归还图书ToolStripMenuItem
            // 
            this.归还图书ToolStripMenuItem.Name = "归还图书ToolStripMenuItem";
            this.归还图书ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.归还图书ToolStripMenuItem.Text = "归还图书";
            this.归还图书ToolStripMenuItem.Click += new System.EventHandler(this.归还图书ToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询图书信息,
            this.toolStripSeparator2,
            this.借书,
            this.toolStripSeparator1,
            this.借阅历史,
            this.toolStripSeparator3,
            this.还书});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(673, 49);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 查询图书信息
            // 
            this.查询图书信息.AutoSize = false;
            this.查询图书信息.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.查询图书信息.Image = ((System.Drawing.Image)(resources.GetObject("查询图书信息.Image")));
            this.查询图书信息.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查询图书信息.Name = "查询图书信息";
            this.查询图书信息.Size = new System.Drawing.Size(49, 44);
            this.查询图书信息.Text = "查询图书信息";
            this.查询图书信息.Click += new System.EventHandler(this.查询图书信息_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(7, 45);
            // 
            // 借书
            // 
            this.借书.AutoSize = false;
            this.借书.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.借书.Image = global::Library.Properties.Resources.Library_Folder_black_128px_1062803_easyicon_net;
            this.借书.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.借书.Name = "借书";
            this.借书.Size = new System.Drawing.Size(49, 44);
            this.借书.Text = "借书";
            this.借书.Click += new System.EventHandler(this.添加书籍_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(7, 45);
            // 
            // 借阅历史
            // 
            this.借阅历史.AutoSize = false;
            this.借阅历史.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.借阅历史.Image = global::Library.Properties.Resources.Folder_Library_512px_1131431_easyicon_net;
            this.借阅历史.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.借阅历史.Name = "借阅历史";
            this.借阅历史.Size = new System.Drawing.Size(49, 44);
            this.借阅历史.Text = "借阅历史";
            this.借阅历史.Click += new System.EventHandler(this.toolStripButton8_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(7, 45);
            // 
            // 还书
            // 
            this.还书.AutoSize = false;
            this.还书.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.还书.Image = global::Library.Properties.Resources.images;
            this.还书.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.还书.Name = "还书";
            this.还书.Size = new System.Drawing.Size(49, 44);
            this.还书.Text = "书籍";
            this.还书.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.reading_books_1_;
            this.ClientSize = new System.Drawing.Size(673, 503);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form9";
            this.Text = "读者身份";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form9_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form9_FormClosed);
            this.Load += new System.EventHandler(this.Form9_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 我的图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅历史ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 还书;
        private System.Windows.Forms.ToolStripButton 借阅历史;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 借书;
        private System.Windows.Forms.ToolStripButton 查询图书信息;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}