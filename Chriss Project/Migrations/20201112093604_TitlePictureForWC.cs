using Microsoft.EntityFrameworkCore.Migrations;

namespace Chriss_Project.Migrations
{
    public partial class TitlePictureForWC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TitlePic",
                table: "WorldCups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitlePic",
                table: "WorldCups");
        }
    }
}
