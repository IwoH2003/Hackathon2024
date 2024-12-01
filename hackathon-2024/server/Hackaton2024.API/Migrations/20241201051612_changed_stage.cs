using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton2024.API.Migrations
{
    public partial class changed_stage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stage",
                table: "Activities");

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "UserActivities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stage",
                table: "UserActivities");

            migrationBuilder.AddColumn<int>(
                name: "Stage",
                table: "Activities",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
