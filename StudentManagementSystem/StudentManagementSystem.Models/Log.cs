using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Log
    {
        public int Id { get; set; }                //日志ID
        public string Action { get; set; }         //用户操作描述
        public DateTime Timestamp { get; set; }    //操作时间
        public string User { get; set; }           //操作用户
    }
}
