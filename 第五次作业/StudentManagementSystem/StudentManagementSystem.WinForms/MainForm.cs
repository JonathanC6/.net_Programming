using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            var addSchoolForm = new AddSchoolForm();
            addSchoolForm.ShowDialog();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            var addClassForm = new AddClassForm();
            addClassForm.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addStudentForm = new AddStudentForm();
            addStudentForm.ShowDialog();
        }
    }
}
