using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class UserAddressRequired : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2769b41c-55d1-4e28-af63-6295bfa32581"), new Guid("00f8a06c-e673-4daf-afd6-ed3597be1d54") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("00f8a06c-e673-4daf-afd6-ed3597be1d54") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("aec0cb0e-0631-4dd7-964d-da4cf935044c") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("fd6f1ace-f556-44da-8d00-adacbcd9fdd5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("328ddefc-7084-4f0d-9e80-1a7efa96f2e1") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("df9204b6-dd7d-4945-94ec-0b2e52950454") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("3dfbf168-3bab-4cb7-a6e4-2bc4bbc01254"), new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("440d5cd2-ecb6-416a-9a92-385fcb2b102f"), new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("59f0bc2c-1c5e-40d7-bb67-c80262dd69b1"), new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("d7f90218-d150-4911-9827-21c437e9e63a") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("ef49538e-ecc5-4514-a11a-d5ddd80d883d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b4947c7f-2b82-41d3-84e2-df4bfdfd412d"), new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("cfb7ea5c-698f-47e0-85dd-2a583fac31f2"), new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("fb92536a-ca1d-4620-ad6a-3c14e53d3a23"), new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ff18d1e4-d9e9-45ea-a8ac-cfa480f18c59"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("00f8a06c-e673-4daf-afd6-ed3597be1d54"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("328ddefc-7084-4f0d-9e80-1a7efa96f2e1"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("aec0cb0e-0631-4dd7-964d-da4cf935044c"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("d7f90218-d150-4911-9827-21c437e9e63a"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("df9204b6-dd7d-4945-94ec-0b2e52950454"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("ef49538e-ecc5-4514-a11a-d5ddd80d883d"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("fd6f1ace-f556-44da-8d00-adacbcd9fdd5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2769b41c-55d1-4e28-af63-6295bfa32581"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3dfbf168-3bab-4cb7-a6e4-2bc4bbc01254"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("440d5cd2-ecb6-416a-9a92-385fcb2b102f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("59f0bc2c-1c5e-40d7-bb67-c80262dd69b1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4947c7f-2b82-41d3-84e2-df4bfdfd412d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cfb7ea5c-698f-47e0-85dd-2a583fac31f2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fb92536a-ca1d-4620-ad6a-3c14e53d3a23"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("75516464-2e91-4e6f-9752-711595463a4f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b8865054-a0cb-4953-883d-7cbb76627f91"));

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Addresses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Addresses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Addresses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Region",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("75516464-2e91-4e6f-9752-711595463a4f"), "Books", "books" },
                    { new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"), "Video Games", "video-games" },
                    { new Guid("b8865054-a0cb-4953-883d-7cbb76627f91"), "Movies", "movie" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("00f8a06c-e673-4daf-afd6-ed3597be1d54"), "Default" },
                    { new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da"), "Stream" },
                    { new Guid("328ddefc-7084-4f0d-9e80-1a7efa96f2e1"), "PlayStation" },
                    { new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213"), "Paperback" },
                    { new Guid("aec0cb0e-0631-4dd7-964d-da4cf935044c"), "VHS" },
                    { new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5"), "PC" },
                    { new Guid("d7f90218-d150-4911-9827-21c437e9e63a"), "E-Book" },
                    { new Guid("df9204b6-dd7d-4945-94ec-0b2e52950454"), "Xbox" },
                    { new Guid("ef49538e-ecc5-4514-a11a-d5ddd80d883d"), "Audiobook" },
                    { new Guid("fd6f1ace-f556-44da-8d00-adacbcd9fdd5"), "Blu-ray" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("2769b41c-55d1-4e28-af63-6295bfa32581"), new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("b8865054-a0cb-4953-883d-7cbb76627f91"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("3dfbf168-3bab-4cb7-a6e4-2bc4bbc01254"), new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("440d5cd2-ecb6-416a-9a92-385fcb2b102f"), new Guid("75516464-2e91-4e6f-9752-711595463a4f"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("59f0bc2c-1c5e-40d7-bb67-c80262dd69b1"), new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("75516464-2e91-4e6f-9752-711595463a4f"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("b4947c7f-2b82-41d3-84e2-df4bfdfd412d"), new Guid("b8865054-a0cb-4953-883d-7cbb76627f91"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("cfb7ea5c-698f-47e0-85dd-2a583fac31f2"), new Guid("75516464-2e91-4e6f-9752-711595463a4f"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("fb92536a-ca1d-4620-ad6a-3c14e53d3a23"), new Guid("b8865054-a0cb-4953-883d-7cbb76627f91"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("ff18d1e4-d9e9-45ea-a8ac-cfa480f18c59"), new Guid("8ba2ebfc-c9c0-4c5c-b087-632553f523b2"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("2769b41c-55d1-4e28-af63-6295bfa32581"), new Guid("00f8a06c-e673-4daf-afd6-ed3597be1d54"), 299m, 159.99m },
                    { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("00f8a06c-e673-4daf-afd6-ed3597be1d54"), 399m, 79.99m },
                    { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da"), 0m, 3.99m },
                    { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("aec0cb0e-0631-4dd7-964d-da4cf935044c"), 0m, 19.99m },
                    { new Guid("2dc9769b-ecab-4dc9-8ac2-9ed26ca30c7d"), new Guid("fd6f1ace-f556-44da-8d00-adacbcd9fdd5"), 0m, 9.99m },
                    { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("328ddefc-7084-4f0d-9e80-1a7efa96f2e1"), 0m, 69.99m },
                    { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5"), 29.99m, 19.99m },
                    { new Guid("3ab3aa11-488a-4ffe-8be6-d59015e1e6d0"), new Guid("df9204b6-dd7d-4945-94ec-0b2e52950454"), 59.99m, 49.99m },
                    { new Guid("3dfbf168-3bab-4cb7-a6e4-2bc4bbc01254"), new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5"), 24.99m, 9.99m },
                    { new Guid("440d5cd2-ecb6-416a-9a92-385fcb2b102f"), new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213"), 14.99m, 7.99m },
                    { new Guid("59f0bc2c-1c5e-40d7-bb67-c80262dd69b1"), new Guid("ce5ed6a5-fd85-4a39-8bfd-eda9e9b6cdd5"), 0m, 14.99m },
                    { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213"), 19.99m, 9.99m },
                    { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("d7f90218-d150-4911-9827-21c437e9e63a"), 0m, 7.99m },
                    { new Guid("5f7a48ac-f48c-41a8-88f1-03250eb0ef43"), new Guid("ef49538e-ecc5-4514-a11a-d5ddd80d883d"), 29.99m, 19.99m },
                    { new Guid("b4947c7f-2b82-41d3-84e2-df4bfdfd412d"), new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da"), 0m, 3.99m },
                    { new Guid("cfb7ea5c-698f-47e0-85dd-2a583fac31f2"), new Guid("41801c40-a65c-4cf6-b05e-7fc5d7b8c213"), 0m, 6.99m },
                    { new Guid("fb92536a-ca1d-4620-ad6a-3c14e53d3a23"), new Guid("1cb400fb-986d-4781-887d-3c5b8ad916da"), 0m, 2.99m }
                });
        }
    }
}
