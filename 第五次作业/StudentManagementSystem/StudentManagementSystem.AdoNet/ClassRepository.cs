using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.AdoNet
{
    public class ClassRepository
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public void AddClass(Class classEntity)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Class (Name, SchoolId) VALUES (@Name, @SchoolId)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", classEntity.Name);
                    command.Parameters.AddWithValue("@SchoolId", classEntity.SchoolId);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Added class: {classEntity.Name}");
        }

        public List<Class> GetAllClasses()
        {
            var classes = new List<Class>();
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Class";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        classes.Add(new Class
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            SchoolId = reader.GetInt32(2)
                        });
                    }
                }
            }
            return classes;
        }

        public void UpdateClass(Class classEntity)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE Class SET Name = @Name, SchoolId = @SchoolId WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", classEntity.Name);
                    command.Parameters.AddWithValue("@SchoolId", classEntity.SchoolId);
                    command.Parameters.AddWithValue("@Id", classEntity.Id);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Updated class: {classEntity.Name}");
        }

        public void DeleteClass(int id)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Class WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Deleted class with ID: {id}");
        }

        private void LogAction(string action)
        {
            //可以调用 LogRepository 记录日志
        }
    }
}
