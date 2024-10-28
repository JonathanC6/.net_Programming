using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.EF
{
    public class StudentService
    {
        public void AddStudent(Student student)
        {
            using (var context = new SchoolContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }

        public List<Student> GetAllStudents()
        {
            using (var context = new SchoolContext())
            {
                return context.Students.ToList();
            }
        }

        public Student GetStudentById(int id)
        {
            using (var context = new SchoolContext())
            {
                return context.Students.Find(id);
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var context = new SchoolContext())
            {
                context.Students.Update(student);
                context.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (var context = new SchoolContext())
            {
                var student = context.Students.Find(id);
                if (student != null)
                {
                    context.Students.Remove(student);
                    context.SaveChanges();
                }
            }
        }
    }
}
