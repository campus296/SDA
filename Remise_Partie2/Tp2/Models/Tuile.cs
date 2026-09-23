using Microsoft.EntityFrameworkCore;

namespace Tp2.Models
{
    public class Tuile
    {
        public int PositionX;
        public int PositionY;
        public int Type;
        public byte estTraversable;
        public string imageURL;
    }
}
