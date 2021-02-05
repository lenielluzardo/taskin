using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIn.Web.Models
{
    public class MockTodoRepository : ITodoRepository
    {
        private readonly IUserRepository _userRepository = new MockUserRepository();
        public IEnumerable<Todo> AllTodos => 
            new List<Todo> 
            {
                new Todo {UserId = 1, Title = "Go to work", StartDate = DateTime.Now, EndDate = new DateTime(2021, 12, 31)},
                new Todo {UserId = 1, Title = "Workout in the morning", StartDate = DateTime.Now, EndDate = new DateTime(2021, 12, 31)},
                new Todo {UserId = 1, Title = "Buy groceries", StartDate = DateTime.Now, EndDate = new DateTime(2021, 12, 31)},
                new Todo {UserId = 1, Title = "Work on Personal Project", StartDate = DateTime.Now, EndDate = new DateTime(2021, 12, 31)},
                new Todo {UserId = 1, Title = "Visit Mom", StartDate = DateTime.Now, EndDate = new DateTime(2021, 12, 31)},
            };

        public IEnumerable<Todo> PiesOfTheWeek => throw new NotImplementedException();

        public Todo GetTodoById(int todoId)
        {
            return AllTodos.FirstOrDefault(t => t.Id == todoId);
        }
    }
}
