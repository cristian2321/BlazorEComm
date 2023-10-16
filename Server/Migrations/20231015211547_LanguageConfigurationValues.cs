using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class LanguageConfigurationValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("41609a6b-8f68-4af3-ba69-a0d0ba0dc304"), true, "MessageLoadingProducts", "en", "Loading product ..." },
                    { new Guid("602bfc65-c828-41e0-b579-b39c55369536"), true, "NoProductsFound", "en", "No products found" },
                    { new Guid("765bdef3-0c7b-4ca5-a249-8f5955dc4356"), true, "ProductsByPage", "en", "5" },
                    { new Guid("79ba045e-aeb6-44b5-9b42-d4473f1bb49f"), true, "DefaultLanguage", "", "en" },
                    { new Guid("afa6996f-70de-4c8b-87de-64c614edc575"), true, "CompanyName", "en", "Cristian Company" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("41609a6b-8f68-4af3-ba69-a0d0ba0dc304"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("602bfc65-c828-41e0-b579-b39c55369536"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("765bdef3-0c7b-4ca5-a249-8f5955dc4356"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("79ba045e-aeb6-44b5-9b42-d4473f1bb49f"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("afa6996f-70de-4c8b-87de-64c614edc575"));

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
    }
}
