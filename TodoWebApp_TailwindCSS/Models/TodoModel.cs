namespace TodoWebApp_TailwindCSS.Models
{
    public class TodoModel
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; } = string.Empty;
        public bool IsDone { get; set; } = false;
    }
}
