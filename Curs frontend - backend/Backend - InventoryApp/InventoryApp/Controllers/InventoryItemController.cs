using InventoryApp.DataManagement;
using InventoryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InventoryItemController : ControllerBase
    {
        private readonly InventoryItemDataOps dataOps;

        public InventoryItemController(InventoryDbContext dbContext)
        {
            dataOps = new InventoryItemDataOps(dbContext);
        }

        [HttpGet]

        public ActionResult<InventoryItem> GetInventoryItems()
        {
            try
            {
                var items = dataOps.GetInventoryItems();
                return Ok(items);
            }
            catch (Exception ex)
            {
                {
                    return BadRequest(ex.Message);
                }
            }

        }

        [HttpPost]

        public ActionResult<InventoryItem> AddInventoryItem(InventoryItem item)
        {
            dataOps.AddInventoryItem(item);
            return Ok();
        }

        [HttpPut]

        public ActionResult UpdateInventoryItem(InventoryItem inventoryItem)
        {
            try
            {
                dataOps.UpdateInventoryItem(inventoryItem);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]

        public  ActionResult<InventoryItem> GetInventoryItem(int id)
        {
            try
            {
                var inventoryItem = dataOps.GetInventoryItemById(id);

                return Ok(inventoryItem);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
