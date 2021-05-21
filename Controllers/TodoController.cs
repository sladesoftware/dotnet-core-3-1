using Microsoft.AspNetCore.Mvc;

namespace DotnetApplication.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoItemStore store;

        public TodoController(TodoItemStore store)
        {
            this.store = store;
        }

        [HttpGet("{fail:bool?}")]
        public IActionResult Get([FromRoute]bool fail = false)
        {
            if (fail) throw new System.Exception("Simulated failure");

            return Ok(store.GetItems());
        }

        [HttpPut("{fail:bool?}")]
        public IActionResult Create([FromBody] TodoItem item, bool fail = false)
        {
            if (fail) throw new System.Exception("Simulated failure");
            if (item == null) return BadRequest();

            store.AddItem(item);

            return Ok("OK - Created");
        }

        [HttpPatch("{id:int}/{fail:bool?}")]
        public IActionResult Update([FromBody] TodoItem item, int id, bool fail = false)
        {
            if (fail) throw new System.Exception("Simulated failure");
            if (item == null) return BadRequest();

            if (!store.ReplaceItem(id, item))
            {
                return NotFound();
            }

            return Ok("OK - Updated");
        }

        [HttpDelete("{id:int}/{fail:bool?}")]
        public IActionResult Delete([FromRoute]int id, [FromRoute]bool fail = false)
        {
            if (fail) throw new System.Exception("Simulated failure");

            if (!store.DeleteItem(id))
            {
                return NotFound();
            }

            return Ok("OK - Deleted");
        }
    }
}

