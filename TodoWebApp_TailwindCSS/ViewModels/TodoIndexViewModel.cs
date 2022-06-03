using TodoWebApp_TailwindCSS.Models;

namespace TodoWebApp_TailwindCSS.ViewModels
{
    public class TodoIndexViewModel
    {
        public List<TodoModel> TodoList { get; set; } = new List<TodoModel>();
        public string NewTodoTitle { get; set; } = string.Empty;
    }
}
