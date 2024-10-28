using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.EF
{
    public class LogService
    {
        public void AddLog(Log log)
        {
            using (var context = new SchoolContext())
            {
                context.Logs.Add(log);
                context.SaveChanges();
            }
        }

        public List<Log> GetAllLogs()
        {
            using (var context = new SchoolContext())
            {
                return context.Logs.ToList();
            }
        }
    }
}
