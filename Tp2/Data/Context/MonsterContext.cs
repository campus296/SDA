using Microsoft.EntityFrameworkCore;
using Tp2.Models;

namespace Tp2.Data.Context
{
    public class MonsterContext : DbContext
    {
        DbSet<Monster> Monster { get; set; }
        public MonsterContext(DbContextOptions<MonsterContext> options) : base(options)
        {
        }
    }
}
