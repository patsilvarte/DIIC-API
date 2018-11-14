using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TodoApi.models;

namespace TodoApi.Controllers
{
    [Route("api/beacons")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly BeaconContext _context;

        public TodoController(BeaconContext context)
        {
            _context = context;
            
            //ver depois se da para tirar
            if (_context.beaconItems.Count() == 0)
            {
                // Create a new TodoItem if collection is empty,
                // which means you can't delete all TodoItems.
                _context.beaconItems.Add(new BeaconItem { Name = "Beacon1" });
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public ActionResult<List<BeaconItem>> GetAll()
        {
            return _context.beaconItems.ToList();
        }

        [HttpGet("{id}", Name = "GetBeacon")]
        public ActionResult<BeaconItem> GetById(long id)
        {
            var item = _context.beaconItems.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Create(BeaconItem item)
        {
            _context.beaconItems.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetBeacon", new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long id, BeaconItem item)
        {
            var todo = _context.beaconItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            todo.Name = item.Name;
            todo.ExtraInfo = item.ExtraInfo;
            todo.beaconId = item.beaconId;

            _context.beaconItems.Update(todo);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var todo = _context.beaconItems.Find(id);
            if (todo == null)
            {
                return NotFound();
            }

            _context.beaconItems.Remove(todo);
            _context.SaveChanges();
            return NoContent();
        }
    }
}