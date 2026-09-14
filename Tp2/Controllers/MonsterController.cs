using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tp2.Data.Context;
using Tp2.Models;

namespace Tp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        private readonly MonsterContext _context;

        public MonsterController(MonsterContext context)
        {
            _context = context;
        }

        // GET api/Monster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Monster>>> GetAll()
        {
            return await _context.Monsters.ToListAsync();
        }

        // GET api/Monster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Monster>> GetById(int id)
        {
            var monster = await _context.Monsters.FindAsync(id);

            if (monster == null)
                return NotFound();

            return monster;
        }

        // POST api/Monster
        [HttpPost]
        public async Task<ActionResult<Monster>> Create(Monster monster)
        {
            monster.IdMonster = 0;

            _context.Monsters.Add(monster);
            await _context.SaveChangesAsync();

            return CreatedAtAction(
                nameof(GetById),
                new { id = monster.IdMonster },
                monster
            );
        }

        // PUT api/Monster/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Monster monster)
        {
            if (id != monster.IdMonster)
                return BadRequest();

            _context.Entry(monster).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                bool existe = await _context.Monsters.AnyAsync(m => m.IdMonster == id);

                if (!existe)
                    return NotFound();

                throw;
            }

            return NoContent();
        }

        // DELETE api/Monster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var monster = await _context.Monsters.FindAsync(id);

            if (monster == null)
                return NotFound();

            _context.Monsters.Remove(monster);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}