namespace Library
{
    partial class Form11
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
            this.bfdatalist = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.hisdatalist = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bfdatalist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hisdatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "当前借阅";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bfdatalist
            // 
            this.bfdatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bfdatalist.Location = new System.Drawing.Point(38, 93);
            this.bfdatalist.Name = "bfdatalist";
            this.bfdatalist.RowTemplate.Height = 23;
            this.bfdatalist.Size = new System.Drawing.Size(608, 152);
            this.bfdatalist.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
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
            this.hisdatalist.Size = new System.Drawing.Size(608, 152);
            this.hisdatalist.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 27);
            this.button4.TabIndex = 15;
            this.button4.Text = "归还";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 512);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.hisdatalist);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bfdatalist);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button button4;
    }
}