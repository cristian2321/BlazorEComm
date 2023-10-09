using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class CategoryMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("43a5e403-a9fd-4581-a6ab-9bb1ce966d0e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("88b8c2f1-f401-4803-8c31-87bbed121827") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("93d15c25-d351-44b7-be11-6c6cdfe2c4ee") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("8d5d7c2b-0860-4653-8bb6-d6379a04d31e"), new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("9c583d05-19aa-4888-8597-558458367e6e"), new Guid("6f4e48b8-d876-492a-92af-ea10794ab478") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("3e1fa050-7dc4-46bb-b267-5d62bb4c415d") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("f0cb24e1-abb0-4827-8ee6-53b4378e123e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("6f4e48b8-d876-492a-92af-ea10794ab478") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("7b034d54-25c4-462e-8d60-bb46bb02db23") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("b8fe9a3c-843b-4050-8712-8b3d845e383e") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("c233324d-1533-47c8-a7dd-49272ed45563"), new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("eccbb120-1622-43c3-929b-ecad25a53941"), new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f23a3822-0362-4413-af6a-60256fe9ba35"), new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("f92a1771-294b-40c9-9bbb-20d1d76c3da2"), new Guid("88b8c2f1-f401-4803-8c31-87bbed121827") });

            migrationBuilder.DeleteData(
                table: "ProductVariants",
                keyColumns: new[] { "ProductId", "ProductTypeId" },
                keyValues: new object[] { new Guid("fdec324a-4d6e-4a58-9500-2c150b16f615"), new Guid("6f4e48b8-d876-492a-92af-ea10794ab478") });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("21b7ded7-dd55-4ec3-a371-0de1188fac52"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("3e1fa050-7dc4-46bb-b267-5d62bb4c415d"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("43a5e403-a9fd-4581-a6ab-9bb1ce966d0e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("6f4e48b8-d876-492a-92af-ea10794ab478"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("7b034d54-25c4-462e-8d60-bb46bb02db23"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("88b8c2f1-f401-4803-8c31-87bbed121827"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("93d15c25-d351-44b7-be11-6c6cdfe2c4ee"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("b8fe9a3c-843b-4050-8712-8b3d845e383e"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: new Guid("f0cb24e1-abb0-4827-8ee6-53b4378e123e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8d5d7c2b-0860-4653-8bb6-d6379a04d31e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9c583d05-19aa-4888-8597-558458367e6e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c233324d-1533-47c8-a7dd-49272ed45563"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("eccbb120-1622-43c3-929b-ecad25a53941"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f23a3822-0362-4413-af6a-60256fe9ba35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f92a1771-294b-40c9-9bbb-20d1d76c3da2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("fdec324a-4d6e-4a58-9500-2c150b16f615"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6546383c-7c87-4076-aded-ee945def349a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb48baef-1f64-4888-98bf-1c1047d29c84"));

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Visible",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Visible",
                table: "Categories");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"), "Video Games", "video-games" },
                    { new Guid("6546383c-7c87-4076-aded-ee945def349a"), "Books", "books" },
                    { new Guid("bb48baef-1f64-4888-98bf-1c1047d29c84"), "Movies", "movie" }
                });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3e1fa050-7dc4-46bb-b267-5d62bb4c415d"), "Audiobook" },
                    { new Guid("43a5e403-a9fd-4581-a6ab-9bb1ce966d0e"), "Blu-ray" },
                    { new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9"), "Stream" },
                    { new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224"), "Paperback" },
                    { new Guid("6f4e48b8-d876-492a-92af-ea10794ab478"), "PC" },
                    { new Guid("7b034d54-25c4-462e-8d60-bb46bb02db23"), "PlayStation" },
                    { new Guid("88b8c2f1-f401-4803-8c31-87bbed121827"), "Default" },
                    { new Guid("93d15c25-d351-44b7-be11-6c6cdfe2c4ee"), "VHS" },
                    { new Guid("b8fe9a3c-843b-4050-8712-8b3d845e383e"), "Xbox" },
                    { new Guid("f0cb24e1-abb0-4827-8ee6-53b4378e123e"), "E-Book" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Featured", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { new Guid("21b7ded7-dd55-4ec3-a371-0de1188fac52"), new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", false, "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", "Super Nintendo Entertainment System" },
                    { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("bb48baef-1f64-4888-98bf-1c1047d29c84"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", false, "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", "The Matrix" },
                    { new Guid("8d5d7c2b-0860-4653-8bb6-d6379a04d31e"), new Guid("6546383c-7c87-4076-aded-ee945def349a"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", false, "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", "Ready Player One" },
                    { new Guid("9c583d05-19aa-4888-8597-558458367e6e"), new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", true, "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", "Day of the Tentacle" },
                    { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("6546383c-7c87-4076-aded-ee945def349a"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", true, "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", "The Hitchhiker's Guide to the Galaxy" },
                    { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", false, "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", "Half-Life 2" },
                    { new Guid("c233324d-1533-47c8-a7dd-49272ed45563"), new Guid("6546383c-7c87-4076-aded-ee945def349a"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", false, "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", "Nineteen Eighty-Four" },
                    { new Guid("eccbb120-1622-43c3-929b-ecad25a53941"), new Guid("bb48baef-1f64-4888-98bf-1c1047d29c84"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", false, "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", "Toy Story" },
                    { new Guid("f23a3822-0362-4413-af6a-60256fe9ba35"), new Guid("bb48baef-1f64-4888-98bf-1c1047d29c84"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", true, "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", "Back to the Future" },
                    { new Guid("f92a1771-294b-40c9-9bbb-20d1d76c3da2"), new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", false, "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", "Xbox" },
                    { new Guid("fdec324a-4d6e-4a58-9500-2c150b16f615"), new Guid("4d0f7fc5-9135-48be-a6d6-aa0e4f872e43"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", false, "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", "Diablo II" }
                });

            migrationBuilder.InsertData(
                table: "ProductVariants",
                columns: new[] { "ProductId", "ProductTypeId", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("43a5e403-a9fd-4581-a6ab-9bb1ce966d0e"), 0m, 9.99m },
                    { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9"), 0m, 3.99m },
                    { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("88b8c2f1-f401-4803-8c31-87bbed121827"), 399m, 79.99m },
                    { new Guid("537ec13f-dc2b-4f0d-8c2c-9523e92e1986"), new Guid("93d15c25-d351-44b7-be11-6c6cdfe2c4ee"), 0m, 19.99m },
                    { new Guid("8d5d7c2b-0860-4653-8bb6-d6379a04d31e"), new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224"), 14.99m, 7.99m },
                    { new Guid("9c583d05-19aa-4888-8597-558458367e6e"), new Guid("6f4e48b8-d876-492a-92af-ea10794ab478"), 0m, 14.99m },
                    { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("3e1fa050-7dc4-46bb-b267-5d62bb4c415d"), 29.99m, 19.99m },
                    { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224"), 19.99m, 9.99m },
                    { new Guid("a731304e-cc3a-4fe4-aae2-fb18b61a1111"), new Guid("f0cb24e1-abb0-4827-8ee6-53b4378e123e"), 0m, 7.99m },
                    { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("6f4e48b8-d876-492a-92af-ea10794ab478"), 29.99m, 19.99m },
                    { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("7b034d54-25c4-462e-8d60-bb46bb02db23"), 0m, 69.99m },
                    { new Guid("bb4c1126-eafa-46e9-a383-95c89bfc94b4"), new Guid("b8fe9a3c-843b-4050-8712-8b3d845e383e"), 59.99m, 49.99m },
                    { new Guid("c233324d-1533-47c8-a7dd-49272ed45563"), new Guid("5706028d-0b72-4a15-863b-5fb56bfd2224"), 0m, 6.99m },
                    { new Guid("eccbb120-1622-43c3-929b-ecad25a53941"), new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9"), 0m, 2.99m },
                    { new Guid("f23a3822-0362-4413-af6a-60256fe9ba35"), new Guid("4e5f29d7-5eca-4a1f-849e-132fe38b8fb9"), 0m, 3.99m },
                    { new Guid("f92a1771-294b-40c9-9bbb-20d1d76c3da2"), new Guid("88b8c2f1-f401-4803-8c31-87bbed121827"), 299m, 159.99m },
                    { new Guid("fdec324a-4d6e-4a58-9500-2c150b16f615"), new Guid("6f4e48b8-d876-492a-92af-ea10794ab478"), 24.99m, 9.99m }
                });
        }
    }
}
