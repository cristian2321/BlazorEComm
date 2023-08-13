using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class CategoryCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58857394-2d37-4951-8286-d15a8596ab89"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66654177-ba86-48b9-8b30-37d317c923e9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94bbf516-49aa-4065-b5ad-284f6c4c739f"));

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("0c3d4a63-7e88-488b-867b-00419a4e7c58"), "Movies", "movie" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("6c4a7abd-fea0-4188-b588-8dfec8d7c936"), "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { new Guid("9ec09ad2-2c46-425b-98e8-24b519c28cf9"), "Books", "books" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("383abfa4-5e25-4007-8a2c-19e6d75572e4"), new Guid("9ec09ad2-2c46-425b-98e8-24b519c28cf9"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. ", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 7.99m, "Ready Player One" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("b0525dcb-e03b-449c-abe5-2002666527f1"), new Guid("9ec09ad2-2c46-425b-98e8-24b519c28cf9"), "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("c15c0b84-e668-4320-b743-c84263c2ed52"), new Guid("9ec09ad2-2c46-425b-98e8-24b519c28cf9"), "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwel", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg", 8.99m, "Nineteen Eighty-Four" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("383abfa4-5e25-4007-8a2c-19e6d75572e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0525dcb-e03b-449c-abe5-2002666527f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c15c0b84-e668-4320-b743-c84263c2ed52"));

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("58857394-2d37-4951-8286-d15a8596ab89"), "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. ", "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg", 7.99m, "Ready Player One" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("66654177-ba86-48b9-8b30-37d317c923e9"), "Nineteen Eighty-Four (also published as 1984) is a dystopian social science fiction novel and cautionary tale by English writer George Orwel", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c3/1984first.jpg/220px-1984first.jpg", 8.99m, "Nineteen Eighty-Four" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("94bbf516-49aa-4065-b5ad-284f6c4c739f"), "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4", "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg", 9.99m, "The Hitchhiker's Guide to the Galaxy" });
        }
    }
}
