using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class ConstanteTitleFeaturedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("1a108d55-6071-47ce-9143-aed31667cd2a"), true, "DefaultLanguage", "", "en" },
                    { new Guid("1be8e099-f5dd-4663-b920-29e49e53bb07"), true, "CompanyName", "en", "Cristian Company" },
                    { new Guid("44d11148-6868-4a40-9f6e-ac6de7e9cae8"), true, "MessageLoadingProducts", "en", "Loading product ..." },
                    { new Guid("4761ada0-7299-4b68-b25d-751f438f90a5"), true, "NoProductsFound", "en", "No products found" },
                    { new Guid("819e9f4e-32e0-4340-b54a-25d73118d8ba"), true, "TitleFeaturedProducts", "en", "Top Products of Today" },
                    { new Guid("f7f61d18-5089-4f99-9a9e-5f9883c59b5f"), true, "ProductsByPage", "en", "5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("1a108d55-6071-47ce-9143-aed31667cd2a"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("1be8e099-f5dd-4663-b920-29e49e53bb07"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("44d11148-6868-4a40-9f6e-ac6de7e9cae8"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("4761ada0-7299-4b68-b25d-751f438f90a5"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("819e9f4e-32e0-4340-b54a-25d73118d8ba"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("f7f61d18-5089-4f99-9a9e-5f9883c59b5f"));

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
    }
}
