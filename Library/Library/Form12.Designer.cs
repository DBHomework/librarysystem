namespace Library
{
    partial class Form12
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form12));
            this.rb_bt = new System.Windows.Forms.Button();
            this.rbdatalist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rbdatalist)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_bt
            // 
            this.rb_bt.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rb_bt.BackgroundImage = global::Library.Properties.Resources.k144al3x5gs;
            this.rb_bt.Location = new System.Drawing.Point(299, 351);
            this.rb_bt.Name = "rb_bt";
            this.rb_bt.Size = new System.Drawing.Size(105, 31);
            this.rb_bt.TabIndex = 18;
            this.rb_bt.Text = "归还";
            this.rb_bt.UseVisualStyleBackColor = false;
            this.rb_bt.Click += new System.EventHandler(this.rb_bt_Click);
            // 
            // rbdatalist
            // 
            this.rbdatalist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rbdatalist.Location = new System.Drawing.Point(25, 74);
            this.rbdatalist.Name = "rbdatalist";
            this.rbdatalist.RowTemplate.Height = 23;
            this.rbdatalist.Size = new System.Drawing.Size(681, 252);
            this.rbdatalist.TabIndex = 17;
            this.rbdatalist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rbdatalist_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(33, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "请选择归还的图书:";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources._11;
            this.ClientSize = new System.Drawing.Size(718, 424);
            this.Controls.Add(this.rb_bt);
            this.Controls.Add(this.rbdatalist);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form12";
            this.Text = "归还图书";
            ((System.ComponentModel.ISupportInitialize)(this.rbdatalist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rb_bt;
        private System.Windows.Forms.DataGridView rbdatalist;
        private System.Windows.Forms.Label label1;
    }
}