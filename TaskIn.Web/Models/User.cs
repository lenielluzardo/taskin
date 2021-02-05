using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskIn.Web.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Todo> Todos { get; set; }
    }
}
