using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class LanguageConfiguration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("007181e9-de7a-411d-9544-225663b78196"));

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("2b5e41de-698f-49c9-a96e-2f66b2f6b9b6"), true, "ProductsByPage", "en", "5" });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("3cb117ff-6141-4158-b837-a89ce250ede3"), true, "DefaultLanguage", "", "en" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("2b5e41de-698f-49c9-a96e-2f66b2f6b9b6"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("3cb117ff-6141-4158-b837-a89ce250ede3"));

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("007181e9-de7a-411d-9544-225663b78196"), true, "ProductsByPage", "en", "5" });
        }
    }
}
