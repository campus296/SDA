using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tp2.Data.Context;
using Tp2.Models;

namespace Tp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TuileController : ControllerBase
    {
        private readonly MonsterContext _context;

        public TuileController(MonsterContext context)
        {
            _context = context;
        }

        [HttpGet("{x}/{y}")]
        public async Task<ActionResult<Tuile>> GetTuile(int x, int y)
        {
            if (x < 0 || x >= 50 || y < 0 || y >= 50)
            {
                return BadRequest("Position invalide.");
            }

            Tuile? tuile = await _context.Tuiles.FindAsync(x, y);

            if (tuile != null)
            {
                return Ok(tuile);
            }

            tuile = GenererTuile(x, y);

            _context.Tuiles.Add(tuile);

            await _context.SaveChangesAsync();

            return Ok(tuile);
        }

        private Tuile GenererTuile(int x, int y)
        {
            Random random = new Random();

            int nombre = random.Next(1, 101);

            Tuile tuile = new Tuile();

            tuile.PositionX = x;
            tuile.PositionY = y;

            if (nombre <= 20)
            {
                // 20% Herbe
                tuile.Type = 1;
                tuile.EstTraversable = true;
                tuile.ImageURL = "img/Plains.png";
            }
            else if (nombre <= 30)
            {
                // 10% Eau
                tuile.Type = 2;
                tuile.EstTraversable = false;
                tuile.ImageURL = "img/River.png";
            }
            else if (nombre <= 45)
            {
                // 15% Montagne
                tuile.Type = 3;
                tuile.EstTraversable = false;
                tuile.ImageURL = "img/Mountain.png";
            }
            else if (nombre <= 60)
            {
                // 15% Forêt
                tuile.Type = 4;
                tuile.EstTraversable = true;
                tuile.ImageURL = "img/Forest.png";
            }
            else if (nombre <= 65)
            {
                // 5% Ville
                tuile.Type = 5;
                tuile.EstTraversable = true;
                tuile.ImageURL = "img/Town.png";
            }
            else
            {
                // 35% Route
                tuile.Type = 6;
                tuile.EstTraversable = true;
                tuile.ImageURL = "img/Road.png";
            }

            return tuile;
        }
    }
}