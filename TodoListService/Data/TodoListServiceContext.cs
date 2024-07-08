using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoListService.Models;

namespace TodoListService.Data
{
    public class TodoListServiceContext : DbContext
    {
        public TodoListServiceContext (DbContextOptions<TodoListServiceContext> options)
            : base(options)
        {
        }

        public DbSet<TodoListService.Models.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
