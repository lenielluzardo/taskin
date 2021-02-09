using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskIn.Web.Models;

namespace TaskIn.Web.ViewModels
{
    public class TodoListViewModel
    {
        public IEnumerable<Todo> Todos { get; set; }
        public string CurrentUser{ get; set; }
    }
}
