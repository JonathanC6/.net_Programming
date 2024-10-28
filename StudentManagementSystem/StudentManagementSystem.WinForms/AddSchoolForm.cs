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
    public partial class AddSchoolForm : Form
    {
        public AddSchoolForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new SchoolContext())
            {
                var school = new School
                {
                    Name = txtSchoolName.Text
                };

                context.Schools.Add(school);
                context.SaveChanges();
                MessageBox.Show("学校添加成功！");
                this.Close();
            }
        }
    }
}
