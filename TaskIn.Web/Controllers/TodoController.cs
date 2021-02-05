using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskIn.Web.Models;

namespace TaskIn.Web.Controllers
{
    public class TodoController: Controller
    {
        private readonly ITodoRepository _todoRepository;
        private readonly IUserRepository _userRepository;

        public TodoController(ITodoRepository todoRepository, IUserRepository userRepository)
        {
            _todoRepository = todoRepository;
            _userRepository = userRepository;
        }
        public ViewResult List()
        {
            return View(_todoRepository.AllTodos);
        }
    }
}
