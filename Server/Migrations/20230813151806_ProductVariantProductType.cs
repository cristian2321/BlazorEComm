using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class ProductVariantProductType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03f6270a-8aa6-4a59-bf5f-d3bb0c1fd025"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("118340ca-5f42-4722-bbec-b7e2a8c433e2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1e09f60a-51a0-41f3-a996-32b125132706"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7d21d9aa-2193-4763-b873-a32c4f015a27"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("84124d2f-9853-4127-b88e-4c67b74b8a16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4b7e882-f264-4d48-827e-902768048456"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a6ad4308-a305-4170-ad3f-3c8e178bd33b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3d1c4ea-fa1b-4079-a556-fcb65f6b4736"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6717403-aa1b-419a-9f3d-276d6c8449e7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd5ba9ee-b350-43b2-bc5a-b2a7dfb41b7a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d9d36ea0-5d50-4314-8753-6ce8f0437395"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8175db6a-df76-4bd6-bd23-3a8e27404c78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("af78b974-94f2-4495-8fa4-aab9011e2ba3"));

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Products");

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
                name: "Variants",
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
                    { new Guid("38bdecd9-cdd5-4f89-b25a-7c4ff026bf50"), "Books", "books" },
                    { new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"), "Video Games", "video-games" },
                    { new Guid("ae80f8b0-2b8f-47ad-8329-5dd70f41369b"), "Movies", "movie" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("06ded486-855b-4b1b-b872-2ae5bdc7e0bb"), "VHS" },
                    { new Guid("0ea925dc-14d4-4d5e-bffe-160c42ee9c3c"), "Paperback" },
                    { new Guid("6e349601-3db1-44fa-904b-621d624b98d1"), "Xbox" },
                    { new Guid("73788521-ef3e-421d-829d-ac1b7668fe7f"), "Stream" },
                    { new Guid("a07a9dcf-094d-417c-b46a-4e55dd896f1e"), "Default" },
                    { new Guid("b3ca353e-a74b-4665-a1a7-4d592cbbb1bd"), "PlayStation" },
                    { new Guid("bc1d77f1-4a28-4f5c-9000-35ecd70ee0a8"), "Blu-ray" },
                    { new Guid("c543a017-6b91-42cd-9ef6-9e83ade9a298"), "PC" },
                    { new Guid("dcc6815b-ae53-4e61-9180-085ced15c4b6"), "E-Book" },
                    { new Guid("e8b751af-9e62-4878-a9f3-b299f5e37210"), "Audiobook" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("02b8515c-2b22-45d9-ae61-3f845ee9fce3"), new Guid("ae80f8b0-2b8f-47ad-8329-5dd70f41369b"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("0e8cd586-562c-44f0-a2b7-897e6fbc6e88"), new Guid("38bdecd9-cdd5-4f89-b25a-7c4ff026bf50"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("3c2f3035-c82e-420a-adae-fab93ef2a29b"), new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("410f0824-8fdb-4584-a931-7ed525d4e965"), new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("842e03f4-9d62-42a9-88ba-173783a7d8bb"), new Guid("ae80f8b0-2b8f-47ad-8329-5dd70f41369b"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("95891376-1439-463c-9f36-2ee6ed3f2a9e"), new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("b2811d50-07b2-4e04-9d4c-81300822b973"), new Guid("38bdecd9-cdd5-4f89-b25a-7c4ff026bf50"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("c49c6593-c52f-463a-b285-e9562b3bf978"), new Guid("38bdecd9-cdd5-4f89-b25a-7c4ff026bf50"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("e3dcb396-2d42-4bb3-9e2c-b0b254c82cc5"), new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("ece8ac90-bb53-47dd-9e43-88da88e66c20"), new Guid("ae80f8b0-2b8f-47ad-8329-5dd70f41369b"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("ff8324b0-450c-4b9d-bfc4-9d4c1587244c"), new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("02b8515c-2b22-45d9-ae61-3f845ee9fce3"), new Guid("73788521-ef3e-421d-829d-ac1b7668fe7f"), 0m, 3.99m },
                    { new Guid("0e8cd586-562c-44f0-a2b7-897e6fbc6e88"), new Guid("0ea925dc-14d4-4d5e-bffe-160c42ee9c3c"), 14.99m, 7.99m },
                    { new Guid("3c2f3035-c82e-420a-adae-fab93ef2a29b"), new Guid("6e349601-3db1-44fa-904b-621d624b98d1"), 59.99m, 49.99m },
                    { new Guid("3c2f3035-c82e-420a-adae-fab93ef2a29b"), new Guid("b3ca353e-a74b-4665-a1a7-4d592cbbb1bd"), 0m, 69.99m },
                    { new Guid("3c2f3035-c82e-420a-adae-fab93ef2a29b"), new Guid("c543a017-6b91-42cd-9ef6-9e83ade9a298"), 29.99m, 19.99m },
                    { new Guid("410f0824-8fdb-4584-a931-7ed525d4e965"), new Guid("a07a9dcf-094d-417c-b46a-4e55dd896f1e"), 299m, 159.99m },
                    { new Guid("842e03f4-9d62-42a9-88ba-173783a7d8bb"), new Guid("06ded486-855b-4b1b-b872-2ae5bdc7e0bb"), 0m, 19.99m },
                    { new Guid("842e03f4-9d62-42a9-88ba-173783a7d8bb"), new Guid("73788521-ef3e-421d-829d-ac1b7668fe7f"), 0m, 3.99m },
                    { new Guid("842e03f4-9d62-42a9-88ba-173783a7d8bb"), new Guid("a07a9dcf-094d-417c-b46a-4e55dd896f1e"), 399m, 79.99m },
                    { new Guid("842e03f4-9d62-42a9-88ba-173783a7d8bb"), new Guid("bc1d77f1-4a28-4f5c-9000-35ecd70ee0a8"), 0m, 9.99m },
                    { new Guid("95891376-1439-463c-9f36-2ee6ed3f2a9e"), new Guid("c543a017-6b91-42cd-9ef6-9e83ade9a298"), 24.99m, 9.99m },
                    { new Guid("b2811d50-07b2-4e04-9d4c-81300822b973"), new Guid("0ea925dc-14d4-4d5e-bffe-160c42ee9c3c"), 0m, 6.99m },
                    { new Guid("c49c6593-c52f-463a-b285-e9562b3bf978"), new Guid("0ea925dc-14d4-4d5e-bffe-160c42ee9c3c"), 19.99m, 9.99m },
                    { new Guid("c49c6593-c52f-463a-b285-e9562b3bf978"), new Guid("dcc6815b-ae53-4e61-9180-085ced15c4b6"), 0m, 7.99m },
                    { new Guid("c49c6593-c52f-463a-b285-e9562b3bf978"), new Guid("e8b751af-9e62-4878-a9f3-b299f5e37210"), 29.99m, 19.99m },
                    { new Guid("ece8ac90-bb53-47dd-9e43-88da88e66c20"), new Guid("73788521-ef3e-421d-829d-ac1b7668fe7f"), 0m, 2.99m },
                    { new Guid("ff8324b0-450c-4b9d-bfc4-9d4c1587244c"), new Guid("c543a017-6b91-42cd-9ef6-9e83ade9a298"), 0m, 14.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariants_ProductTypeId",
                table: "Variants",
                column: "ProductTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Variants");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3dcb396-2d42-4bb3-9e2c-b0b254c82cc5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02b8515c-2b22-45d9-ae61-3f845ee9fce3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0e8cd586-562c-44f0-a2b7-897e6fbc6e88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c2f3035-c82e-420a-adae-fab93ef2a29b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("410f0824-8fdb-4584-a931-7ed525d4e965"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("842e03f4-9d62-42a9-88ba-173783a7d8bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("95891376-1439-463c-9f36-2ee6ed3f2a9e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2811d50-07b2-4e04-9d4c-81300822b973"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c49c6593-c52f-463a-b285-e9562b3bf978"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ece8ac90-bb53-47dd-9e43-88da88e66c20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff8324b0-450c-4b9d-bfc4-9d4c1587244c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("38bdecd9-cdd5-4f89-b25a-7c4ff026bf50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4158de16-7671-4575-80ed-9a34bdee93ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ae80f8b0-2b8f-47ad-8329-5dd70f41369b"));

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"), "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("8175db6a-df76-4bd6-bd23-3a8e27404c78"), "Movies", "movie" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("af78b974-94f2-4495-8fa4-aab9011e2ba3"), "Books", "books" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("03f6270a-8aa6-4a59-bf5f-d3bb0c1fd025"), new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 999.99m, "Xbox" },
                    { new Guid("118340ca-5f42-4722-bbec-b7e2a8c433e2"), new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 5.99m, "Half-Life 2" },
                    { new Guid("1e09f60a-51a0-41f3-a996-32b125132706"), new Guid("8175db6a-df76-4bd6-bd23-3a8e27404c78"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", 19.99m, "Back to the Future" },
                    { new Guid("7d21d9aa-2193-4763-b873-a32c4f015a27"), new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 4.99m, "Day of the Tentacle" },
                    { new Guid("84124d2f-9853-4127-b88e-4c67b74b8a16"), new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 499.99m, "Super Nintendo Entertainment System" },
                    { new Guid("a4b7e882-f264-4d48-827e-902768048456"), new Guid("8175db6a-df76-4bd6-bd23-3a8e27404c78"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", 15.99m, "Toy Story" },
                    { new Guid("a6ad4308-a305-4170-ad3f-3c8e178bd33b"), new Guid("af78b974-94f2-4495-8fa4-aab9011e2ba3"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 8.99m, "Ready Player One" },
                    { new Guid("c3d1c4ea-fa1b-4079-a556-fcb65f6b4736"), new Guid("0008e835-f9ec-438b-8f99-0586a4c86fe8"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 5.99m, "Diablo II" },
                    { new Guid("c6717403-aa1b-419a-9f3d-276d6c8449e7"), new Guid("af78b974-94f2-4495-8fa4-aab9011e2ba3"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", 7.99m, "Nineteen Eighty-Four" },
                    { new Guid("cd5ba9ee-b350-43b2-bc5a-b2a7dfb41b7a"), new Guid("8175db6a-df76-4bd6-bd23-3a8e27404c78"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", 20.99m, "The Matrix" },
                    { new Guid("d9d36ea0-5d50-4314-8753-6ce8f0437395"), new Guid("af78b974-94f2-4495-8fa4-aab9011e2ba3"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" }
                });
        }
    }
}
