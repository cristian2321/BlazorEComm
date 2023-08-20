using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class UserAddress : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("03094b97-e7f4-4dbf-9d4d-a19777cf83ba"), new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1b0b4a91-7c68-4e62-86a3-fbe9acc139ce"), new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("34dffeea-34e6-49a0-bf17-5e72022532fe"), new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("79b6b6ea-3c4d-4025-8b93-7e31816b29a4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("9a49153c-49b2-4eac-83f4-a034b13e2442") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("e8eb637c-82c1-4b3a-9ff9-e2365bec6e30") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("a5874f57-d3fe-4efe-b264-3aa57f2a9981") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("ed57e955-9e35-4812-99e8-a4f8429345fb") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("934991e2-8f2c-4364-993b-b88410fa40de"), new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("5e124750-c8b4-4da3-990e-aa55166072c0") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("7d432fe7-33f8-49af-8610-200f44c3ba66") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("beb4c3cd-a987-4529-b9a9-0e89449e550a"), new Guid("9a49153c-49b2-4eac-83f4-a034b13e2442") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("e0bb8233-5c5d-4874-a035-15613cf07de5"), new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("eefd8980-fa18-4462-840f-3483877424e2"), new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("778b1c7b-7ff6-4b3f-b021-7f18c1dfbb5e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("5e124750-c8b4-4da3-990e-aa55166072c0"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("79b6b6ea-3c4d-4025-8b93-7e31816b29a4"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d432fe7-33f8-49af-8610-200f44c3ba66"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("9a49153c-49b2-4eac-83f4-a034b13e2442"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("a5874f57-d3fe-4efe-b264-3aa57f2a9981"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e8eb637c-82c1-4b3a-9ff9-e2365bec6e30"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("ed57e955-9e35-4812-99e8-a4f8429345fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("03094b97-e7f4-4dbf-9d4d-a19777cf83ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b0b4a91-7c68-4e62-86a3-fbe9acc139ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34dffeea-34e6-49a0-bf17-5e72022532fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("79d45863-01d6-4583-b75b-554dbd605901"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("934991e2-8f2c-4364-993b-b88410fa40de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a986beee-41d1-48ff-bb64-22320776e6da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("beb4c3cd-a987-4529-b9a9-0e89449e550a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e0bb8233-5c5d-4874-a035-15613cf07de5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eefd8980-fa18-4462-840f-3483877424e2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("14532a41-83bd-4709-82e6-31d16eb1af16"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fdbfccff-5748-4da9-a473-db906b910bf7"));

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"), "Movies", "movie" },
                    { new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"), "Books", "books" },
                    { new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"), "Video Games", "video-games" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"), "PC" },
                    { new Guid("459abaff-e930-4a52-845e-6690625edbf1"), "E-Book" },
                    { new Guid("7dfbf6dc-aa93-4d6a-9339-3494b4c2bc94"), "Blu-ray" },
                    { new Guid("a505b208-7dc2-4e39-ae84-a999150c4988"), "Xbox" },
                    { new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"), "Default" },
                    { new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"), "Stream" },
                    { new Guid("cc191e6b-5c3b-4ea6-a4de-378e45ab6766"), "Audiobook" },
                    { new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"), "Paperback" },
                    { new Guid("e1d9f72a-a01b-49bc-ab75-509f91ac4b05"), "VHS" },
                    { new Guid("ef078cba-a4bb-4ffd-bdc4-60bc1ad87a46"), "PlayStation" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("24a408a4-6c42-446d-a2fe-ea52662e386e"), new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("47dd2199-c248-46fc-8150-703de27823fa"), new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("5e3ea2c9-56f5-461f-a022-99e0c759c6d8"), new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("67803a0a-20f9-4e99-8226-3fb13fdaabcb"), new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("876b82c4-1d7d-48fb-8801-40f3edb6bb94"), new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("af98be76-713b-4f08-b769-122326866931"), new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("d0b2613c-f1d8-474a-9e40-34eec334562a"), new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("e61539c0-c1ef-49c9-ba7c-eed3c319fec2"), new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("24a408a4-6c42-446d-a2fe-ea52662e386e"), new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"), 299m, 159.99m },
                    { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"), 29.99m, 19.99m },
                    { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("a505b208-7dc2-4e39-ae84-a999150c4988"), 59.99m, 49.99m },
                    { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("ef078cba-a4bb-4ffd-bdc4-60bc1ad87a46"), 0m, 69.99m },
                    { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("459abaff-e930-4a52-845e-6690625edbf1"), 0m, 7.99m },
                    { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("cc191e6b-5c3b-4ea6-a4de-378e45ab6766"), 29.99m, 19.99m },
                    { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"), 19.99m, 9.99m },
                    { new Guid("47dd2199-c248-46fc-8150-703de27823fa"), new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"), 0m, 3.99m },
                    { new Guid("5e3ea2c9-56f5-461f-a022-99e0c759c6d8"), new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"), 0m, 6.99m },
                    { new Guid("67803a0a-20f9-4e99-8226-3fb13fdaabcb"), new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"), 24.99m, 9.99m },
                    { new Guid("af98be76-713b-4f08-b769-122326866931"), new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"), 0m, 14.99m },
                    { new Guid("d0b2613c-f1d8-474a-9e40-34eec334562a"), new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"), 14.99m, 7.99m },
                    { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("7dfbf6dc-aa93-4d6a-9339-3494b4c2bc94"), 0m, 9.99m },
                    { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"), 399m, 79.99m },
                    { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"), 0m, 3.99m },
                    { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("e1d9f72a-a01b-49bc-ab75-509f91ac4b05"), 0m, 19.99m },
                    { new Guid("e61539c0-c1ef-49c9-ba7c-eed3c319fec2"), new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"), 0m, 2.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_UserId",
                table: "Addresses",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("24a408a4-6c42-446d-a2fe-ea52662e386e"), new Guid("af794632-c6ec-4064-9235-5461c01f1b1a") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("a505b208-7dc2-4e39-ae84-a999150c4988") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("25aef04e-353f-471b-a540-74dc66f63add"), new Guid("ef078cba-a4bb-4ffd-bdc4-60bc1ad87a46") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("459abaff-e930-4a52-845e-6690625edbf1") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("cc191e6b-5c3b-4ea6-a4de-378e45ab6766") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"), new Guid("d7b7361d-75e0-402d-8dad-8120da033b37") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("47dd2199-c248-46fc-8150-703de27823fa"), new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5e3ea2c9-56f5-461f-a022-99e0c759c6d8"), new Guid("d7b7361d-75e0-402d-8dad-8120da033b37") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("67803a0a-20f9-4e99-8226-3fb13fdaabcb"), new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("af98be76-713b-4f08-b769-122326866931"), new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d0b2613c-f1d8-474a-9e40-34eec334562a"), new Guid("d7b7361d-75e0-402d-8dad-8120da033b37") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("7dfbf6dc-aa93-4d6a-9339-3494b4c2bc94") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("af794632-c6ec-4064-9235-5461c01f1b1a") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("dedb3733-b733-4825-8654-6f11e865d22d"), new Guid("e1d9f72a-a01b-49bc-ab75-509f91ac4b05") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("e61539c0-c1ef-49c9-ba7c-eed3c319fec2"), new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("876b82c4-1d7d-48fb-8801-40f3edb6bb94"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e7bd183-1ca6-4132-a13d-1c54cfb51c20"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("459abaff-e930-4a52-845e-6690625edbf1"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7dfbf6dc-aa93-4d6a-9339-3494b4c2bc94"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("a505b208-7dc2-4e39-ae84-a999150c4988"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("af794632-c6ec-4064-9235-5461c01f1b1a"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("afa1feda-f56c-4e75-80f4-83fe2f9af32b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("cc191e6b-5c3b-4ea6-a4de-378e45ab6766"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("d7b7361d-75e0-402d-8dad-8120da033b37"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e1d9f72a-a01b-49bc-ab75-509f91ac4b05"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("ef078cba-a4bb-4ffd-bdc4-60bc1ad87a46"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24a408a4-6c42-446d-a2fe-ea52662e386e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25aef04e-353f-471b-a540-74dc66f63add"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2be8df1a-aa13-4952-b623-739aad2d239a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("47dd2199-c248-46fc-8150-703de27823fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5e3ea2c9-56f5-461f-a022-99e0c759c6d8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("67803a0a-20f9-4e99-8226-3fb13fdaabcb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("af98be76-713b-4f08-b769-122326866931"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d0b2613c-f1d8-474a-9e40-34eec334562a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dedb3733-b733-4825-8654-6f11e865d22d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e61539c0-c1ef-49c9-ba7c-eed3c319fec2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb26b57b-409e-4159-9da2-d0a3d7a13db1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bcc4ecd3-6570-4967-8714-7cd9a423610e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("da1c5723-2610-4024-915d-5ef07adcb3ce"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("14532a41-83bd-4709-82e6-31d16eb1af16"), "Movies", "movie" },
                    { new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"), "Video Games", "video-games" },
                    { new Guid("fdbfccff-5748-4da9-a473-db906b910bf7"), "Books", "books" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02"), "Stream" },
                    { new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3"), "PC" },
                    { new Guid("5e124750-c8b4-4da3-990e-aa55166072c0"), "PlayStation" },
                    { new Guid("79b6b6ea-3c4d-4025-8b93-7e31816b29a4"), "VHS" },
                    { new Guid("7d432fe7-33f8-49af-8610-200f44c3ba66"), "Xbox" },
                    { new Guid("9a49153c-49b2-4eac-83f4-a034b13e2442"), "Default" },
                    { new Guid("a5874f57-d3fe-4efe-b264-3aa57f2a9981"), "E-Book" },
                    { new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7"), "Paperback" },
                    { new Guid("e8eb637c-82c1-4b3a-9ff9-e2365bec6e30"), "Blu-ray" },
                    { new Guid("ed57e955-9e35-4812-99e8-a4f8429345fb"), "Audiobook" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("03094b97-e7f4-4dbf-9d4d-a19777cf83ba"), new Guid("14532a41-83bd-4709-82e6-31d16eb1af16"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("1b0b4a91-7c68-4e62-86a3-fbe9acc139ce"), new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("34dffeea-34e6-49a0-bf17-5e72022532fe"), new Guid("fdbfccff-5748-4da9-a473-db906b910bf7"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("778b1c7b-7ff6-4b3f-b021-7f18c1dfbb5e"), new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("14532a41-83bd-4709-82e6-31d16eb1af16"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("fdbfccff-5748-4da9-a473-db906b910bf7"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("934991e2-8f2c-4364-993b-b88410fa40de"), new Guid("fdbfccff-5748-4da9-a473-db906b910bf7"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("beb4c3cd-a987-4529-b9a9-0e89449e550a"), new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("e0bb8233-5c5d-4874-a035-15613cf07de5"), new Guid("da7c0e7d-ab77-44a3-b6b7-c0a29d543e5f"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("eefd8980-fa18-4462-840f-3483877424e2"), new Guid("14532a41-83bd-4709-82e6-31d16eb1af16"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("03094b97-e7f4-4dbf-9d4d-a19777cf83ba"), new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02"), 0m, 2.99m },
                    { new Guid("1b0b4a91-7c68-4e62-86a3-fbe9acc139ce"), new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3"), 24.99m, 9.99m },
                    { new Guid("34dffeea-34e6-49a0-bf17-5e72022532fe"), new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7"), 14.99m, 7.99m },
                    { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02"), 0m, 3.99m },
                    { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("79b6b6ea-3c4d-4025-8b93-7e31816b29a4"), 0m, 19.99m },
                    { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("9a49153c-49b2-4eac-83f4-a034b13e2442"), 399m, 79.99m },
                    { new Guid("79d45863-01d6-4583-b75b-554dbd605901"), new Guid("e8eb637c-82c1-4b3a-9ff9-e2365bec6e30"), 0m, 9.99m },
                    { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("a5874f57-d3fe-4efe-b264-3aa57f2a9981"), 0m, 7.99m },
                    { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7"), 19.99m, 9.99m },
                    { new Guid("7a132aa8-e356-4b52-a02e-0965a8018466"), new Guid("ed57e955-9e35-4812-99e8-a4f8429345fb"), 29.99m, 19.99m },
                    { new Guid("934991e2-8f2c-4364-993b-b88410fa40de"), new Guid("e75b9452-5773-4be2-9f21-6b5278eabbe7"), 0m, 6.99m },
                    { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3"), 29.99m, 19.99m },
                    { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("5e124750-c8b4-4da3-990e-aa55166072c0"), 0m, 69.99m },
                    { new Guid("a986beee-41d1-48ff-bb64-22320776e6da"), new Guid("7d432fe7-33f8-49af-8610-200f44c3ba66"), 59.99m, 49.99m },
                    { new Guid("beb4c3cd-a987-4529-b9a9-0e89449e550a"), new Guid("9a49153c-49b2-4eac-83f4-a034b13e2442"), 299m, 159.99m },
                    { new Guid("e0bb8233-5c5d-4874-a035-15613cf07de5"), new Guid("236b0e6c-088f-40a0-ae94-6f4098d107a3"), 0m, 14.99m },
                    { new Guid("eefd8980-fa18-4462-840f-3483877424e2"), new Guid("0c6d1da0-dd40-4b81-8c8e-1d768d17ab02"), 0m, 3.99m }
                });
        }
    }
}
