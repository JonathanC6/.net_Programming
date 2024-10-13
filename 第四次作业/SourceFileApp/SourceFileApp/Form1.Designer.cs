namespace SourceFileApp
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.txtStatistics = new System.Windows.Forms.TextBox();
            this.listWordFrequency = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(12, 12);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(120, 40);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "选择文件";
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // txtStatistics
            // 
            this.txtStatistics.Location = new System.Drawing.Point(12, 60);
            this.txtStatistics.Multiline = true;
            this.txtStatistics.Name = "txtStatistics";
            this.txtStatistics.ReadOnly = true;
            this.txtStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatistics.Size = new System.Drawing.Size(460, 143);
            this.txtStatistics.TabIndex = 1;
            // 
            // listWordFrequency
            // 
            this.listWordFrequency.ItemHeight = 15;
            this.listWordFrequency.Location = new System.Drawing.Point(12, 215);
            this.listWordFrequency.Name = "listWordFrequency";
            this.listWordFrequency.Size = new System.Drawing.Size(460, 304);
            this.listWordFrequency.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "C# Files|*.cs";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(484, 540);
            this.Controls.Add(this.listWordFrequency);
            this.Controls.Add(this.txtStatistics);
            this.Controls.Add(this.btnSelectFile);
            this.Name = "Form1";
            this.Text = "C# Source File App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.TextBox txtStatistics;
        private System.Windows.Forms.ListBox listWordFrequency;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

