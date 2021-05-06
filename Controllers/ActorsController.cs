﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IsTp_Lab2.Models;

namespace IsTp_Lab2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private readonly Lab2FilmsContext _context;

        public ActorsController(Lab2FilmsContext context)
        {
            _context = context;
        }

        // GET: api/Actors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actors>>> GetActors()
        {
            return await _context.Actors.ToListAsync();
        }

        // GET: api/Actors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Actors>> GetActors(int id)
        {
            var actors = await _context.Actors.FindAsync(id);

            if (actors == null)
            {
                return NotFound();
            }

            return actors;
        }

        // PUT: api/Actors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActors(int id, Actors actors)
        {
            if (id != actors.Id)
            {
                return BadRequest();
            }

            _context.Entry(actors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActorsExists(id))
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

        // POST: api/Actors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Actors>> PostActors(Actors actors)
        {
            _context.Actors.Add(actors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActors", new { id = actors.Id }, actors);
        }

        // DELETE: api/Actors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActors(int id)
        {
            var actors = await _context.Actors.FindAsync(id);
            if (actors == null)
            {
                return NotFound();
            }

            _context.Actors.Remove(actors);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ActorsExists(int id)
        {
            return _context.Actors.Any(e => e.Id == id);
        }
    }
}
