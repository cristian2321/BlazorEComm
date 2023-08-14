using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class addFeatureProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Feature = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVariants",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVariants", x => new { x.ProductId, x.ProductTypeId });
                    table.ForeignKey(
                        name: "FK_ProductVariants_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductVariants_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("4570ebd9-8dfc-4873-8f26-aef2142b5fdc"), "Books", "books" },
                    { new Guid("a1fb3f25-3c5e-4981-a1ac-7c9e88a6b4be"), "Movies", "movie" },
                    { new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"), "Video Games", "video-games" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4"), "Stream" },
                    { new Guid("1786a61a-2623-4c5c-9fb9-229a315c8bfe"), "PlayStation" },
                    { new Guid("23695fc6-4bde-4b99-a0bd-be0058744c1e"), "VHS" },
                    { new Guid("295043fd-0f70-45b5-b3d4-7b6e3a0c1e50"), "Audiobook" },
                    { new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3"), "PC" },
                    { new Guid("441b3d5b-f402-49e6-80c6-567a035058f4"), "Blu-ray" },
                    { new Guid("6496c9c1-490f-462a-972e-1685bccb6fc1"), "E-Book" },
                    { new Guid("8f1e8147-f4a6-4c6d-abe8-a0f889542f52"), "Xbox" },
                    { new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8"), "Paperback" },
                    { new Guid("f676560f-8c10-4b33-8310-d918a95db7b5"), "Default" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Feature", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("a1fb3f25-3c5e-4981-a1ac-7c9e88a6b4be"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("2b2d8fa4-83fb-4f63-9fa6-a634bf783ac6"), new Guid("a1fb3f25-3c5e-4981-a1ac-7c9e88a6b4be"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("3b731ba6-2d9b-43e9-aca3-d3b831a88e7e"), new Guid("4570ebd9-8dfc-4873-8f26-aef2142b5fdc"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("403b86a2-e0b7-442a-8ccf-65b6552fccad"), new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("4c4990f5-f93a-47e1-ac1a-83bb4ba2f3df"), new Guid("a1fb3f25-3c5e-4981-a1ac-7c9e88a6b4be"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("5aa74308-254b-4351-a7d8-e849fa64129f"), new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("6fd84baa-8ec6-4b22-b5b0-a15e4ca1638f"), new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("7a6c9593-dedc-411e-8816-208d90598158"), new Guid("4570ebd9-8dfc-4873-8f26-aef2142b5fdc"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("8cfbbb9e-ffce-4587-80a8-28516d07c045"), new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("4570ebd9-8dfc-4873-8f26-aef2142b5fdc"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4"), 0m, 3.99m },
                    { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("23695fc6-4bde-4b99-a0bd-be0058744c1e"), 0m, 19.99m },
                    { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("441b3d5b-f402-49e6-80c6-567a035058f4"), 0m, 9.99m },
                    { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("f676560f-8c10-4b33-8310-d918a95db7b5"), 399m, 79.99m },
                    { new Guid("2b2d8fa4-83fb-4f63-9fa6-a634bf783ac6"), new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4"), 0m, 2.99m },
                    { new Guid("3b731ba6-2d9b-43e9-aca3-d3b831a88e7e"), new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8"), 0m, 6.99m },
                    { new Guid("403b86a2-e0b7-442a-8ccf-65b6552fccad"), new Guid("f676560f-8c10-4b33-8310-d918a95db7b5"), 299m, 159.99m },
                    { new Guid("4c4990f5-f93a-47e1-ac1a-83bb4ba2f3df"), new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4"), 0m, 3.99m },
                    { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("1786a61a-2623-4c5c-9fb9-229a315c8bfe"), 0m, 69.99m },
                    { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3"), 29.99m, 19.99m },
                    { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("8f1e8147-f4a6-4c6d-abe8-a0f889542f52"), 59.99m, 49.99m },
                    { new Guid("5aa74308-254b-4351-a7d8-e849fa64129f"), new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3"), 24.99m, 9.99m },
                    { new Guid("6fd84baa-8ec6-4b22-b5b0-a15e4ca1638f"), new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3"), 0m, 14.99m },
                    { new Guid("7a6c9593-dedc-411e-8816-208d90598158"), new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8"), 14.99m, 7.99m },
                    { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("295043fd-0f70-45b5-b3d4-7b6e3a0c1e50"), 29.99m, 19.99m },
                    { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("6496c9c1-490f-462a-972e-1685bccb6fc1"), 0m, 7.99m },
                    { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8"), 19.99m, 9.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "ProductVariants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductVariants");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
