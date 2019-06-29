using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options ) :base(options) {}

        // Nazwa w tabeli w bazie danych to Value
        public DbSet<Value> Value { get; set;}
    }
}