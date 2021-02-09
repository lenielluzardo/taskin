using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIn.Web.Models.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        public IEnumerable<Todo> AllTodos => throw new NotImplementedException();

        public Todo GetTodoById(int todoId)
        {
            throw new NotImplementedException();
        }
    }
}
