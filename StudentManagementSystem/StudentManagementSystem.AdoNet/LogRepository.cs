using StudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.AdoNet
{
    public class LogRepository
    {
        private DatabaseHelper _dbHelper = new DatabaseHelper();

        public void LogAction(Log log)
        {
            using (var connection = _dbHelper.GetConnection())
            {
                connection.Open();
                string query = "INSERT INTO Log (Action, Timestamp) VALUES (@Action, @Timestamp)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Action", log.Action);
                    command.Parameters.AddWithValue("@Timestamp", log.Timestamp);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
