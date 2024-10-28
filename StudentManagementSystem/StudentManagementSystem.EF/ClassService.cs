using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.EF
{
    public class ClassService
    {
        public void AddClass(Class classEntity)
        {
            using (var context = new SchoolContext())
            {
                context.Classes.Add(classEntity);
                context.SaveChanges();
            }
        }

        public List<Class> GetAllClasses()
        {
            using (var context = new SchoolContext())
            {
                return context.Classes.ToList();
            }
        }

        public Class GetClassById(int id)
        {
            using (var context = new SchoolContext())
            {
                return context.Classes.Find(id);
            }
        }

        public void UpdateClass(Class classEntity)
        {
            using (var context = new SchoolContext())
            {
                context.Classes.Update(classEntity);
                context.SaveChanges();
            }
        }

        public void DeleteClass(int id)
        {
            using (var context = new SchoolContext())
            {
                var classEntity = context.Classes.Find(id);
                if (classEntity != null)
                {
                    context.Classes.Remove(classEntity);
                    context.SaveChanges();
                }
            }
        }
    }
}
