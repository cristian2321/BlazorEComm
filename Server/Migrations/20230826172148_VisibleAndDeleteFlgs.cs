using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class VisibleAndDeleteFlgs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("486bab24-4be7-46ba-8fc3-e8a96f8ab5f3") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("f79ec532-5662-479b-aaf7-a7fd4a81ca1d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("139ea120-9496-447c-ac9d-354c1089fc0d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("3286576c-81f3-405d-b945-e1fe412bb5f0") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("f294d41a-7b38-439b-b1c8-208f0667de3b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("1ae12df5-5edc-4846-be1c-debe7aa528e2") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("83d7c5e4-13e0-427d-b76f-88dd31c91c89") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("ecf47341-500e-40a4-9ec1-bc32b919d876") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("618782d5-d79d-4ca7-8b63-508035c892e9"), new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("623cdc2c-7002-4f06-b5f3-3dac008c9e21"), new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("73cb56c6-3937-4355-b9cb-b30f2fabcc97"), new Guid("139ea120-9496-447c-ac9d-354c1089fc0d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("7da7f526-9732-4e3c-aa0b-0b08032a9486"), new Guid("139ea120-9496-447c-ac9d-354c1089fc0d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("87528ac5-9855-47b9-bc42-a62762ebaa69"), new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8aac7f8f-595d-4005-84e0-f5ebe757b0d6"), new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("ad515d62-298a-4a96-9807-f028d9aba2a3"), new Guid("ecf47341-500e-40a4-9ec1-bc32b919d876") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6da5ad5b-a49c-4e19-a657-50d7a0be98f1"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("139ea120-9496-447c-ac9d-354c1089fc0d"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("1ae12df5-5edc-4846-be1c-debe7aa528e2"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3286576c-81f3-405d-b945-e1fe412bb5f0"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("486bab24-4be7-46ba-8fc3-e8a96f8ab5f3"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("83d7c5e4-13e0-427d-b76f-88dd31c91c89"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("ecf47341-500e-40a4-9ec1-bc32b919d876"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("f294d41a-7b38-439b-b1c8-208f0667de3b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("f79ec532-5662-479b-aaf7-a7fd4a81ca1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("063d488e-6962-4e31-bb52-18234c630453"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("618782d5-d79d-4ca7-8b63-508035c892e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("623cdc2c-7002-4f06-b5f3-3dac008c9e21"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("73cb56c6-3937-4355-b9cb-b30f2fabcc97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7da7f526-9732-4e3c-aa0b-0b08032a9486"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("87528ac5-9855-47b9-bc42-a62762ebaa69"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8aac7f8f-595d-4005-84e0-f5ebe757b0d6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad515d62-298a-4a96-9807-f028d9aba2a3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7bae641e-dd54-4f92-9293-502074985f4d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f34e5c27-a0b6-44e3-a080-25f6c10bd372"));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ProductVariants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "ProductTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "ProductTypes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Deleted", "Name", "Url", "Visible" },
                values: new object[,]
                {
                    { new Guid("b9cbc24e-e9e6-4a25-bf88-e25e39f5b71d"), false, "Movies", "movie", true },
                    { new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"), false, "Video Games", "video-games", true },
                    { new Guid("fb9b3cd9-0d89-4259-a941-97404819915b"), false, "Books", "books", true }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Deleted", "Name", "Visible" },
                values: new object[,]
                {
                    { new Guid("22e8adb8-61e5-48db-a16c-996aaf78f184"), false, "VHS", true },
                    { new Guid("5179ac18-7d0b-4ce4-8bb4-fdf7cfe2c8f9"), false, "Blu-ray", true },
                    { new Guid("51ab7cc5-4c1c-4404-ab16-42c299b87a4b"), false, "E-Book", true },
                    { new Guid("75392327-0637-4f30-87ea-b1349bef8781"), false, "PC", true },
                    { new Guid("8156fb01-242f-424a-b0ed-5376c215d4d4"), false, "Default", true },
                    { new Guid("9377b066-092f-42bb-8854-8f43110e627e"), false, "Xbox", true },
                    { new Guid("bae0ca49-9fbd-4e00-925f-cab94c72c86a"), false, "Audiobook", true },
                    { new Guid("c7567437-bd09-4290-b345-98f139e0bba7"), false, "PlayStation", true },
                    { new Guid("c90c5145-2396-4a53-a8da-6382921b81aa"), false, "Paperback", true },
                    { new Guid("e696781e-5530-4946-a719-b4aa58048f33"), false, "Stream", true }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Deleted", "Description", "Featured", "ImageUrl", "Title", "Visible" },
                values: new object[,]
                {
                    { new Guid("2a6dc38b-4e41-4011-b10d-e31c219069c4"), new Guid("fb9b3cd9-0d89-4259-a941-97404819915b"), false, "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four", true },
                    { new Guid("31fa7cd6-55fa-49bf-b93d-e60e1e0de0c5"), new Guid("b9cbc24e-e9e6-4a25-bf88-e25e39f5b71d"), false, "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story", true },
                    { new Guid("5af060e2-4de0-420a-8162-7800465ded97"), new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"), false, "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox", true },
                    { new Guid("6395718c-174b-4eb3-8120-2405d09e756e"), new Guid("fb9b3cd9-0d89-4259-a941-97404819915b"), false, "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One", true },
                    { new Guid("72699fe5-4731-441b-8e9e-11f1df94a892"), new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"), false, "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II", true },
                    { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"), false, "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2", true },
                    { new Guid("aabe68aa-3b21-4a1f-aa10-3687b0f6910d"), new Guid("b9cbc24e-e9e6-4a25-bf88-e25e39f5b71d"), false, "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future", true },
                    { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("fb9b3cd9-0d89-4259-a941-97404819915b"), false, "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy", true },
                    { new Guid("b5b201ae-96e5-4094-9418-3a5e6adfb973"), new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"), false, "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle", true },
                    { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("b9cbc24e-e9e6-4a25-bf88-e25e39f5b71d"), false, "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix", true },
                    { new Guid("f05f6904-f84d-4155-bc98-c040a5cce5dd"), new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"), false, "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System", true }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "Deleted", "OriginalPrice", "Price", "Visible" },
                values: new object[,]
                {
                    { new Guid("2a6dc38b-4e41-4011-b10d-e31c219069c4"), new Guid("c90c5145-2396-4a53-a8da-6382921b81aa"), false, 0m, 6.99m, true },
                    { new Guid("31fa7cd6-55fa-49bf-b93d-e60e1e0de0c5"), new Guid("e696781e-5530-4946-a719-b4aa58048f33"), false, 0m, 2.99m, true },
                    { new Guid("5af060e2-4de0-420a-8162-7800465ded97"), new Guid("8156fb01-242f-424a-b0ed-5376c215d4d4"), false, 299m, 159.99m, true },
                    { new Guid("6395718c-174b-4eb3-8120-2405d09e756e"), new Guid("c90c5145-2396-4a53-a8da-6382921b81aa"), false, 14.99m, 7.99m, true },
                    { new Guid("72699fe5-4731-441b-8e9e-11f1df94a892"), new Guid("75392327-0637-4f30-87ea-b1349bef8781"), false, 24.99m, 9.99m, true },
                    { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("75392327-0637-4f30-87ea-b1349bef8781"), false, 29.99m, 19.99m, true },
                    { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("9377b066-092f-42bb-8854-8f43110e627e"), false, 59.99m, 49.99m, true },
                    { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("c7567437-bd09-4290-b345-98f139e0bba7"), false, 0m, 69.99m, true },
                    { new Guid("aabe68aa-3b21-4a1f-aa10-3687b0f6910d"), new Guid("e696781e-5530-4946-a719-b4aa58048f33"), false, 0m, 3.99m, true },
                    { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("51ab7cc5-4c1c-4404-ab16-42c299b87a4b"), false, 0m, 7.99m, true },
                    { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("bae0ca49-9fbd-4e00-925f-cab94c72c86a"), false, 29.99m, 19.99m, true },
                    { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("c90c5145-2396-4a53-a8da-6382921b81aa"), false, 19.99m, 9.99m, true },
                    { new Guid("b5b201ae-96e5-4094-9418-3a5e6adfb973"), new Guid("75392327-0637-4f30-87ea-b1349bef8781"), false, 0m, 14.99m, true },
                    { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("22e8adb8-61e5-48db-a16c-996aaf78f184"), false, 0m, 19.99m, true },
                    { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("5179ac18-7d0b-4ce4-8bb4-fdf7cfe2c8f9"), false, 0m, 9.99m, true },
                    { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("8156fb01-242f-424a-b0ed-5376c215d4d4"), false, 399m, 79.99m, true },
                    { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("e696781e-5530-4946-a719-b4aa58048f33"), false, 0m, 3.99m, true }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("2a6dc38b-4e41-4011-b10d-e31c219069c4"), new Guid("c90c5145-2396-4a53-a8da-6382921b81aa") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("31fa7cd6-55fa-49bf-b93d-e60e1e0de0c5"), new Guid("e696781e-5530-4946-a719-b4aa58048f33") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("5af060e2-4de0-420a-8162-7800465ded97"), new Guid("8156fb01-242f-424a-b0ed-5376c215d4d4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("6395718c-174b-4eb3-8120-2405d09e756e"), new Guid("c90c5145-2396-4a53-a8da-6382921b81aa") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("72699fe5-4731-441b-8e9e-11f1df94a892"), new Guid("75392327-0637-4f30-87ea-b1349bef8781") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("75392327-0637-4f30-87ea-b1349bef8781") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("9377b066-092f-42bb-8854-8f43110e627e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"), new Guid("c7567437-bd09-4290-b345-98f139e0bba7") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("aabe68aa-3b21-4a1f-aa10-3687b0f6910d"), new Guid("e696781e-5530-4946-a719-b4aa58048f33") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("51ab7cc5-4c1c-4404-ab16-42c299b87a4b") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("bae0ca49-9fbd-4e00-925f-cab94c72c86a") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"), new Guid("c90c5145-2396-4a53-a8da-6382921b81aa") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("b5b201ae-96e5-4094-9418-3a5e6adfb973"), new Guid("75392327-0637-4f30-87ea-b1349bef8781") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("22e8adb8-61e5-48db-a16c-996aaf78f184") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("5179ac18-7d0b-4ce4-8bb4-fdf7cfe2c8f9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("8156fb01-242f-424a-b0ed-5376c215d4d4") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"), new Guid("e696781e-5530-4946-a719-b4aa58048f33") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f05f6904-f84d-4155-bc98-c040a5cce5dd"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("22e8adb8-61e5-48db-a16c-996aaf78f184"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("5179ac18-7d0b-4ce4-8bb4-fdf7cfe2c8f9"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("51ab7cc5-4c1c-4404-ab16-42c299b87a4b"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("75392327-0637-4f30-87ea-b1349bef8781"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("8156fb01-242f-424a-b0ed-5376c215d4d4"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("9377b066-092f-42bb-8854-8f43110e627e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("bae0ca49-9fbd-4e00-925f-cab94c72c86a"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("c7567437-bd09-4290-b345-98f139e0bba7"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("c90c5145-2396-4a53-a8da-6382921b81aa"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("e696781e-5530-4946-a719-b4aa58048f33"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a6dc38b-4e41-4011-b10d-e31c219069c4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("31fa7cd6-55fa-49bf-b93d-e60e1e0de0c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5af060e2-4de0-420a-8162-7800465ded97"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6395718c-174b-4eb3-8120-2405d09e756e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72699fe5-4731-441b-8e9e-11f1df94a892"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("83f54ab8-f3ba-4be1-bb22-a814d0e7eb0c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("aabe68aa-3b21-4a1f-aa10-3687b0f6910d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b3b0f544-9153-434e-a7ce-0b97465d06bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b5b201ae-96e5-4094-9418-3a5e6adfb973"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bcd41178-8e23-496c-aa96-0aeb14c14db4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b9cbc24e-e9e6-4a25-bf88-e25e39f5b71d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d82c9ce2-78f7-4e47-b34a-c3f1d6d7d34f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fb9b3cd9-0d89-4259-a941-97404819915b"));

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductVariants");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Deleted", "Name", "Url", "Visible" },
                values: new object[,]
                {
                    { new Guid("7bae641e-dd54-4f92-9293-502074985f4d"), false, "Books", "books", true },
                    { new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"), false, "Video Games", "video-games", true },
                    { new Guid("f34e5c27-a0b6-44e3-a080-25f6c10bd372"), false, "Movies", "movie", true }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("139ea120-9496-447c-ac9d-354c1089fc0d"), "PC" },
                    { new Guid("1ae12df5-5edc-4846-be1c-debe7aa528e2"), "VHS" },
                    { new Guid("3286576c-81f3-405d-b945-e1fe412bb5f0"), "Xbox" },
                    { new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1"), "Paperback" },
                    { new Guid("486bab24-4be7-46ba-8fc3-e8a96f8ab5f3"), "E-Book" },
                    { new Guid("83d7c5e4-13e0-427d-b76f-88dd31c91c89"), "Blu-ray" },
                    { new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b"), "Stream" },
                    { new Guid("ecf47341-500e-40a4-9ec1-bc32b919d876"), "Default" },
                    { new Guid("f294d41a-7b38-439b-b1c8-208f0667de3b"), "PlayStation" },
                    { new Guid("f79ec532-5662-479b-aaf7-a7fd4a81ca1d"), "Audiobook" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("7bae641e-dd54-4f92-9293-502074985f4d"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("f34e5c27-a0b6-44e3-a080-25f6c10bd372"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("618782d5-d79d-4ca7-8b63-508035c892e9"), new Guid("7bae641e-dd54-4f92-9293-502074985f4d"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("623cdc2c-7002-4f06-b5f3-3dac008c9e21"), new Guid("7bae641e-dd54-4f92-9293-502074985f4d"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("6da5ad5b-a49c-4e19-a657-50d7a0be98f1"), new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("73cb56c6-3937-4355-b9cb-b30f2fabcc97"), new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" },
                    { new Guid("7da7f526-9732-4e3c-aa0b-0b08032a9486"), new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("87528ac5-9855-47b9-bc42-a62762ebaa69"), new Guid("f34e5c27-a0b6-44e3-a080-25f6c10bd372"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("8aac7f8f-595d-4005-84e0-f5ebe757b0d6"), new Guid("f34e5c27-a0b6-44e3-a080-25f6c10bd372"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("ad515d62-298a-4a96-9807-f028d9aba2a3"), new Guid("8f34e332-8fab-4082-a3ce-bf19bcbf6aef"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1"), 19.99m, 9.99m },
                    { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("486bab24-4be7-46ba-8fc3-e8a96f8ab5f3"), 0m, 7.99m },
                    { new Guid("063d488e-6962-4e31-bb52-18234c630453"), new Guid("f79ec532-5662-479b-aaf7-a7fd4a81ca1d"), 29.99m, 19.99m },
                    { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("139ea120-9496-447c-ac9d-354c1089fc0d"), 29.99m, 19.99m },
                    { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("3286576c-81f3-405d-b945-e1fe412bb5f0"), 59.99m, 49.99m },
                    { new Guid("2433a492-8865-4f72-afaf-3dabecba5d09"), new Guid("f294d41a-7b38-439b-b1c8-208f0667de3b"), 0m, 69.99m },
                    { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("1ae12df5-5edc-4846-be1c-debe7aa528e2"), 0m, 19.99m },
                    { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("83d7c5e4-13e0-427d-b76f-88dd31c91c89"), 0m, 9.99m },
                    { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b"), 0m, 3.99m },
                    { new Guid("50d110b0-2734-46c2-ac10-97a122a0e313"), new Guid("ecf47341-500e-40a4-9ec1-bc32b919d876"), 399m, 79.99m },
                    { new Guid("618782d5-d79d-4ca7-8b63-508035c892e9"), new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1"), 0m, 6.99m },
                    { new Guid("623cdc2c-7002-4f06-b5f3-3dac008c9e21"), new Guid("35eab96a-6494-4d7a-ab78-cf98af41dcc1"), 14.99m, 7.99m },
                    { new Guid("73cb56c6-3937-4355-b9cb-b30f2fabcc97"), new Guid("139ea120-9496-447c-ac9d-354c1089fc0d"), 24.99m, 9.99m },
                    { new Guid("7da7f526-9732-4e3c-aa0b-0b08032a9486"), new Guid("139ea120-9496-447c-ac9d-354c1089fc0d"), 0m, 14.99m },
                    { new Guid("87528ac5-9855-47b9-bc42-a62762ebaa69"), new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b"), 0m, 2.99m },
                    { new Guid("8aac7f8f-595d-4005-84e0-f5ebe757b0d6"), new Guid("e1e9c7c0-56f4-4cc7-a57d-41a6c82b532b"), 0m, 3.99m },
                    { new Guid("ad515d62-298a-4a96-9807-f028d9aba2a3"), new Guid("ecf47341-500e-40a4-9ec1-bc32b919d876"), 299m, 159.99m }
                });
        }
    }
}
