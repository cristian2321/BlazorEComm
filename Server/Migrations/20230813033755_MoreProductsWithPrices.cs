using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class MoreProductsWithPrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ad02208-eb1a-4531-8ded-02aeed368a98"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("25a5f85b-cd49-408c-b7b4-74695aebd445"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34b07161-4699-4b80-be5a-99b4eba43dda"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52bce08b-abb6-4f42-b516-770fd7012bfe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6cfe9aa8-df66-403a-9978-69ac2f6de8a8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6dc4414b-16a5-4d38-a951-46bae4cfe486"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("98b3ce84-7708-477b-b5b5-65e5f53986fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c6008fe1-2ae3-4b4f-9c18-1e568f940225"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("da986bdf-f18f-4039-8516-561ca43c8538"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ece224b6-7775-4584-a849-6fa6fc182fde"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f9ad485d-bb91-4c55-9cf0-71d7500fcfb6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43fa5f88-ce1e-4b45-8f85-baf69cede585"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d20cc107-e665-4ef4-98a3-f260aec449fb"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"), "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("43fa5f88-ce1e-4b45-8f85-baf69cede585"), "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("d20cc107-e665-4ef4-98a3-f260aec449fb"), "Movies", "movie" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { new Guid("0ad02208-eb1a-4531-8ded-02aeed368a98"), new Guid("d20cc107-e665-4ef4-98a3-f260aec449fb"), "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.", "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg", 0m, "Back to the Future" },
                    { new Guid("25a5f85b-cd49-408c-b7b4-74695aebd445"), new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"), "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.", "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png", 0m, "Diablo II" },
                    { new Guid("34b07161-4699-4b80-be5a-99b4eba43dda"), new Guid("d20cc107-e665-4ef4-98a3-f260aec449fb"), "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.", "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg", 0m, "The Matrix" },
                    { new Guid("52bce08b-abb6-4f42-b516-770fd7012bfe"), new Guid("d20cc107-e665-4ef4-98a3-f260aec449fb"), "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar. The film was directed by John Lasseter (in his feature directorial debut), and written by Joss Whedon, Andrew Stanton, Joel Cohen, and Alec Sokolow from a story by Lasseter, Stanton, Pete Docter, and Joe Ranft. The film features music by Randy Newman, was produced by Bonnie Arnold and Ralph Guggenheim, and was executive-produced by Steve Jobs and Edwin Catmull. The film features the voices of Tom Hanks, Tim Allen, Don Rickles, Wallace Shawn, John Ratzenberger, Jim Varney, Annie Potts, R. Lee Ermey, John Morris, Laurie Metcalf, and Erik von Detten. Taking place in a world where anthropomorphic toys come to life when humans are not present, the plot focuses on the relationship between an old-fashioned pull-string cowboy doll named Woody and an astronaut action figure, Buzz Lightyear, as they evolve from rivals competing for the affections of their owner, Andy Davis, to friends who work together to be reunited with Andy after being separated from him.", "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg", 0m, "Toy Story" },
                    { new Guid("6cfe9aa8-df66-403a-9978-69ac2f6de8a8"), new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"), "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.", "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg", 0m, "Super Nintendo Entertainment System" },
                    { new Guid("6dc4414b-16a5-4d38-a951-46bae4cfe486"), new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"), "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.", "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg", 0m, "Day of the Tentacle" },
                    { new Guid("98b3ce84-7708-477b-b5b5-65e5f53986fb"), new Guid("43fa5f88-ce1e-4b45-8f85-baf69cede585"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune. Cline sold the rights to publish the novel in June 2010, in a bidding war to the Crown Publishing Group (a division of Random House).[1] The book was published on August 16, 2011.[2] An audiobook was released the same day; it was narrated by Wil Wheaton, who was mentioned briefly in one of the chapters.[3][4]Ch. 20 In 2012, the book received an Alex Award from the Young Adult Library Services Association division of the American Library Association[5] and won the 2011 Prometheus Award.[6]", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 0m, "Ready Player One" },
                    { new Guid("c6008fe1-2ae3-4b4f-9c18-1e568f940225"), new Guid("43fa5f88-ce1e-4b45-8f85-baf69cede585"), "Nineteen Eighty-Four (also stylised as 1984) is a dystopian social science fiction novel and cautionary tale written by English writer George Orwell. It was published on 8 June 1949 by Secker & Warburg as Orwell's ninth and final book completed in his lifetime. Thematically, it centres on the consequences of totalitarianism, mass surveillance and repressive regimentation of people and behaviours within society.[2][3] Orwell, a democratic socialist, modelled the totalitarian government in the novel after Stalinist Russia and Nazi Germany.[2][3][4] More broadly, the novel examines the role of truth and facts within politics and the ways in which they are manipulated.", "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg", 0m, "Nineteen Eighty-Four" },
                    { new Guid("da986bdf-f18f-4039-8516-561ca43c8538"), new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"), "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.", "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg", 0m, "Half-Life 2" },
                    { new Guid("ece224b6-7775-4584-a849-6fa6fc182fde"), new Guid("0a2975fb-0e74-45ee-bb13-b07db280ebd1"), "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.", "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg", 0m, "Xbox" },
                    { new Guid("f9ad485d-bb91-4c55-9cf0-71d7500fcfb6"), new Guid("43fa5f88-ce1e-4b45-8f85-baf69cede585"), "The Hitchhiker's Guide to the Galaxy[note 1] (sometimes referred to as HG2G,[1] HHGTTG,[2] H2G2,[3] or tHGttG) is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including stage shows, novels, comic books, a 1981 TV series, a 1984 text-based computer game, and 2005 feature film.", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 0m, "The Hitchhiker's Guide to the Galaxy" }
                });
        }
    }
}
