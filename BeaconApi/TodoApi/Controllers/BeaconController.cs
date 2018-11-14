using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using BeaconApi.models;

namespace BeaconApi.Controllers
{
    [Route("api/beacons")]
    [ApiController]
    public class BeaconController : ControllerBase
    {
        private readonly BeaconContext _context;

        public BeaconController(BeaconContext context)
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
            var beacon = _context.beaconItems.Find(id);
            if (beacon == null)
            {
                return NotFound();
            }

            beacon.Name = item.Name;
            beacon.ExtraInfo = item.ExtraInfo;
            beacon.BeaconId = item.BeaconId;

            _context.beaconItems.Update(beacon);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            var beacon = _context.beaconItems.Find(id);
            if (beacon == null)
            {
                return NotFound();
            }

            _context.beaconItems.Remove(beacon);
            _context.SaveChanges();
            return NoContent();
        }
    }
}