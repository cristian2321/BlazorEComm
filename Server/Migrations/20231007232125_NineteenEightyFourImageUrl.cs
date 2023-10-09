using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class NineteenEightyFourImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34aa0258-676b-4d94-a7a8-e11b03b3753d"),
                column: "ImageUrl",
                value: "https://en.wikipedia.org/wiki/File:1984_first_edition_cover.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("34aa0258-676b-4d94-a7a8-e11b03b3753d"),
                column: "ImageUrl",
                value: "https://upload.wikimedia.org/wikipedia/commons/c/c3/1984first.jpg");
        }
    }
}
