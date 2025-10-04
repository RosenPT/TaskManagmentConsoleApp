namespace Task_Managment_App
{
    public enum Options
    {
        Show_tasks,
        Create_task,
        Edit_task,
        Delete_task,
        Back,
        Exit
    }
    public enum Priories
    {
        LOW,
        MEDIUM,
        HIGH
    }
    public enum KeyInput
    {
        Enter = ConsoleKey.Enter,
        Up = ConsoleKey.UpArrow,
        Down = ConsoleKey.DownArrow
    }
    public enum Menus
    {
        Main_menu,
        Show_tasks_menu,
        Create_task_menu,
        Edit_task_menu,
        Delete_task_menu
    }
}