using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.EF
{
    public class SchoolService
    {
        public void AddSchool(School school)
        {
            using (var context = new SchoolContext())
            {
                context.Schools.Add(school);
                context.SaveChanges();
            }
        }

        public List<School> GetAllSchools()
        {
            using (var context = new SchoolContext())
            {
                return context.Schools.ToList();
            }
        }

        public School GetSchoolById(int id)
        {
            using (var context = new SchoolContext())
            {
                return context.Schools.Find(id);
            }
        }

        public void UpdateSchool(School school)
        {
            using (var context = new SchoolContext())
            {
                context.Schools.Update(school);
                context.SaveChanges();
            }
        }

        public void DeleteSchool(int id)
        {
            using (var context = new SchoolContext())
            {
                var school = context.Schools.Find(id);
                if (school != null)
                {
                    context.Schools.Remove(school);
                    context.SaveChanges();
                }
            }
        }
    }
}
