using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models
{
    public class School
    {
        public int Id { get; set; }       //学校ID
        public string Name { get; set; }  //学校名称

        //一个学校可以有多个班级
        public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
