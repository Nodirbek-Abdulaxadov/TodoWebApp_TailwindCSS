using TodoWebApp_TailwindCSS.Models;

namespace TodoWebApp_TailwindCSS.Services
{
    public interface ITodoInterface
    {
        List<TodoModel> GetAll();
        TodoModel GetById(int id);
        TodoModel AddTodo(string title);
        void Done(int id);
        void NotDone(int id);
        void DeleteTodo(int id);
    }
}
