namespace StudentManagementSystem.WinForms
{
    partial class MainForm
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
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvSchools = new System.Windows.Forms.DataGridView();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblSchools = new System.Windows.Forms.Label();
            this.lblClasses = new System.Windows.Forms.Label();
            this.lblStudents = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(30, 20);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(120, 50);
            this.btnAddSchool.TabIndex = 0;
            this.btnAddSchool.Text = "添加学校";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(170, 20);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(120, 50);
            this.btnAddClass.TabIndex = 1;
            this.btnAddClass.Text = "添加班级";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(310, 20);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(120, 50);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "添加学生";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvSchools
            // 
            this.dgvSchools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchools.Location = new System.Drawing.Point(30, 100);
            this.dgvSchools.Name = "dgvSchools";
            this.dgvSchools.RowTemplate.Height = 30;
            this.dgvSchools.Size = new System.Drawing.Size(300, 400);
            this.dgvSchools.TabIndex = 3;
            // 
            // dgvClasses
            // 
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(350, 100);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RowTemplate.Height = 30;
            this.dgvClasses.Size = new System.Drawing.Size(300, 400);
            this.dgvClasses.TabIndex = 4;
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(670, 100);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowTemplate.Height = 30;
            this.dgvStudents.Size = new System.Drawing.Size(400, 400);
            this.dgvStudents.TabIndex = 5;
            // 
            // lblSchools
            // 
            this.lblSchools.AutoSize = true;
            this.lblSchools.Location = new System.Drawing.Point(30, 75);
            this.lblSchools.Name = "lblSchools";
            this.lblSchools.Size = new System.Drawing.Size(52, 20);
            this.lblSchools.TabIndex = 6;
            this.lblSchools.Text = "学校";
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(350, 75);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(52, 20);
            this.lblClasses.TabIndex = 7;
            this.lblClasses.Text = "班级";
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(670, 75);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(52, 20);
            this.lblStudents.TabIndex = 8;
            this.lblStudents.Text = "学生";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.lblSchools);
            this.Controls.Add(this.lblClasses);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.dgvSchools);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnAddSchool);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "MainForm";
            this.Text = "学生管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dgvSchools;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblSchools;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Label lblStudents;
    }
}

