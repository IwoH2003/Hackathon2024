using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton2024.API.Migrations
{
    public partial class testpictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Name", "PictureUrl", "Stage" },
                values: new object[,]
                {
                    { 1, "Bieganie", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 2, "Czytanie", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 3, "Gotowanie", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 4, "Kolarstwo", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 5, "Pływanie", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 6, "Malowanie", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 7, "Hiking", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 8, "Taniec", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 9, "Ogrodnictwo", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 },
                    { 10, "Pisanie", "https://images-ext-1.discordapp.net/external/NP7oXacXlpjTkM0U1j-qvy8ze8uiLKF1mznDUH7DjCU/https/bi.im-g.pl/im/47/a9/19/z26908487AMP%2CPol-godziny-jazdy-na-rowerze-tygodniowo-zapewnia-o.jpg?format=webp&width=994&height=663", 0 }
                });
        }
    }
}
