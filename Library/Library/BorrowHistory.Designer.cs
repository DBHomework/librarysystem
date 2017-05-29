namespace Library
{
    partial class BorrowHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowHistory));
            this.label1 = new System.Windows.Forms.Label();
            this.bfdatalist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.hisdatalist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bfdatalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisdatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前借阅";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bfdatalist
            // 
            this.bfdatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bfdatalist.Location = new System.Drawing.Point(38, 75);
            this.bfdatalist.Name = "bfdatalist";
            this.bfdatalist.RowTemplate.Height = 23;
            this.bfdatalist.Size = new System.Drawing.Size(684, 186);
            this.bfdatalist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "借阅历史";
            // 
            // hisdatalist
            // 
            this.hisdatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hisdatalist.Location = new System.Drawing.Point(38, 313);
            this.hisdatalist.Name = "hisdatalist";
            this.hisdatalist.RowTemplate.Height = 23;
            this.hisdatalist.Size = new System.Drawing.Size(684, 177);
            this.hisdatalist.TabIndex = 3;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.k144al3x5gs;
            this.ClientSize = new System.Drawing.Size(760, 526);
            this.Controls.Add(this.hisdatalist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bfdatalist);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form11";
            this.Text = "我的借阅记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bfdatalist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisdatalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bfdatalist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView hisdatalist;
    }
}