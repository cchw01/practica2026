using InventoryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryApp.DataManagement
{
    public class InventoryDbContext: DbContext
    {
        public DbSet<InventoryItem> inventoryItem {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=InventoryItem;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

    }
}
