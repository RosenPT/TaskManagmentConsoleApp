namespace Task_Managment_App
{
    public class ConsoleApp
    {
        public void Run(DataBase dataBase)
        {
            List<string> tasks1 = dataBase.GetAllTasks();
            while (true)
            {
                Console.WriteLine("---------------Welcome to Task Manager---------------");
                Console.WriteLine();
                Console.WriteLine("Choose option:");
            }
        }

        public void GoDown()
        {
            
        }
    }
}