namespace Task_Managment_App
{
    public class ConsoleApp
    {
        public void Run(DataBase dataBase)
        {
            int pos = 0; // pos to go trough options
            string[] options = { "Show Task", "Create Task", "Edit Task", "Delete Task", "Back", "Exit" };
            Options ChosenOption;
            Menus menus = Menus.Main_menu;
            List<NewTask> tasks = dataBase.GetAllTasks();


            MainMenu(pos, options); //Startup menu
            while (true)
            {
                ConsoleKeyInfo keyInput = Console.ReadKey();
                switch (menus)
                {
                    case Menus.Main_menu:
                        MainMenu(pos, options);
                        break;

                    case Menus.Show_tasks_menu:
                        break;

                    case Menus.Edit_task_menu:
                        break;

                    case Menus.Delete_task_menu:
                        break;
                    //default:
                }
            }
        }

        public void MainMenu(int pos, string[] options)
        {
            Console.WriteLine("---------------Welcome to Task Manager---------------");
            Console.WriteLine();
            Console.WriteLine("Choose option:");
            Console.WriteLine();
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i] == options[pos])
                {
                    Console.WriteLine($" > {options[pos]}");
                }
                else
                {
                    Console.WriteLine(options[i]);
                }
            }
            Console.WriteLine();
        }

        public void ShowTask(List<NewTask> tasks, DataBase dataBase)
        {
            foreach (var task in tasks)
            {
                if (dataBase.GetTaskId(task).Count > 1)
                {
                    for (int i = 0; i < dataBase.GetTaskId(task).Count; i++)
                    {
                        Console.WriteLine($"{dataBase.GetTaskId(task)[i]} - {task}");
                    }
                }
                else
                {
                    int id = dataBase.GetTaskId(task)[0];
                    Console.WriteLine($"{id} - {task}");
                }
            }
        }
        public void MakeTask()
        {

        }
    }
}