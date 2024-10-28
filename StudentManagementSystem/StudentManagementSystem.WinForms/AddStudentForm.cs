using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.EF;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.WinForms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
            LoadClasses();
        }
 
          private void LoadClasses()
        {
            using (var context = new SchoolContext())
            {
                var classes = context.Classes.ToList();
                cmbClass.DataSource = classes;
                cmbClass.DisplayMember = "Name";
                cmbClass.ValueMember = "Id";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var student = new Student
                {
                    Name = txtStudentName.Text,
                    ClassId = (int)cmbClass.SelectedValue
                };

                context.Students.Add(student);
                context.SaveChanges();
                MessageBox.Show("学生添加成功！");
                this.Close();
            }
        }
    }
}
