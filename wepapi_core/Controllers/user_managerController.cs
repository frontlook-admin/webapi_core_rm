using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using wepapi_core.Models;

namespace wepapi_core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class user_managerController : ControllerBase
    {
        private readonly employmentEntities _context;

        public user_managerController(employmentEntities context)
        {
            _context = context;
        }

        // GET: api/user_manager
        [HttpGet]
        public async Task<ActionResult<IEnumerable<user_manager>>> Getuser_manager()
        {
            return await _context.user_manager.ToListAsync();
        }

        // GET: api/user_manager/5
        [HttpGet("{id}")]
        public async Task<ActionResult<user_manager>> Getuser_manager(string id)
        {
            var user_manager = await _context.user_manager.FindAsync(id);

            if (user_manager == null)
            {
                return NotFound();
            }

            return user_manager;
        }

        // PUT: api/user_manager/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putuser_manager(string id, user_manager user_manager)
        {
            if (id != user_manager.id)
            {
                return BadRequest();
            }

            _context.Entry(user_manager).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!user_managerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/user_manager
        [HttpPost]
        public async Task<ActionResult<user_manager>> Postuser_manager(user_manager user_manager)
        {
            _context.user_manager.Add(user_manager);
            await _context.SaveChangesAsync();

            return CreatedAtAction($"Getuser_manager", new { id = user_manager.id }, user_manager);
        }

        // DELETE: api/user_manager/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<user_manager>> Deleteuser_manager(string id)
        {
            var user_manager = await _context.user_manager.FindAsync(id);
            if (user_manager == null)
            {
                return NotFound();
            }

            _context.user_manager.Remove(user_manager);
            await _context.SaveChangesAsync();

            return user_manager;
        }

        private bool user_managerExists(string id)
        {
            return _context.user_manager.Any(e => e.id == id);
        }
    }
}
