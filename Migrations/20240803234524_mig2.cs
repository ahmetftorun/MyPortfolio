using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolio.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillsImgUrl",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "Tıtle",
                table: "Skills",
                newName: "Title");

            migrationBuilder.AddColumn<int>(
                name: "SkillsValue",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillsValue",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Skills",
                newName: "Tıtle");

            migrationBuilder.AddColumn<string>(
                name: "SkillsImgUrl",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
