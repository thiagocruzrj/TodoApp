using Microsoft.EntityFrameworkCore;
using TDA.Domain.Entities;

namespace TDA.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<TodoItem> Todos { get; set; }
    }
}