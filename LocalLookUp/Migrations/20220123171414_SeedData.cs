using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalLookUp.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "TownId", "Name", "Restaurant", "Shop" },
                values: new object[,]
                {
                    { 1, "Bakersfield", "BakersFelid Pub", "Karens Curiosities" },
                    { 20, "Groton", "Goreton River Grill", "Bait and Fish" },
                    { 19, "Fall River", "Orion", "Beatrice Bagel" },
                    { 18, "San Mateo", "Gastues", "Kyras Textiles" },
                    { 17, "Marysville", "Mama Roo's", "Hillbit Nursery" },
                    { 16, "Scottsdale", "Ricky's", "Duck Hunting supply" },
                    { 15, "Puslbo", "Grill King", "Orca Sounds Trinkets" },
                    { 14, "Barstow", "Barstow College Pub", "Oran Organic" },
                    { 13, "Calexio", "Gastues", "Kyras Textiles" },
                    { 12, "Yuma", "Bob's Breakfast", "Put Put golf Spot" },
                    { 11, "Walpi", "Teryaki Walipi", "Surfs Up" },
                    { 10, "Selma", "Selma Sandwhich Stop", "Selma Crystals" },
                    { 9, "Spokane", "Grease Palace", "Guns Guns and more Guns" },
                    { 8, "Ozark", "Route 64 Diner", "711" },
                    { 7, "Guntersville", "Woolly Mammoth Burgers", "All You Need Pet Emporium" },
                    { 6, "Florence", "Miltons Wing Stop", "Capella's Cloths Bin" },
                    { 5, "Bartholomew", "Bistro", "Avantgarde" },
                    { 4, "Chickasaw", "Smoked Everything", "SmokeShop" },
                    { 3, "Matilda", "Jeff's Joe Hut", "Antique 4 You" },
                    { 2, "Andalusia", "Dessert Pizza", "Aquari" },
                    { 21, "Willmar", "Rebel Rouseres", "Spaghetti Factory" },
                    { 22, "Missoula", "Corenell's Chicken", "Om Bap" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "TownId",
                keyValue: 22);
        }
    }
}
