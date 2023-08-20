using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class OrderPaymentFlag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("0b333646-7735-4ea7-af10-160360f2d586") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("2bdbb0af-1b9d-49e7-92a8-d6cccd0a0bab") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("7e972e36-6728-4405-8fed-6e3355e75943") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("55edb47d-d9fc-4df5-ba7e-6aa52dfbbffa") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("c1894849-6416-41a9-9ad9-4e6b816747e2") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3894edf6-db7d-4aea-9d07-17f250216ecb"), new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("61920446-24f9-48fb-9e78-50e094c8f0a7"), new Guid("8e6d072d-8934-4095-9222-b4b4954e9090") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8c3914e7-c613-4e81-8e0a-ad0980c3ec21"), new Guid("8e6d072d-8934-4095-9222-b4b4954e9090") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8ff57ea8-9a7d-401e-ba27-6a59699c5aa5"), new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("c0bad4fd-ccfa-4fb3-8816-a884809024e6"), new Guid("0b333646-7735-4ea7-af10-160360f2d586") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("ce9dc9ef-2fa0-4687-af21-a9f31425ed6d"), new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("dbab11f8-dc25-4b65-8c60-694f53400703"), new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("71ee2f35-2f43-4b87-98f9-155a7e085292") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("8e6d072d-8934-4095-9222-b4b4954e9090") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("c7f8f366-7a68-442a-a944-a3b530ccd9a3") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2b5cc1cf-8a22-42bd-81ff-7877be249476"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("0b333646-7735-4ea7-af10-160360f2d586"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("2bdbb0af-1b9d-49e7-92a8-d6cccd0a0bab"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("55edb47d-d9fc-4df5-ba7e-6aa52dfbbffa"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("71ee2f35-2f43-4b87-98f9-155a7e085292"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7e972e36-6728-4405-8fed-6e3355e75943"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("c1894849-6416-41a9-9ad9-4e6b816747e2"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("c7f8f366-7a68-442a-a944-a3b530ccd9a3"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3894edf6-db7d-4aea-9d07-17f250216ecb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("61920446-24f9-48fb-9e78-50e094c8f0a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8c3914e7-c613-4e81-8e0a-ad0980c3ec21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8ff57ea8-9a7d-401e-ba27-6a59699c5aa5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c0bad4fd-ccfa-4fb3-8816-a884809024e6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce9dc9ef-2fa0-4687-af21-a9f31425ed6d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("dbab11f8-dc25-4b65-8c60-694f53400703"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f789632c-2b88-4fc1-a138-67d540625f38"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"));

            migrationBuilder.AddColumn<bool>(
                name: "IsPayment",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsPayment",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"), "Books", "books" },
                    { new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"), "Movies", "movie" },
                    { new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"), "Video Games", "video-games" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0b333646-7735-4ea7-af10-160360f2d586"), "Default" },
                    { new Guid("2bdbb0af-1b9d-49e7-92a8-d6cccd0a0bab"), "Blu-ray" },
                    { new Guid("55edb47d-d9fc-4df5-ba7e-6aa52dfbbffa"), "Audiobook" },
                    { new Guid("71ee2f35-2f43-4b87-98f9-155a7e085292"), "PlayStation" },
                    { new Guid("7e972e36-6728-4405-8fed-6e3355e75943"), "VHS" },
                    { new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"), "Stream" },
                    { new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"), "PC" },
                    { new Guid("c1894849-6416-41a9-9ad9-4e6b816747e2"), "E-Book" },
                    { new Guid("c7f8f366-7a68-442a-a944-a3b530ccd9a3"), "Xbox" },
                    { new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"), "Paperback" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("2b5cc1cf-8a22-42bd-81ff-7877be249476"), new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("3894edf6-db7d-4aea-9d07-17f250216ecb"), new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("61920446-24f9-48fb-9e78-50e094c8f0a7"), new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("8c3914e7-c613-4e81-8e0a-ad0980c3ec21"), new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("8ff57ea8-9a7d-401e-ba27-6a59699c5aa5"), new Guid("5b352c7f-487d-446e-9413-24bd9d50e497"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("c0bad4fd-ccfa-4fb3-8816-a884809024e6"), new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("ce9dc9ef-2fa0-4687-af21-a9f31425ed6d"), new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("dbab11f8-dc25-4b65-8c60-694f53400703"), new Guid("c063ba85-bfc0-4f2d-b535-b8ded4d1e646"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("c8c5a3c0-6657-443a-9e31-dc81686b25e7"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("0b333646-7735-4ea7-af10-160360f2d586"), 399m, 79.99m },
                    { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("2bdbb0af-1b9d-49e7-92a8-d6cccd0a0bab"), 0m, 9.99m },
                    { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("7e972e36-6728-4405-8fed-6e3355e75943"), 0m, 19.99m },
                    { new Guid("028be12c-b21d-4c0f-9407-e6d182759fcf"), new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"), 0m, 3.99m },
                    { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("55edb47d-d9fc-4df5-ba7e-6aa52dfbbffa"), 29.99m, 19.99m },
                    { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("c1894849-6416-41a9-9ad9-4e6b816747e2"), 0m, 7.99m },
                    { new Guid("06e45c69-465c-476f-a3a6-c89807470e9c"), new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"), 19.99m, 9.99m },
                    { new Guid("3894edf6-db7d-4aea-9d07-17f250216ecb"), new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"), 14.99m, 7.99m },
                    { new Guid("61920446-24f9-48fb-9e78-50e094c8f0a7"), new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"), 24.99m, 9.99m },
                    { new Guid("8c3914e7-c613-4e81-8e0a-ad0980c3ec21"), new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"), 0m, 14.99m },
                    { new Guid("8ff57ea8-9a7d-401e-ba27-6a59699c5aa5"), new Guid("dcd8aa2d-7f3e-4276-964e-1a5630b061dd"), 0m, 6.99m },
                    { new Guid("c0bad4fd-ccfa-4fb3-8816-a884809024e6"), new Guid("0b333646-7735-4ea7-af10-160360f2d586"), 299m, 159.99m },
                    { new Guid("ce9dc9ef-2fa0-4687-af21-a9f31425ed6d"), new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"), 0m, 3.99m },
                    { new Guid("dbab11f8-dc25-4b65-8c60-694f53400703"), new Guid("8593be49-eae4-426e-867c-3c40eb1bfba0"), 0m, 2.99m },
                    { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("71ee2f35-2f43-4b87-98f9-155a7e085292"), 0m, 69.99m },
                    { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("8e6d072d-8934-4095-9222-b4b4954e9090"), 29.99m, 19.99m },
                    { new Guid("f789632c-2b88-4fc1-a138-67d540625f38"), new Guid("c7f8f366-7a68-442a-a944-a3b530ccd9a3"), 59.99m, 49.99m }
                });
        }
    }
}
