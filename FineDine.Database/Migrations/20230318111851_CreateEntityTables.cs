using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FineDine.Database.Migrations
{
    /// <inheritdoc />
    public partial class CreateEntityTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredients = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WarmDish = table.Column<bool>(type: "bit", nullable: false),
                    ColdDish = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Drink",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HotDrink = table.Column<bool>(type: "bit", nullable: false),
                    ColdDrink = table.Column<bool>(type: "bit", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DishDrink",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false),
                    DrinkId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishDrink", x => new { x.DishId, x.DrinkId });
                    table.ForeignKey(
                        name: "FK_DishDrink_Dish_DishId",
                        column: x => x.DishId,
                        principalTable: "Dish",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishDrink_Drink_DrinkId",
                        column: x => x.DrinkId,
                        principalTable: "Drink",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "Id", "ColdDish", "ImageUrl", "Ingredients", "Name", "WarmDish" },
                values: new object[,]
                {
                    { 1, false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fthestayathomechef.com%2Froast-chicken%2F&psig=AOvVaw3svEy3FrAyhs9j9blN6_r-&ust=1679223194025000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCMiN9YKo5f0CFQAAAAAdAAAAABBp", "1 (3 pound) whole chicken, giblets removed\r\n\r\nsalt and black pepper to taste\r\n\r\n1 tablespoon onion powder, or to taste\r\n\r\n½ cup butter or margarine\r\n\r\n1 stalk celery, leaves removed", "Roasted Chicken", true },
                    { 2, true, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.manusmenu.com%2Fsalmon-nigiri&psig=AOvVaw26KB-QIsXLl1S5JUMCh03w&ust=1679223165863000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCPjEsfWn5f0CFQAAAAAdAAAAABAD", "1 1/2 cups (320 g) Calrose rice (sushi rice)\r\n1 3/4 cups (430 ml) water\r\n1 tsp salt\r\n3 tbsp (45 ml) rice vinegar\r\n1 tbsp sugar\r\n1 sushi-grade skinless salmon steak, about 1 lb (450 g) (see note)\r\n1 tsp (5 ml) wasabi\r\nSoy sauce for sushi and sashimi, to taste\r\nPickled ginger, to taste", "Salmon Sushi Nigri", false },
                    { 3, false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.wholesomeyum.com%2Fribeye-steak%2F&psig=AOvVaw3aThhC2AKgk7yNNRvUbMBY&ust=1679223089679000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCOjx69Sn5f0CFQAAAAAdAAAAABA_", "2 rib-eye steaks, each about 200g and 2cm thick\r\n1tbsp sunflower oil\r\n1 tbsp/25g butter\r\n1 garlic clove, left whole but bashed once\r\nthyme, optional", "Rib Eye Steak", true },
                    { 4, true, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.godare.se%2Frecept%2Fa%2F28a1aq%2Fwienerbrodets-dag--fira-med-hembakade-wienerbrod&psig=AOvVaw0WOqQSEc9GyAOl0OvyRUUX&ust=1679223026777000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCODQ0rKn5f0CFQAAAAAdAAAAABAD", "2 cups unsalted butter, softened\r\n\r\n⅔ cup all-purpose flour\r\n\r\n8 cups all-purpose flour, divided\r\n\r\n4 ½ teaspoons active dry yeast\r\n\r\n2 ½ cups milk\r\n\r\n½ cup white sugar\r\n\r\n2 teaspoons salt\r\n\r\n2 large eggs\r\n\r\n1 teaspoon lemon extract\r\n\r\n1 teaspoon almond extract\r\n\r\n2 cups fruit preserves, any flavor\r\n\r\n1 large egg white, beaten", "Danish pastry", false }
                });

            migrationBuilder.InsertData(
                table: "Drink",
                columns: new[] { "Id", "ColdDrink", "HotDrink", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, true, false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fcnaluxury.channelnewsasia.com%2Fexperiences%2Fburgundy-wines-prices-200641&psig=AOvVaw0UUbIiqMiN5U5cHrBqXAK8&ust=1679223263396000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCOiCl6ao5f0CFQAAAAAdAAAAABAn", "Red Burgundy Wine" },
                    { 2, true, false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.commonwealthwineschool.com%2Fshop%2Fp%2Fwhite-burgundy-celebration-june-9&psig=AOvVaw3kR-gpMBkvLo7tP3Xcubnq&ust=1679223341571000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCPC5-cmo5f0CFQAAAAAdAAAAABAD", "White Burgundy Wine" },
                    { 3, true, false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fmatadornetwork.com%2Fread%2Fsake-etiquette-japan%2F&psig=AOvVaw2Lj2xLonQu0yal1CrVNQjU&ust=1679223361624000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCMinoNOo5f0CFQAAAAAdAAAAABAD", "Sake" },
                    { 4, true, false, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.liquor.com%2Fbest-german-beers-5089460&psig=AOvVaw2ozoT_8gxxaI0lmWrP5WLE&ust=1679223423998000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCIipgfKo5f0CFQAAAAAdAAAAABAg", "Beer" },
                    { 5, false, true, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.medicalnewstoday.com%2Farticles%2F324771&psig=AOvVaw0QcuMfuZA3JbH2Huhgcxcr&ust=1679223478959000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCMi9wYup5f0CFQAAAAAdAAAAABAD", "Tea" },
                    { 6, false, true, "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.roastycoffee.com%2Fcold-coffee-vs-hot-coffee%2F&psig=AOvVaw20cwPYbtY6zbMr6FVc1JFC&ust=1679223505077000&source=images&cd=vfe&ved=0CA0QjRxqFwoTCJCz75ap5f0CFQAAAAAdAAAAABAJ", "Coffe" }
                });

            migrationBuilder.InsertData(
                table: "DishDrink",
                columns: new[] { "DishId", "DrinkId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 3 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 4 },
                    { 4, 5 },
                    { 4, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishDrink_DrinkId",
                table: "DishDrink",
                column: "DrinkId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishDrink");

            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Drink");
        }
    }
}
