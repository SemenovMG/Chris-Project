using Microsoft.EntityFrameworkCore.Migrations;

namespace Chriss_Project.Migrations
{
    public partial class SecondTitlePictureForWC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitlePic",
                table: "WorldCups");

            migrationBuilder.AddColumn<string>(
                name: "TitlePic1",
                table: "WorldCups",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitlePic2",
                table: "WorldCups",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TitlePic1",
                table: "WorldCups");

            migrationBuilder.DropColumn(
                name: "TitlePic2",
                table: "WorldCups");

            migrationBuilder.AddColumn<string>(
                name: "TitlePic",
                table: "WorldCups",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
