using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChessWebsite.Data.Migrations
{
    public partial class AddedElo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ELO",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ELO",
                table: "AspNetUsers");
        }
    }
}
