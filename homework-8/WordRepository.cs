using System.Data.SQLite;

namespace WordLearner
{
    public class WordRepository
    {
        private readonly string _dbPath = "words.db";
        private readonly string _connectionString;

        public WordRepository()
        {
            _connectionString = $"Data Source={_dbPath};Version=3;";
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
                using var connection = new SQLiteConnection(_connectionString);
                connection.Open();
                
                var command = new SQLiteCommand(
                    "CREATE TABLE Words (Id INTEGER PRIMARY KEY AUTOINCREMENT, English TEXT NOT NULL, Chinese TEXT NOT NULL)",
                    connection);
                command.ExecuteNonQuery();

                // 插入一些示例数据
                var insertCommand = new SQLiteCommand(
                    @"INSERT INTO Words (English, Chinese) VALUES 
                    ('apple', '苹果'),
                    ('book', '书'),
                    ('computer', '电脑'),
                    ('student', '学生'),
                    ('teacher', '教师')",
                    connection);
                insertCommand.ExecuteNonQuery();
            }
        }

        public (string English, string Chinese)? GetRandomWord()
        {
            using var connection = new SQLiteConnection(_connectionString);
            connection.Open();
            
            var command = new SQLiteCommand(
                "SELECT English, Chinese FROM Words ORDER BY RANDOM() LIMIT 1",
                connection);

            using var reader = command.ExecuteReader();
            if (reader.Read())
            {
                return (reader.GetString(0), reader.GetString(1));
            }

            return null;
        }
    }
}