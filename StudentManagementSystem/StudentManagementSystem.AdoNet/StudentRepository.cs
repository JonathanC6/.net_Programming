using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.AdoNet
{
    public class StudentRepository
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public void AddStudent(Student student)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Student (Name, Age, ClassId) VALUES (@Name, @Age, @ClassId)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@ClassId", student.ClassId);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Added student: {student.Name}");
        }

        public List<Student> GetAllStudents()
        {
            var students = new List<Student>();
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Student";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        students.Add(new Student
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Age = reader.GetInt32(2),
                            ClassId = reader.GetInt32(3)
                        });
                    }
                }
            }
            return students;
        }

        public void UpdateStudent(Student student)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Student SET Name = @Name, Age = @Age, ClassId = @ClassId WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", student.Name);
                    command.Parameters.AddWithValue("@Age", student.Age);
                    command.Parameters.AddWithValue("@ClassId", student.ClassId);
                    command.Parameters.AddWithValue("@Id", student.Id);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Updated student: {student.Name}");
        }

        public void DeleteStudent(int id)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Student WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Deleted student with ID: {id}");
        }

        private void LogAction(string action)
        {
            //可以调用 LogRepository 记录日志
        }
    }
}
