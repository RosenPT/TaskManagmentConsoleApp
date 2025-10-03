using Microsoft.VisualBasic;
using Npgsql;

namespace Task_Managment_App
{
    public class DataBase
    {
        private const string Connection = "Host=localhost;Username=postgres;Password=root;Database=TaskManagment";
        public async Task AddToDataBase(NewTask task)
        {
            using (var conn = new NpgsqlConnection(Connection))
            {
                await conn.OpenAsync();

                var querry = @"INSERT INTO ""Tasks"" (""Title"", ""Description"", ""DueDate"", ""IsComplete"", ""Priority"") 
                          VALUES (@title, @description, @due_date, @is_completed, @priority);";


                using (var cmd = new NpgsqlCommand(querry, conn))
                {
                    cmd.Parameters.AddWithValue("title", task.Title);
                    cmd.Parameters.AddWithValue("description", task.Description);
                    cmd.Parameters.AddWithValue("due_date", task.DueDate);
                    cmd.Parameters.AddWithValue("is_completed", task.IsCompleted);
                    cmd.Parameters.AddWithValue("priority", task.Priority);

                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        public List<string> GetAllTasks()
        {
            using (var conn = new NpgsqlConnection(Connection))
            {
                conn.Open();

                var querry = @"SELECT * FROM ""Tasks""";

                using (var cmd = new NpgsqlCommand(querry, conn))
                {
                    var reader = cmd.ExecuteReader();
                    List<string> tasks = new List<string>();
                    while (reader.Read())
                    {
                        string id = reader.GetInt32(0).ToString();
                        string Title = reader.GetString(1).ToString();
                        string Description = reader.GetString(2);
                        string Date = DateOnly.FromDateTime(reader.GetDateTime(3)).ToString();
                        string IsCompleted = reader.GetBoolean(4).ToString();
                        string Priority = reader.GetString(5);
                        tasks.Add($"{id} - {Title} - {Description} - {Date} - {IsCompleted} - {Priority}");
                    }

                    return tasks;
                }
            }
        }

        //public List<int> GetTaskId(NewTask task)
        //{
        //    using (var conn = new NpgsqlConnection(Connection))
        //    {
        //        conn.Open();
//
        //        var querry = @"SELECT ""Id"" FROM ""Tasks"" WHERE ""Title"" = @title ;""Description"" = @description ;""DueDate"" = @dueDate ;";
//
        //        using (var cmd = new NpgsqlCommand(querry, conn))
        //        {
        //            cmd.Parameters.AddWithValue("title", task.Title);
        //            cmd.Parameters.AddWithValue("description", task.Description);
        //            cmd.Parameters.AddWithValue("dueDate", task.DueDate);
//
        //            var reader = cmd.ExecuteReader();
        //            List<int> taskIds = new List<int>();
//
        //            while (reader.Read())
        //            {
        //                taskIds.Add(reader.GetInt32(0));
        //            }
//
        //            return taskIds;
        //        }
        //    }
//
        //}

        public async Task DeleteFromDataBase(NewTask task)
        {
            using (var conn = new NpgsqlConnection(Connection))
            {
                await conn.OpenAsync();

                var querry = @"DELETE FROM ""Tasks"" WHERE ";
            }
        }
    }
}