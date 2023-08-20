using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class OrderPaymentFlag2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("29db4736-9c64-4233-87fb-83ebe523f3ab") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("8ad92a00-e051-4a34-acc2-c6b899b0dbfd") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("308fce72-676f-4ab1-82b8-82d1cdd00657"), new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("0f38542b-d3d8-427e-966b-07b413c015a2") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("89eac1eb-0932-4d6b-b670-023a6139a0b9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7e724e93-969d-4be8-9572-505ea485a600"), new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b3f5ed2f-bfcc-4447-9444-5260f12e7d2a"), new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("cb5c0899-500e-4b25-be6a-a72c0d4d1bea"), new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("d6392455-5dc6-4daf-bd9b-5da92644a823"), new Guid("17563c05-ad7c-41c0-81f5-23aeb0be34ad") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("e3764e19-c2c6-485a-bf72-8c424d449ff4"), new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("eea82bff-726c-46e0-a311-372fdbbe3b8b"), new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("17563c05-ad7c-41c0-81f5-23aeb0be34ad") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("2ef80822-406d-43e6-9cd0-b8f525f4fd88") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("4427b851-d2c5-4241-92d6-f398e0ec02fe") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("42bbbc4d-9a9d-401f-8172-fdc6061040c2"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("0f38542b-d3d8-427e-966b-07b413c015a2"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("17563c05-ad7c-41c0-81f5-23aeb0be34ad"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("29db4736-9c64-4233-87fb-83ebe523f3ab"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("2ef80822-406d-43e6-9cd0-b8f525f4fd88"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("4427b851-d2c5-4241-92d6-f398e0ec02fe"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("89eac1eb-0932-4d6b-b670-023a6139a0b9"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8ad92a00-e051-4a34-acc2-c6b899b0dbfd"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("308fce72-676f-4ab1-82b8-82d1cdd00657"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7e724e93-969d-4be8-9572-505ea485a600"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3f5ed2f-bfcc-4447-9444-5260f12e7d2a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb5c0899-500e-4b25-be6a-a72c0d4d1bea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d6392455-5dc6-4daf-bd9b-5da92644a823"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e3764e19-c2c6-485a-bf72-8c424d449ff4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eea82bff-726c-46e0-a311-372fdbbe3b8b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ca728ff-46d1-4406-a757-400599c06912"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9239d61a-d1fa-46f5-bc78-4a1e336bb026"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bce4c47d-62dd-4d57-84d1-6193f4d88fd4"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("78e3aad2-c78b-497d-9efa-1dd23cc29ac5"), "Movies", "movie" },
                    { new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"), "Video Games", "video-games" },
                    { new Guid("a2cf00f7-abca-402f-a236-b157b57bc7cb"), "Books", "books" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4"), "PC" },
                    { new Guid("5a07249d-b8d5-40d7-97aa-2287a5f9603e"), "E-Book" },
                    { new Guid("618e48be-2d8d-4060-9870-145b9542f3cb"), "Blu-ray" },
                    { new Guid("7d19af50-709e-4a8e-af45-ac7078da2f9c"), "PlayStation" },
                    { new Guid("7f577522-97e8-4dc0-ba6b-dcdba53aab5f"), "Audiobook" },
                    { new Guid("816bc59c-107f-4138-800c-8a46f2c8e9c6"), "Default" },
                    { new Guid("890c94d0-3f7a-4f94-ab9e-ddb05298d145"), "VHS" },
                    { new Guid("b81d96cf-b9ea-487a-884f-a39ac0d92f7b"), "Xbox" },
                    { new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75"), "Paperback" },
                    { new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19"), "Stream" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("a2cf00f7-abca-402f-a236-b157b57bc7cb"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("18b3acab-da6e-4d95-bd84-5a5272ef3abe"), new Guid("78e3aad2-c78b-497d-9efa-1dd23cc29ac5"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("78e3aad2-c78b-497d-9efa-1dd23cc29ac5"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("1d59509c-2313-48a2-b4d7-a98eaeb62310"), new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("1df509b5-38e5-45e3-baa7-399dcb6fd2c1"), new Guid("78e3aad2-c78b-497d-9efa-1dd23cc29ac5"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("2f7d19a4-5af3-4c55-956f-f426f8f199c4"), new Guid("a2cf00f7-abca-402f-a236-b157b57bc7cb"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("66fe5019-886e-4cce-ae25-48fc1c37c4c6"), new Guid("a2cf00f7-abca-402f-a236-b157b57bc7cb"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("7eae4217-40c9-44cb-8117-1bc1b822ffcb"), new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("8ff86c0d-7b0d-4133-87f8-cc64ec4a2901"), new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("cb1a692d-72f0-4f69-887e-7cd40053c64e"), new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("5a07249d-b8d5-40d7-97aa-2287a5f9603e"), 0m, 7.99m },
                    { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("7f577522-97e8-4dc0-ba6b-dcdba53aab5f"), 29.99m, 19.99m },
                    { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75"), 19.99m, 9.99m },
                    { new Guid("18b3acab-da6e-4d95-bd84-5a5272ef3abe"), new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19"), 0m, 3.99m },
                    { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("618e48be-2d8d-4060-9870-145b9542f3cb"), 0m, 9.99m },
                    { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("816bc59c-107f-4138-800c-8a46f2c8e9c6"), 399m, 79.99m },
                    { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("890c94d0-3f7a-4f94-ab9e-ddb05298d145"), 0m, 19.99m },
                    { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19"), 0m, 3.99m },
                    { new Guid("1d59509c-2313-48a2-b4d7-a98eaeb62310"), new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4"), 24.99m, 9.99m },
                    { new Guid("1df509b5-38e5-45e3-baa7-399dcb6fd2c1"), new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19"), 0m, 2.99m },
                    { new Guid("2f7d19a4-5af3-4c55-956f-f426f8f199c4"), new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75"), 14.99m, 7.99m },
                    { new Guid("66fe5019-886e-4cce-ae25-48fc1c37c4c6"), new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75"), 0m, 6.99m },
                    { new Guid("7eae4217-40c9-44cb-8117-1bc1b822ffcb"), new Guid("816bc59c-107f-4138-800c-8a46f2c8e9c6"), 299m, 159.99m },
                    { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4"), 29.99m, 19.99m },
                    { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("7d19af50-709e-4a8e-af45-ac7078da2f9c"), 0m, 69.99m },
                    { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("b81d96cf-b9ea-487a-884f-a39ac0d92f7b"), 59.99m, 49.99m },
                    { new Guid("8ff86c0d-7b0d-4133-87f8-cc64ec4a2901"), new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4"), 0m, 14.99m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("5a07249d-b8d5-40d7-97aa-2287a5f9603e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("7f577522-97e8-4dc0-ba6b-dcdba53aab5f") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"), new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("18b3acab-da6e-4d95-bd84-5a5272ef3abe"), new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("618e48be-2d8d-4060-9870-145b9542f3cb") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("816bc59c-107f-4138-800c-8a46f2c8e9c6") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("890c94d0-3f7a-4f94-ab9e-ddb05298d145") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"), new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1d59509c-2313-48a2-b4d7-a98eaeb62310"), new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("1df509b5-38e5-45e3-baa7-399dcb6fd2c1"), new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2f7d19a4-5af3-4c55-956f-f426f8f199c4"), new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("66fe5019-886e-4cce-ae25-48fc1c37c4c6"), new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7eae4217-40c9-44cb-8117-1bc1b822ffcb"), new Guid("816bc59c-107f-4138-800c-8a46f2c8e9c6") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("7d19af50-709e-4a8e-af45-ac7078da2f9c") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"), new Guid("b81d96cf-b9ea-487a-884f-a39ac0d92f7b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8ff86c0d-7b0d-4133-87f8-cc64ec4a2901"), new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cb1a692d-72f0-4f69-887e-7cd40053c64e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("24bb347c-8a59-4196-ab94-b6115e0228a4"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("5a07249d-b8d5-40d7-97aa-2287a5f9603e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("618e48be-2d8d-4060-9870-145b9542f3cb"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7d19af50-709e-4a8e-af45-ac7078da2f9c"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7f577522-97e8-4dc0-ba6b-dcdba53aab5f"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("816bc59c-107f-4138-800c-8a46f2c8e9c6"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("890c94d0-3f7a-4f94-ab9e-ddb05298d145"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("b81d96cf-b9ea-487a-884f-a39ac0d92f7b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("dc67da92-60b8-4939-942a-27d98e4c5e75"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("ef706891-f1e6-45fa-a70a-c2fe9d3b8c19"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("08c96599-6a89-4280-bc02-d59fc38190a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18b3acab-da6e-4d95-bd84-5a5272ef3abe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1b892919-bb6a-4d15-bfb9-be35345a725d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1d59509c-2313-48a2-b4d7-a98eaeb62310"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1df509b5-38e5-45e3-baa7-399dcb6fd2c1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f7d19a4-5af3-4c55-956f-f426f8f199c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66fe5019-886e-4cce-ae25-48fc1c37c4c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7eae4217-40c9-44cb-8117-1bc1b822ffcb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8fc32e19-629e-4b08-be30-67ce7ee0cee5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff86c0d-7b0d-4133-87f8-cc64ec4a2901"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("78e3aad2-c78b-497d-9efa-1dd23cc29ac5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8b692d28-1c19-456d-8e3a-87df4952c448"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2cf00f7-abca-402f-a236-b157b57bc7cb"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("1ca728ff-46d1-4406-a757-400599c06912"), "Video Games", "video-games" },
                    { new Guid("9239d61a-d1fa-46f5-bc78-4a1e336bb026"), "Books", "books" },
                    { new Guid("bce4c47d-62dd-4d57-84d1-6193f4d88fd4"), "Movies", "movie" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0f38542b-d3d8-427e-966b-07b413c015a2"), "Xbox" },
                    { new Guid("17563c05-ad7c-41c0-81f5-23aeb0be34ad"), "Default" },
                    { new Guid("29db4736-9c64-4233-87fb-83ebe523f3ab"), "E-Book" },
                    { new Guid("2ef80822-406d-43e6-9cd0-b8f525f4fd88"), "Blu-ray" },
                    { new Guid("4427b851-d2c5-4241-92d6-f398e0ec02fe"), "VHS" },
                    { new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9"), "Stream" },
                    { new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf"), "Paperback" },
                    { new Guid("89eac1eb-0932-4d6b-b670-023a6139a0b9"), "PlayStation" },
                    { new Guid("8ad92a00-e051-4a34-acc2-c6b899b0dbfd"), "Audiobook" },
                    { new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f"), "PC" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("9239d61a-d1fa-46f5-bc78-4a1e336bb026"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("308fce72-676f-4ab1-82b8-82d1cdd00657"), new Guid("9239d61a-d1fa-46f5-bc78-4a1e336bb026"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("1ca728ff-46d1-4406-a757-400599c06912"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("42bbbc4d-9a9d-401f-8172-fdc6061040c2"), new Guid("1ca728ff-46d1-4406-a757-400599c06912"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("7e724e93-969d-4be8-9572-505ea485a600"), new Guid("1ca728ff-46d1-4406-a757-400599c06912"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("b3f5ed2f-bfcc-4447-9444-5260f12e7d2a"), new Guid("1ca728ff-46d1-4406-a757-400599c06912"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("cb5c0899-500e-4b25-be6a-a72c0d4d1bea"), new Guid("9239d61a-d1fa-46f5-bc78-4a1e336bb026"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("d6392455-5dc6-4daf-bd9b-5da92644a823"), new Guid("1ca728ff-46d1-4406-a757-400599c06912"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("e3764e19-c2c6-485a-bf72-8c424d449ff4"), new Guid("bce4c47d-62dd-4d57-84d1-6193f4d88fd4"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("eea82bff-726c-46e0-a311-372fdbbe3b8b"), new Guid("bce4c47d-62dd-4d57-84d1-6193f4d88fd4"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("bce4c47d-62dd-4d57-84d1-6193f4d88fd4"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("29db4736-9c64-4233-87fb-83ebe523f3ab"), 0m, 7.99m },
                    { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf"), 19.99m, 9.99m },
                    { new Guid("062f2db1-53dc-4ea5-b033-1453c2217544"), new Guid("8ad92a00-e051-4a34-acc2-c6b899b0dbfd"), 29.99m, 19.99m },
                    { new Guid("308fce72-676f-4ab1-82b8-82d1cdd00657"), new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf"), 14.99m, 7.99m },
                    { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("0f38542b-d3d8-427e-966b-07b413c015a2"), 59.99m, 49.99m },
                    { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("89eac1eb-0932-4d6b-b670-023a6139a0b9"), 0m, 69.99m },
                    { new Guid("3d221308-2992-4ab2-b011-96c95ebe13ce"), new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f"), 29.99m, 19.99m },
                    { new Guid("7e724e93-969d-4be8-9572-505ea485a600"), new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f"), 0m, 14.99m },
                    { new Guid("b3f5ed2f-bfcc-4447-9444-5260f12e7d2a"), new Guid("d8962530-8ca2-4359-be30-5ba2b4fae97f"), 24.99m, 9.99m },
                    { new Guid("cb5c0899-500e-4b25-be6a-a72c0d4d1bea"), new Guid("543758af-f1d8-46f6-acc2-d7cdf269f1cf"), 0m, 6.99m },
                    { new Guid("d6392455-5dc6-4daf-bd9b-5da92644a823"), new Guid("17563c05-ad7c-41c0-81f5-23aeb0be34ad"), 299m, 159.99m },
                    { new Guid("e3764e19-c2c6-485a-bf72-8c424d449ff4"), new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9"), 0m, 2.99m },
                    { new Guid("eea82bff-726c-46e0-a311-372fdbbe3b8b"), new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9"), 0m, 3.99m },
                    { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("17563c05-ad7c-41c0-81f5-23aeb0be34ad"), 399m, 79.99m },
                    { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("2ef80822-406d-43e6-9cd0-b8f525f4fd88"), 0m, 9.99m },
                    { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("4427b851-d2c5-4241-92d6-f398e0ec02fe"), 0m, 19.99m },
                    { new Guid("f2d9ac7b-8630-4af7-a541-fc3290ac53cd"), new Guid("53b0e1dd-29e4-49b7-9a9a-b2f8c21a25f9"), 0m, 3.99m }
                });
        }
    }
}
