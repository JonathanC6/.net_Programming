using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }        //学生ID
        public string Name { get; set; }   //学生姓名
        public int Age { get; set; }       //学生年龄
        public int ClassId { get; set; }   //所属班级ID

        //学生所属班级
        public virtual Class Class { get; set; }
    }
}
