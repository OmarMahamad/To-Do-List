using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Data
{
    public class ToDoListDbContext:DbContext
    {
        public ToDoListDbContext(DbContextOptions options) :base(options) { }


        public DbSet<UserModel> Users{ get; set; }

        public DbSet<TaskModel> Tasks{ get; set; }




    }
}
