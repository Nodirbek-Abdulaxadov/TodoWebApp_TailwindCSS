using Microsoft.AspNetCore.Mvc;
using TodoWebApp_TailwindCSS.Services;
using TodoWebApp_TailwindCSS.ViewModels;

namespace TodoWebApp_TailwindCSS.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoInterface todoInterface;

        public TodoController(ITodoInterface todoInterface)
        {
            this.todoInterface = todoInterface;
        }

        public IActionResult Index()
        {
            var list = todoInterface.GetAll();
            TodoIndexViewModel viewModel = new TodoIndexViewModel()
            {
                TodoList = list
            };

            return View(viewModel);
        }

        public IActionResult Add(TodoIndexViewModel viewModel)
        {
            todoInterface.AddTodo(viewModel.NewTodoTitle);

            return RedirectToAction("Index");
        }

        public IActionResult Done(int id)
        {
            todoInterface.Done(id);

            return RedirectToAction("Index");
        }

        public IActionResult NotDone(int id)
        {
            todoInterface.NotDone(id);

            return RedirectToAction("Index");
        }

        public IActionResult Remove(int id)
        {
            todoInterface.DeleteTodo(id);

            return RedirectToAction("Index");
        }
    }
}
