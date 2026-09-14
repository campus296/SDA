using System.ComponentModel.DataAnnotations;

namespace Tp2.Models
{
    public class Monster
    {
        [Key]
        public int IdMonster { get; set; }
        public int PokemonId { get; set; }
        public string Nom { get; set; } = "";
        public int PointsVieBase { get; set; }
        public int ForceBase { get; set; }
        public int DefenseBase { get; set; }
        public int ExperienceBase { get; set; }
        public string SpriteUrl { get; set; } = "";
        public string Type1 { get; set; } = "";
        public string? Type2 { get; set; } = "";
    }
}
