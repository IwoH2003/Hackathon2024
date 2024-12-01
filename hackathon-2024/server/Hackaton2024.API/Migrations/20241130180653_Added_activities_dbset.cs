using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton2024.API.Migrations
{
    public partial class Added_activities_dbset : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Users_UserId",
                table: "ActivityName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activity",
                table: "ActivityName");

            migrationBuilder.RenameTable(
                name: "ActivityName",
                newName: "Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_UserId",
                table: "Activities",
                newName: "IX_Activities_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_UserId",
                table: "Activities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_UserId",
                table: "Activities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "ActivityName");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_UserId",
                table: "ActivityName",
                newName: "IX_Activity_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activity",
                table: "ActivityName",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Users_UserId",
                table: "ActivityName",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
