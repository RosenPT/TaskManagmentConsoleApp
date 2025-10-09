namespace Task_Managment_App
{
    public class ConsoleApp
    {
        public void Run(DataBase dataBase)
        {
            string[] options = { "Show Task", "Create Task", "Edit Task", "Delete Task", "Back", "Exit" };

            List<int> visibleOptionIndices = Enumerable.Range(0, options.Length)
            .Where(i => options[i] != "Back")
            .ToList();

            int visiblePos = 0;

            Options ChosenOption;

            Menus menu = Menus.Main_menu;

            List<NewTask> tasks = dataBase.GetAllTasks();


            MainMenu(visiblePos, options, visibleOptionIndices); //Startup menu
            while (true)
            {
                switch (menu)
                {
                    case Menus.Main_menu:
                        ConsoleKeyInfo keyInput = Console.ReadKey();
                        if (keyInput.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            if (visiblePos > 0)
                            {
                                visiblePos--;
                            }
                            MainMenu(visiblePos, options, visibleOptionIndices);
                        }
                        else if (keyInput.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            if (visiblePos < visibleOptionIndices.Count - 1)
                            {
                                visiblePos++;
                            }
                            MainMenu(visiblePos, options, visibleOptionIndices);
                        }
                        else if (keyInput.Key == ConsoleKey.Enter)
                        {

                        }
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

        public void MainMenu(int visiblePos, string[] options, List<int> visibleOptionIndices)
        {
            Console.WriteLine("---------------Welcome to Task Manager---------------");
            Console.WriteLine();
            Console.WriteLine("Choose option:");
            Console.WriteLine();

             for (int i = 0; i < visibleOptionIndices.Count; i++)
            {
                int optionIndex = visibleOptionIndices[i];
                string option = options[optionIndex];

                if (options[i] == "Back")
                {
                    continue; 
                }
                if (i == visiblePos)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"> {option}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine($"  {option}");
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