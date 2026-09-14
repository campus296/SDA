using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tp2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Monster",
                newName: "IdMonster");

            migrationBuilder.AlterColumn<string>(
                name: "Type2",
                table: "Monster",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<int>(
                name: "ExperienceBase",
                table: "Monster",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "double");

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Monster",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Monster");

            migrationBuilder.RenameColumn(
                name: "IdMonster",
                table: "Monster",
                newName: "Id");

            migrationBuilder.UpdateData(
                table: "Monster",
                keyColumn: "Type2",
                keyValue: null,
                column: "Type2",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type2",
                table: "Monster",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<double>(
                name: "ExperienceBase",
                table: "Monster",
                type: "double",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
