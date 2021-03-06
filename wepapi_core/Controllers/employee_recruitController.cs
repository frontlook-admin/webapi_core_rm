﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi_core_rm.Models;

namespace webapi_core_rm.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class employee_recruitController : ControllerBase
    {
        private readonly employmentEntities _context;

        public employee_recruitController(employmentEntities context)
        {
            _context = context;
        }

        // GET: api/employee_recruit
        [HttpGet]
        public async Task<ActionResult<IEnumerable<employee_recruit>>> Getemployee_recruit()
        {
            return await _context.employee_recruit.ToListAsync();
        }

        // GET: api/employee_recruit/5
        [HttpGet("{id}")]
        public async Task<ActionResult<employee_recruit>> Getemployee_recruit(string id)
        {
            var employee_recruit = await _context.employee_recruit.FindAsync(id);

            if (employee_recruit == null)
            {
                return NotFound();
            }

            return employee_recruit;
        }

        // PUT: api/employee_recruit/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putemployee_recruit(string id, employee_recruit employee_recruit)
        {
            if (id != employee_recruit.Id)
            {
                return BadRequest();
            }

            _context.Entry(employee_recruit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!employee_recruitExists(id))
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

        // POST: api/employee_recruit
        [HttpPost]
        public async Task<ActionResult<employee_recruit>> Postemployee_recruit(employee_recruit employee_recruit)
        {
            _context.employee_recruit.Add(employee_recruit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getemployee_recruit", new { id = employee_recruit.Id }, employee_recruit);
        }

        // DELETE: api/employee_recruit/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<employee_recruit>> Deleteemployee_recruit(string id)
        {
            var employee_recruit = await _context.employee_recruit.FindAsync(id);
            if (employee_recruit == null)
            {
                return NotFound();
            }

            _context.employee_recruit.Remove(employee_recruit);
            await _context.SaveChangesAsync();

            return employee_recruit;
        }

        private bool employee_recruitExists(string id)
        {
            return _context.employee_recruit.Any(e => e.Id == id);
        }
    }
}
