using Microsoft.EntityFrameworkCore;

namespace AjaxCrudCore.Models
{
    public class MyContext:DbContext
    {
        public MyContext(DbContextOptions<MyContext> option) : base(option)
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}
