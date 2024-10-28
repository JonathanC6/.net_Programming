using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class Class
    {
        public int Id { get; set; }         //班级ID
        public string Name { get; set; }    //班级名称
        public int SchoolId { get; set; }   //所属学校ID

        //一个班级可以有多个学生
        public virtual ICollection<Student> Students { get; set; } = new List<Student>();

        //班级所属学校
        public virtual School School { get; set; }
    }
}
