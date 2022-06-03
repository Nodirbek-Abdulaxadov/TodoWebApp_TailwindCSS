using TodoWebApp_TailwindCSS.Models;

namespace TodoWebApp_TailwindCSS.Services
{
    public class TodoRepository : ITodoInterface
    {
        List<TodoModel> list = new List<TodoModel>()
        {
            new TodoModel()
            {
                Id = 1,
                Title = "Asp.Net Core MVC",
                IsDone = false
            },
            new TodoModel()
            {
                Id = 2,
                Title = "Ish Tugadi",
                IsDone = true
            }
        };

        public TodoModel AddTodo(string title)
        {
            TodoModel model = new TodoModel()
            {
                Id = list.OrderByDescending(todo => todo.Id).First().Id + 1,
                Title = title,
                IsDone = false
            };

            list.Add(model);

            return model;
        }

        public void DeleteTodo(int id) => list.Remove(GetById(id));

        public List<TodoModel> GetAll() => list;

        public TodoModel GetById(int id) => list.FirstOrDefault(x => x.Id == id);

        public void NotDone(int id) => GetById(id).IsDone = false;

        public void Done(int id) => GetById(id).IsDone = true;
    }
}
