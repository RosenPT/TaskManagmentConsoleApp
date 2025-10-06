namespace Task_Managment_App
{
    public class ConsoleApp
    {
        public void Run(DataBase dataBase)
        {
            int pos = 0; // pos to go trough options
            string[] options = { "Show Task", "Create Task", "Edit Task", "Delete Task", "Back", "Exit" };
            Options ChosenOption;
            Menus menu = Menus.Main_menu;
            List<NewTask> tasks = dataBase.GetAllTasks();


            MainMenu(pos, options); //Startup menu
            while (true)
            {
                switch (menu)
                {
                    case Menus.Main_menu:
                        ConsoleKeyInfo keyInput = Console.ReadKey();
                        if (keyInput.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            pos++;
                            MainMenu(pos, options);
                        }
                        else if (keyInput.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            pos--;
                            MainMenu(pos, options);
                        }
                        else if (keyInput.Key == ConsoleKey.Enter)
                        {

                        }
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
                if (pos > options.Length - 1)
                {
                    pos = options.Length - 1;
                }
                else if (pos < 0)
                {
                    pos = 0;
                }
                if (options[i] == "Back")
                {
                    pos++;
                    continue;
                }
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

                //var taskIds = dataBase.GetTaskId(task);
                //    foreach (var id in taskIds)
                //    {
                //        Console.WriteLine($"{id} - {task}");
                //    }
            }
        }
        public void MakeTask()
        {

        }
    }
}