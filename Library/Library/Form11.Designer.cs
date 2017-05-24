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
            ((System.ComponentModel.ISupportInitialize)(this.bfdatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(258, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "我的借阅记录";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bfdatalist
            // 
            this.bfdatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bfdatalist.Location = new System.Drawing.Point(38, 93);
            this.bfdatalist.Name = "bfdatalist";
            this.bfdatalist.RowTemplate.Height = 23;
            this.bfdatalist.Size = new System.Drawing.Size(616, 283);
            this.bfdatalist.TabIndex = 1;
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 397);
            this.Controls.Add(this.bfdatalist);
            this.Controls.Add(this.label1);
            this.Name = "Form11";
            this.Text = "我的借阅记录";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form11_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.bfdatalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bfdatalist;
    }
}