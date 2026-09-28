using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp2.Migrations
{
    /// <inheritdoc />
    public partial class AjoutTuile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Monster",
                table: "Monster");

            migrationBuilder.RenameTable(
                name: "Monster",
                newName: "Monsters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters",
                column: "IdMonster");

            migrationBuilder.CreateTable(
                name: "Tuiles",
                columns: table => new
                {
                    PositionX = table.Column<int>(type: "int", nullable: false),
                    PositionY = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    EstTraversable = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImageURL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tuiles", x => new { x.PositionX, x.PositionY });
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tuiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Monsters",
                table: "Monsters");

            migrationBuilder.RenameTable(
                name: "Monsters",
                newName: "Monster");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Monster",
                table: "Monster",
                column: "IdMonster");
        }
    }
}
