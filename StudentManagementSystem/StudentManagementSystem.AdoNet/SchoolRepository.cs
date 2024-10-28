using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.AdoNet
{
    public class SchoolRepository
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public void AddSchool(School school)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO School (Name) VALUES (@Name)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", school.Name);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Added school: {school.Name}");
        }

        public List<School> GetAllSchools()
        {
            var schools = new List<School>();
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM School";
                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        schools.Add(new School
                        {
                            Id = reader.GetInt32(0),   //读取ID
                            Name = reader.GetString(1)  //读取Name
                        });
                    }
                }
            }
            return schools;
        }

        public void UpdateSchool(School school)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "UPDATE School SET Name = @Name WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", school.Name);
                    command.Parameters.AddWithValue("@Id", school.Id);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Updated school: {school.Name}");
        }

        public void DeleteSchool(int id)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM School WHERE Id = @Id";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }
            //记录日志的代码
            LogAction($"Deleted school with ID: {id}");
        }

        private void LogAction(string action)
        {
            //可以调用 LogRepository 记录日志
        }
    }
}
