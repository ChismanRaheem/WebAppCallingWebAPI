using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TodoListClient;

namespace TodoListClient.Data
{
    public class TodoListClientContext : DbContext
    {
        public TodoListClientContext (DbContextOptions<TodoListClientContext> options)
            : base(options)
        {
        }

        public DbSet<TodoListClient.TodoItem> TodoItem { get; set; } = default!;
    }
}
