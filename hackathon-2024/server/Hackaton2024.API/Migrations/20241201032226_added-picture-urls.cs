using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton2024.API.Migrations
{
    public partial class addedpictureurls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PictureUrl",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10,
                column: "PictureUrl",
                value: "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PictureUrl",
                table: "Activities");
        }
    }
}
