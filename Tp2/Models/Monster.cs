namespace Tp2.Models
{
    public class Monster
    {
        public int Id { get; set; }
        public string Nom { get; set; } = "";
        public int PointsVieBase { get; set; }
        public int ForceBase { get; set; }
        public int DefenseBase { get; set; }
        public double ExperienceBase { get; set; }
        public string SpriteUrl { get; set; } = "";
        public string Type1 { get; set; } = "";
        public string Type2 { get; set; } = "";
    }
}
