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
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
            LoadSchools();
        }

          private void LoadSchools()
        {
            using (var context = new SchoolContext())
            {
                var schools = context.Schools.ToList();
                cmbSchool.DataSource = schools;
                cmbSchool.DisplayMember = "Name";
                cmbSchool.ValueMember = "Id";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var classEntity = new Class
                {
                    Name = txtClassName.Text,
                    SchoolId = (int)cmbSchool.SelectedValue
                };

                context.Classes.Add(classEntity);
                context.SaveChanges();
                MessageBox.Show("班级添加成功！");
                this.Close();
            }
        }
    }
}
