using InventoryApp.Models;

namespace InventoryApp.DataManagement
{
    public class InventoryItemDataOps
    {

        private readonly InventoryDbContext dbContext;

        public InventoryItemDataOps(InventoryDbContext context)
        {
            dbContext = context;
        }

        public InventoryItem[] GetInventoryItems()
        {
            return dbContext.inventoryItem.ToArray();
        }

        public void AddInventoryItem(InventoryItem item)
        {
            dbContext.inventoryItem.Add(item);
            dbContext.SaveChanges();
        }

        public void UpdateInventoryItem(InventoryItem item)
        {
            try
            {
                dbContext?.inventoryItem.Update(item);
                dbContext?.SaveChanges();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public InventoryItem? GetInventoryItemById(int id)
        {
            var item = dbContext.inventoryItem.Where(x => x.Id == id).FirstOrDefault();
            return item;
        }

    }
}
