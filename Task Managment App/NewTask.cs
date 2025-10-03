namespace Task_Managment_App
{
    public class NewTask
    {
        public int Id { get; private set;}
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateOnly DueDate { get; private set; }
        public bool IsCompleted { get; private set; }
        public string Priority { get; private set; }

        public NewTask(string title, string description, DateOnly dueDate, bool isCompleted, string priority)
        {
            Title = title;
            Description = description;
            DueDate = dueDate;
            IsCompleted = isCompleted;
            Priority = priority;
        }
        public string ShowTask()
        {
            return $"{Title} - {Description} - {DueDate} - {Priority} -{IsCompleted}";
        }
    }
}