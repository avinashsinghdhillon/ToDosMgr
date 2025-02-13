using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDosMgr;

namespace ToDosMgr.Data
{
    public class ToDosMgrContext : DbContext
    {
        public ToDosMgrContext (DbContextOptions<ToDosMgrContext> options)
            : base(options)
        {
        }

        public DbSet<ToDosMgr.ToDoItem> ToDoItem { get; set; } = default!;
    }
}
