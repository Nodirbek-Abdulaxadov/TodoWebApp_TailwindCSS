using TodoWebApp_TailwindCSS.Models;

namespace TodoWebApp_TailwindCSS.ViewModels
{
    public class TodoIndexViewModel
    {
        public List<TodoModel> TodoList { get; set; }
        public string NewTodoTitle { get; set; }
        public TodoModel Todo { get; set; }
    }
}
