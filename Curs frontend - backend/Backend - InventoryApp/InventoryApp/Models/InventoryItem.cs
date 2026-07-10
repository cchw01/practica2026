namespace InventoryApp.Models
{
    public class InventoryItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string User {  get; set; }

        public string Location {  get; set; }

        public int InventoryNumber { get; set; }

        public DateTime CreatedAt {  get; set; }

        public DateTime ModifiedAt {  get; set; }

        public bool Deleted { get; set; }

    }
}
