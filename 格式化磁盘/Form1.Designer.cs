﻿namespace 格式化磁盘
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_磁盘 = new System.Windows.Forms.Button();
            this.cmb_磁盘 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_磁盘
            // 
            this.btn_磁盘.Location = new System.Drawing.Point(176, 12);
            this.btn_磁盘.Name = "btn_磁盘";
            this.btn_磁盘.Size = new System.Drawing.Size(75, 23);
            this.btn_磁盘.TabIndex = 0;
            this.btn_磁盘.Text = "格式化磁盘";
            this.btn_磁盘.UseVisualStyleBackColor = true;
            this.btn_磁盘.Click += new System.EventHandler(this.btn_磁盘_Click);
            // 
            // cmb_磁盘
            // 
            this.cmb_磁盘.FormattingEnabled = true;
            this.cmb_磁盘.Items.AddRange(new object[] {
            "A:",
            "B:",
            "C:",
            "D:",
            "E:",
            "F:",
            "G:",
            "H:"});
            this.cmb_磁盘.Location = new System.Drawing.Point(12, 12);
            this.cmb_磁盘.Name = "cmb_磁盘";
            this.cmb_磁盘.Size = new System.Drawing.Size(121, 20);
            this.cmb_磁盘.TabIndex = 1;
            this.cmb_磁盘.Text = "G:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 81);
            this.Controls.Add(this.cmb_磁盘);
            this.Controls.Add(this.btn_磁盘);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "格式化磁盘";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_磁盘;
        private System.Windows.Forms.ComboBox cmb_磁盘;
    }
}

