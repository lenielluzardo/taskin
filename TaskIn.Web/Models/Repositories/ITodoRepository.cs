using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIn.Web.Models
{
    public interface ITodoRepository
    {
        IEnumerable<Todo> AllTodos { get; }
        Todo GetTodoById(int todoId);
    }
}
