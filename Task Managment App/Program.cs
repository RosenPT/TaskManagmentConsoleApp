using Task_Managment_App;


namespace TaskManagmentApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            DataBase dataBase = new DataBase();
            NewTask newTask = new NewTask("CleanPC2", "Clean PC 2 from viruses", new DateOnly(2025, 12, 21), false, "LOW");
            //dataBase.AddToDataBase(newTask);
            //NewTask newTask2 = new NewTask("CleanPC10", "Clean PC 10 from viruses", new DateOnly(2025, 11, 19), false, "LOW");
            //dataBase.AddToDataBase(newTask);

            List<string> tasks = dataBase.GetAllTasks();

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }

            ConsoleApp app = new ConsoleApp();
            app.Run(dataBase);
        }
    }
}