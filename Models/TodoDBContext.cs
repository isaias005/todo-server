using Microsoft.EntityFrameworkCore;

namespace todo_server.Models
{
  public class TodoDBContext : DbContext
  {
    public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options) { }
    public DbSet<Todo> Todos { get; set; }
  }
}