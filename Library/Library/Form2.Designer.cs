namespace Library
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除读者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.添加用户 = new System.Windows.Forms.ToolStripButton();
            this.查找书籍 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.添加书籍 = new System.Windows.Forms.ToolStripButton();
            this.查询借书记录 = new System.Windows.Forms.ToolStripButton();
            this.借书办理 = new System.Windows.Forms.ToolStripButton();
            this.还书办理 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(12, 338);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 64);
            this.button1.TabIndex = 0;
            this.button1.Text = "图书信息";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(184, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "读者信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 26);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询图书ToolStripMenuItem,
            this.添加图书ToolStripMenuItem,
            this.修改图书ToolStripMenuItem,
            this.删除图书ToolStripMenuItem});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // 查询图书ToolStripMenuItem
            // 
            this.查询图书ToolStripMenuItem.Name = "查询图书ToolStripMenuItem";
            this.查询图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查询图书ToolStripMenuItem.Text = "查询图书";
            // 
            // 添加图书ToolStripMenuItem
            // 
            this.添加图书ToolStripMenuItem.Name = "添加图书ToolStripMenuItem";
            this.添加图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加图书ToolStripMenuItem.Text = "添加图书";
            // 
            // 修改图书ToolStripMenuItem
            // 
            this.修改图书ToolStripMenuItem.Name = "修改图书ToolStripMenuItem";
            this.修改图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改图书ToolStripMenuItem.Text = "修改图书";
            // 
            // 删除图书ToolStripMenuItem
            // 
            this.删除图书ToolStripMenuItem.Name = "删除图书ToolStripMenuItem";
            this.删除图书ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除图书ToolStripMenuItem.Text = "删除图书";
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加读者ToolStripMenuItem,
            this.查询读者ToolStripMenuItem,
            this.修改信息ToolStripMenuItem,
            this.删除读者ToolStripMenuItem});
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 22);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            // 
            // 添加读者ToolStripMenuItem
            // 
            this.添加读者ToolStripMenuItem.Name = "添加读者ToolStripMenuItem";
            this.添加读者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加读者ToolStripMenuItem.Text = "添加读者";
            // 
            // 查询读者ToolStripMenuItem
            // 
            this.查询读者ToolStripMenuItem.Name = "查询读者ToolStripMenuItem";
            this.查询读者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.查询读者ToolStripMenuItem.Text = "查询读者";
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            // 
            // 删除读者ToolStripMenuItem
            // 
            this.删除读者ToolStripMenuItem.Name = "删除读者ToolStripMenuItem";
            this.删除读者ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除读者ToolStripMenuItem.Text = "删除读者";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加用户,
            this.查找书籍,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator1,
            this.添加书籍,
            this.查询借书记录,
            this.借书办理,
            this.还书办理,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 26);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(626, 61);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 添加用户
            // 
            this.添加用户.AutoSize = false;
            this.添加用户.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.添加用户.Image = ((System.Drawing.Image)(resources.GetObject("添加用户.Image")));
            this.添加用户.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.添加用户.Name = "添加用户";
            this.添加用户.Size = new System.Drawing.Size(49, 44);
            this.添加用户.Text = "添加用户";
            // 
            // 查找书籍
            // 
            this.查找书籍.AutoSize = false;
            this.查找书籍.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.查找书籍.Image = ((System.Drawing.Image)(resources.GetObject("查找书籍.Image")));
            this.查找书籍.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查找书籍.Name = "查找书籍";
            this.查找书籍.Size = new System.Drawing.Size(49, 44);
            this.查找书籍.Text = "查找书籍";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.AutoSize = false;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = global::Library.Properties.Resources.user_modify_48px_556807_easyicon_net;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(49, 44);
            this.toolStripButton7.Text = "用户信息修改";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.AutoSize = false;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::Library.Properties.Resources.Delete_group_256px_1186690_easyicon_net;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(49, 44);
            this.toolStripButton8.Text = "修改密码";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(7, 45);
            // 
            // 添加书籍
            // 
            this.添加书籍.AutoSize = false;
            this.添加书籍.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.添加书籍.Image = ((System.Drawing.Image)(resources.GetObject("添加书籍.Image")));
            this.添加书籍.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.添加书籍.Name = "添加书籍";
            this.添加书籍.Size = new System.Drawing.Size(49, 44);
            this.添加书籍.Text = "添加书籍";
            // 
            // 查询借书记录
            // 
            this.查询借书记录.AutoSize = false;
            this.查询借书记录.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.查询借书记录.Image = ((System.Drawing.Image)(resources.GetObject("查询借书记录.Image")));
            this.查询借书记录.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.查询借书记录.Name = "查询借书记录";
            this.查询借书记录.Size = new System.Drawing.Size(49, 44);
            this.查询借书记录.Text = "查询借书记录";
            // 
            // 借书办理
            // 
            this.借书办理.AutoSize = false;
            this.借书办理.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.借书办理.Image = global::Library.Properties.Resources.document_edit_modify_write_48px_1631_easyicon_net;
            this.借书办理.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.借书办理.Name = "借书办理";
            this.借书办理.Size = new System.Drawing.Size(49, 44);
            this.借书办理.Text = "借书办理";
            // 
            // 还书办理
            // 
            this.还书办理.AutoSize = false;
            this.还书办理.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.还书办理.Image = global::Library.Properties.Resources.address_book_delete_32px_7306_easyicon_net;
            this.还书办理.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.还书办理.Name = "还书办理";
            this.还书办理.Size = new System.Drawing.Size(49, 44);
            this.还书办理.Text = "还书办理";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(7, 45);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._14403fbc832b714af48f63cc7f53ab64;
            this.ClientSize = new System.Drawing.Size(626, 471);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "管理员身份";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除图书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除读者ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton 添加用户;
        private System.Windows.Forms.ToolStripButton 查找书籍;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 添加书籍;
        private System.Windows.Forms.ToolStripButton 查询借书记录;
        private System.Windows.Forms.ToolStripButton 借书办理;
        private System.Windows.Forms.ToolStripButton 还书办理;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}