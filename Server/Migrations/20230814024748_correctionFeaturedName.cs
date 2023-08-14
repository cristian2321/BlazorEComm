using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class correctionFeaturedName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("23695fc6-4bde-4b99-a0bd-be0058744c1e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("441b3d5b-f402-49e6-80c6-567a035058f4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"), new Guid("f676560f-8c10-4b33-8310-d918a95db7b5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2b2d8fa4-83fb-4f63-9fa6-a634bf783ac6"), new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3b731ba6-2d9b-43e9-aca3-d3b831a88e7e"), new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("403b86a2-e0b7-442a-8ccf-65b6552fccad"), new Guid("f676560f-8c10-4b33-8310-d918a95db7b5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4c4990f5-f93a-47e1-ac1a-83bb4ba2f3df"), new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("1786a61a-2623-4c5c-9fb9-229a315c8bfe") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"), new Guid("8f1e8147-f4a6-4c6d-abe8-a0f889542f52") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5aa74308-254b-4351-a7d8-e849fa64129f"), new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("6fd84baa-8ec6-4b22-b5b0-a15e4ca1638f"), new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7a6c9593-dedc-411e-8816-208d90598158"), new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("295043fd-0f70-45b5-b3d4-7b6e3a0c1e50") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("6496c9c1-490f-462a-972e-1685bccb6fc1") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"), new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8cfbbb9e-ffce-4587-80a8-28516d07c045"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("01354230-e1b2-446d-af3d-f9e98fe55ce4"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("1786a61a-2623-4c5c-9fb9-229a315c8bfe"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("23695fc6-4bde-4b99-a0bd-be0058744c1e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("295043fd-0f70-45b5-b3d4-7b6e3a0c1e50"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3f1a337d-50cf-4174-ad9f-c3effb04fcf3"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("441b3d5b-f402-49e6-80c6-567a035058f4"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("6496c9c1-490f-462a-972e-1685bccb6fc1"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8f1e8147-f4a6-4c6d-abe8-a0f889542f52"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("b399e070-eaf1-4468-bd32-6d37f3c1adf8"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("f676560f-8c10-4b33-8310-d918a95db7b5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("28cc0693-be3d-428d-9665-a2b9417634e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b2d8fa4-83fb-4f63-9fa6-a634bf783ac6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b731ba6-2d9b-43e9-aca3-d3b831a88e7e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("403b86a2-e0b7-442a-8ccf-65b6552fccad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4c4990f5-f93a-47e1-ac1a-83bb4ba2f3df"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4ea722fa-7c1c-4751-96e6-8f28f7fbd165"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5aa74308-254b-4351-a7d8-e849fa64129f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6fd84baa-8ec6-4b22-b5b0-a15e4ca1638f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7a6c9593-dedc-411e-8816-208d90598158"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5f86cda-5aa9-410c-9e7f-03cc026a1835"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4570ebd9-8dfc-4873-8f26-aef2142b5fdc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a1fb3f25-3c5e-4981-a1ac-7c9e88a6b4be"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ff916544-7ef4-40ce-a36e-16cf25969207"));

            migrationBuilder.RenameColumn(
                name: "Feature",
                table: "Products",
                newName: "Featured");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Featured",
                table: "Products",
                newName: "Feature");

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
        }
    }
}
