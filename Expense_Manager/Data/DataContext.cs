using Expense_Manager.Models;
using Microsoft.EntityFrameworkCore;

namespace Expense_Manager
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var database = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ExpenseManager.db");
            optionsBuilder.UseSqlite("Data Source=" + database);
        }
        
        public DbSet<User>? Users { get; set; }
        public DbSet<Transaction>? Transactions { get; set; }
    }
}
