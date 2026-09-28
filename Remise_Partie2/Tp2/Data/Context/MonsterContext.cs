using Microsoft.EntityFrameworkCore;
using Tp2.Models;

namespace Tp2.Data.Context
{
    public class MonsterContext : DbContext
    {
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options)
        {
        }

        public DbSet<Monster> Monsters { get; set; }

        public DbSet<Tuile> Tuiles { get; set; }
    }
}
