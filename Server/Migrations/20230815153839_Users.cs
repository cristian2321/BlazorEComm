using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("39f4f5f6-6105-4747-a951-1472ac2eb87b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("d9d83ead-1b8e-4e60-9a70-7d0ad203bb1f") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3bdbd2d8-9eaf-4292-af28-f62efcca4301"), new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("62fe63e3-7464-49fd-8df0-f140d29847d3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("6f415720-187c-4a39-bc86-ee6b6a2cc57b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("c671a2a9-722e-4f29-a20c-8478d9bd1d6b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5289161b-7410-42c7-abce-7d86c393e8f1"), new Guid("f814842a-0120-4b04-9c29-b61156e77643") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8066dd37-a821-4f86-9cab-b788b5fa4c3a"), new Guid("f814842a-0120-4b04-9c29-b61156e77643") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("ced79397-d312-4a46-a31d-369246d4f516"), new Guid("c671a2a9-722e-4f29-a20c-8478d9bd1d6b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d3967ad8-7fd4-4711-aedd-227ae8a120de"), new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d65a6780-d77e-465c-9345-4a5662ed99a2"), new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("73d020f5-d595-4a5e-97a4-793815ef4ea4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("9749452f-5f01-4665-8ad9-3ab9c17d22a5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("f814842a-0120-4b04-9c29-b61156e77643") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("ee1ed73e-f763-40a7-93ce-766feac6fcc6"), new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b13d19d-8d06-46fc-ad0e-046ff8c41e6c"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("39f4f5f6-6105-4747-a951-1472ac2eb87b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("62fe63e3-7464-49fd-8df0-f140d29847d3"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f415720-187c-4a39-bc86-ee6b6a2cc57b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("73d020f5-d595-4a5e-97a4-793815ef4ea4"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("9749452f-5f01-4665-8ad9-3ab9c17d22a5"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("c671a2a9-722e-4f29-a20c-8478d9bd1d6b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("d9d83ead-1b8e-4e60-9a70-7d0ad203bb1f"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("f814842a-0120-4b04-9c29-b61156e77643"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3bdbd2d8-9eaf-4292-af28-f62efcca4301"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5289161b-7410-42c7-abce-7d86c393e8f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8066dd37-a821-4f86-9cab-b788b5fa4c3a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ced79397-d312-4a46-a31d-369246d4f516"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3967ad8-7fd4-4711-aedd-227ae8a120de"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d65a6780-d77e-465c-9345-4a5662ed99a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ee1ed73e-f763-40a7-93ce-766feac6fcc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07a54e7c-ae88-4167-bfb1-c748fab9d183"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("82dbce60-f407-4e79-aa57-da242f448acd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"));

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("7ee5f6c7-71d6-40be-ba41-a962c7932a50"), "Movies", "movie" },
                    { new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"), "Video Games", "video-games" },
                    { new Guid("ec08f29b-4f57-4508-a567-00468aef6f31"), "Books", "books" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12c6b9f6-d073-4d59-ad40-d8543665f537"), "Xbox" },
                    { new Guid("27c281d8-cc2d-4053-a7c2-2220e6d53f8a"), "Default" },
                    { new Guid("36882151-5d1a-4a4e-ab8b-5d597902b900"), "Audiobook" },
                    { new Guid("3f272a45-02a4-41cd-955b-c20abeef9c00"), "E-Book" },
                    { new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e"), "Stream" },
                    { new Guid("653c935e-e0af-421b-a29e-62f0280de67f"), "VHS" },
                    { new Guid("662ff1b3-751f-40dd-8c00-c05959b73df6"), "Blu-ray" },
                    { new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078"), "PC" },
                    { new Guid("a23b3616-a9d9-42b5-aaa2-115252478735"), "PlayStation" },
                    { new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d"), "Paperback" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("0673dcfb-a08c-4400-b6a5-d028f8d7742a"), new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("068b93c9-c2da-4777-8016-02a7718f9a66"), new Guid("ec08f29b-4f57-4508-a567-00468aef6f31"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("190a0ace-731f-4604-9fd9-6bf61af3bcfa"), new Guid("7ee5f6c7-71d6-40be-ba41-a962c7932a50"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("7ee5f6c7-71d6-40be-ba41-a962c7932a50"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("41c370cd-0fe2-41b0-9a5b-5321ec90cf52"), new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("4a04e501-9d60-48ec-be31-2b389492186e"), new Guid("ec08f29b-4f57-4508-a567-00468aef6f31"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("a310cd01-1a7c-4f1e-bca3-5fb962e21229"), new Guid("7ee5f6c7-71d6-40be-ba41-a962c7932a50"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("ec08f29b-4f57-4508-a567-00468aef6f31"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("f46672fd-04f0-49d7-b3e7-40da9f2b473e"), new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("f54348ae-c138-4d0c-b0b5-c0fd0827f287"), new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("0673dcfb-a08c-4400-b6a5-d028f8d7742a"), new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078"), 24.99m, 9.99m },
                    { new Guid("068b93c9-c2da-4777-8016-02a7718f9a66"), new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d"), 0m, 6.99m },
                    { new Guid("190a0ace-731f-4604-9fd9-6bf61af3bcfa"), new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e"), 0m, 3.99m },
                    { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("12c6b9f6-d073-4d59-ad40-d8543665f537"), 59.99m, 49.99m },
                    { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078"), 29.99m, 19.99m },
                    { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("a23b3616-a9d9-42b5-aaa2-115252478735"), 0m, 69.99m },
                    { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("27c281d8-cc2d-4053-a7c2-2220e6d53f8a"), 399m, 79.99m },
                    { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e"), 0m, 3.99m },
                    { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("653c935e-e0af-421b-a29e-62f0280de67f"), 0m, 19.99m },
                    { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("662ff1b3-751f-40dd-8c00-c05959b73df6"), 0m, 9.99m },
                    { new Guid("41c370cd-0fe2-41b0-9a5b-5321ec90cf52"), new Guid("27c281d8-cc2d-4053-a7c2-2220e6d53f8a"), 299m, 159.99m },
                    { new Guid("4a04e501-9d60-48ec-be31-2b389492186e"), new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d"), 14.99m, 7.99m },
                    { new Guid("a310cd01-1a7c-4f1e-bca3-5fb962e21229"), new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e"), 0m, 2.99m },
                    { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("36882151-5d1a-4a4e-ab8b-5d597902b900"), 29.99m, 19.99m },
                    { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("3f272a45-02a4-41cd-955b-c20abeef9c00"), 0m, 7.99m },
                    { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d"), 19.99m, 9.99m },
                    { new Guid("f54348ae-c138-4d0c-b0b5-c0fd0827f287"), new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078"), 0m, 14.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("0673dcfb-a08c-4400-b6a5-d028f8d7742a"), new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("068b93c9-c2da-4777-8016-02a7718f9a66"), new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("190a0ace-731f-4604-9fd9-6bf61af3bcfa"), new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("12c6b9f6-d073-4d59-ad40-d8543665f537") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"), new Guid("a23b3616-a9d9-42b5-aaa2-115252478735") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("27c281d8-cc2d-4053-a7c2-2220e6d53f8a") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("653c935e-e0af-421b-a29e-62f0280de67f") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"), new Guid("662ff1b3-751f-40dd-8c00-c05959b73df6") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("41c370cd-0fe2-41b0-9a5b-5321ec90cf52"), new Guid("27c281d8-cc2d-4053-a7c2-2220e6d53f8a") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4a04e501-9d60-48ec-be31-2b389492186e"), new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a310cd01-1a7c-4f1e-bca3-5fb962e21229"), new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("36882151-5d1a-4a4e-ab8b-5d597902b900") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("3f272a45-02a4-41cd-955b-c20abeef9c00") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"), new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f54348ae-c138-4d0c-b0b5-c0fd0827f287"), new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f46672fd-04f0-49d7-b3e7-40da9f2b473e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("12c6b9f6-d073-4d59-ad40-d8543665f537"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("27c281d8-cc2d-4053-a7c2-2220e6d53f8a"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("36882151-5d1a-4a4e-ab8b-5d597902b900"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3f272a45-02a4-41cd-955b-c20abeef9c00"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("497f5eb2-8ded-44f3-b775-2335f6181f6e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("653c935e-e0af-421b-a29e-62f0280de67f"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("662ff1b3-751f-40dd-8c00-c05959b73df6"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("98fd0166-c9a7-482b-9bc3-8b2822c1a078"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("a23b3616-a9d9-42b5-aaa2-115252478735"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e9d7000f-5ffc-4ed5-b188-235177c1374d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0673dcfb-a08c-4400-b6a5-d028f8d7742a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("068b93c9-c2da-4777-8016-02a7718f9a66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("190a0ace-731f-4604-9fd9-6bf61af3bcfa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1dce2bd5-d836-4538-ac9e-351ef4d69e6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2d2c40a9-7036-43db-b8af-288ba0edc6f4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("41c370cd-0fe2-41b0-9a5b-5321ec90cf52"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4a04e501-9d60-48ec-be31-2b389492186e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a310cd01-1a7c-4f1e-bca3-5fb962e21229"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b12852e8-704a-4a7e-9233-4349c89199cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f54348ae-c138-4d0c-b0b5-c0fd0827f287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7ee5f6c7-71d6-40be-ba41-a962c7932a50"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f2db25b-7400-46fd-a7ee-6acf427a5665"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ec08f29b-4f57-4508-a567-00468aef6f31"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("07a54e7c-ae88-4167-bfb1-c748fab9d183"), "Books", "books" },
                    { new Guid("82dbce60-f407-4e79-aa57-da242f448acd"), "Movies", "movie" },
                    { new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"), "Video Games", "video-games" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39f4f5f6-6105-4747-a951-1472ac2eb87b"), "Xbox" },
                    { new Guid("62fe63e3-7464-49fd-8df0-f140d29847d3"), "VHS" },
                    { new Guid("6f415720-187c-4a39-bc86-ee6b6a2cc57b"), "Blu-ray" },
                    { new Guid("73d020f5-d595-4a5e-97a4-793815ef4ea4"), "Audiobook" },
                    { new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d"), "PC" },
                    { new Guid("9749452f-5f01-4665-8ad9-3ab9c17d22a5"), "E-Book" },
                    { new Guid("c671a2a9-722e-4f29-a20c-8478d9bd1d6b"), "Default" },
                    { new Guid("d9d83ead-1b8e-4e60-9a70-7d0ad203bb1f"), "PlayStation" },
                    { new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53"), "Stream" },
                    { new Guid("f814842a-0120-4b04-9c29-b61156e77643"), "Paperback" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("3bdbd2d8-9eaf-4292-af28-f62efcca4301"), new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("82dbce60-f407-4e79-aa57-da242f448acd"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("5289161b-7410-42c7-abce-7d86c393e8f1"), new Guid("07a54e7c-ae88-4167-bfb1-c748fab9d183"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("6b13d19d-8d06-46fc-ad0e-046ff8c41e6c"), new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("8066dd37-a821-4f86-9cab-b788b5fa4c3a"), new Guid("07a54e7c-ae88-4167-bfb1-c748fab9d183"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("ced79397-d312-4a46-a31d-369246d4f516"), new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("d3967ad8-7fd4-4711-aedd-227ae8a120de"), new Guid("82dbce60-f407-4e79-aa57-da242f448acd"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("d65a6780-d77e-465c-9345-4a5662ed99a2"), new Guid("82dbce60-f407-4e79-aa57-da242f448acd"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("07a54e7c-ae88-4167-bfb1-c748fab9d183"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("ee1ed73e-f763-40a7-93ce-766feac6fcc6"), new Guid("fd16786a-13e1-4d1f-92ac-90b56184acdc"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("39f4f5f6-6105-4747-a951-1472ac2eb87b"), 59.99m, 49.99m },
                    { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d"), 29.99m, 19.99m },
                    { new Guid("0a06e3b4-3e94-4bed-ba2d-eae45c79b97c"), new Guid("d9d83ead-1b8e-4e60-9a70-7d0ad203bb1f"), 0m, 69.99m },
                    { new Guid("3bdbd2d8-9eaf-4292-af28-f62efcca4301"), new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d"), 24.99m, 9.99m },
                    { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("62fe63e3-7464-49fd-8df0-f140d29847d3"), 0m, 19.99m },
                    { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("6f415720-187c-4a39-bc86-ee6b6a2cc57b"), 0m, 9.99m },
                    { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("c671a2a9-722e-4f29-a20c-8478d9bd1d6b"), 399m, 79.99m },
                    { new Guid("4bdc597b-76e8-41f4-b691-f0f468d5421b"), new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53"), 0m, 3.99m },
                    { new Guid("5289161b-7410-42c7-abce-7d86c393e8f1"), new Guid("f814842a-0120-4b04-9c29-b61156e77643"), 14.99m, 7.99m },
                    { new Guid("8066dd37-a821-4f86-9cab-b788b5fa4c3a"), new Guid("f814842a-0120-4b04-9c29-b61156e77643"), 0m, 6.99m },
                    { new Guid("ced79397-d312-4a46-a31d-369246d4f516"), new Guid("c671a2a9-722e-4f29-a20c-8478d9bd1d6b"), 299m, 159.99m },
                    { new Guid("d3967ad8-7fd4-4711-aedd-227ae8a120de"), new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53"), 0m, 2.99m },
                    { new Guid("d65a6780-d77e-465c-9345-4a5662ed99a2"), new Guid("e47ff6a0-cf86-4b43-a12a-d0f2eef02d53"), 0m, 3.99m },
                    { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("73d020f5-d595-4a5e-97a4-793815ef4ea4"), 29.99m, 19.99m },
                    { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("9749452f-5f01-4665-8ad9-3ab9c17d22a5"), 0m, 7.99m },
                    { new Guid("d6b79f62-0583-4e3a-be24-bc15b212cef6"), new Guid("f814842a-0120-4b04-9c29-b61156e77643"), 19.99m, 9.99m },
                    { new Guid("ee1ed73e-f763-40a7-93ce-766feac6fcc6"), new Guid("8e601b15-3f2e-436e-b1f5-e431edf51b3d"), 0m, 14.99m }
                });
        }
    }
}
