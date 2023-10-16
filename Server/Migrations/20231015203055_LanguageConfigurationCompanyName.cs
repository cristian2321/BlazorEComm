using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class LanguageConfigurationCompanyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("3cae937e-7f44-4a35-a242-9acde824f89c"), true, "DefaultLanguage", "", "en" });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("40677c0c-a973-4c4b-8c5c-060360cc2a5c"), true, "ProductsByPage", "en", "5" });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("a1603d7c-4335-4d0b-8248-7ad755cf2563"), true, "CompanyName", "en", "TestConstante" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("3cae937e-7f44-4a35-a242-9acde824f89c"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("40677c0c-a973-4c4b-8c5c-060360cc2a5c"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("a1603d7c-4335-4d0b-8248-7ad755cf2563"));

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("2b5e41de-698f-49c9-a96e-2f66b2f6b9b6"), true, "ProductsByPage", "en", "5" });

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Language", "Value" },
                values: new object[] { new Guid("3cb117ff-6141-4158-b837-a89ce250ede3"), true, "DefaultLanguage", "", "en" });
        }
    }
}
