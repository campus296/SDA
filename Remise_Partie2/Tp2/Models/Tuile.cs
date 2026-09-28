using Microsoft.EntityFrameworkCore;

namespace Tp2.Models
{
    [PrimaryKey(nameof(PositionX), nameof(PositionY))]
    public class Tuile
    {
        public int PositionX { get; set; }

        public int PositionY { get; set; }

        public int Type { get; set; }

        public bool EstTraversable { get; set; }

        public string ImageURL { get; set; } = string.Empty;
    }
}