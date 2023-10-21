using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class ConfigurationsType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("07a1f9cb-7db3-48b1-a9e5-ff01285be299"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("67abd99c-b673-4f8a-9b58-1aa0b13e3351"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("795bb102-babe-4122-bb4b-2bce21ddffde"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("abe36317-8c35-4aca-bc0e-03eda638a30e"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("e2d38dd3-eb12-47b4-8ac1-548230909304"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("f6b88c72-0460-4393-ad58-a49f8f30d56a"));

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Configurations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Deleted", "Key", "Language", "Type", "Value" },
                values: new object[,]
                {
                    { new Guid("51c52403-856c-4f31-a448-d398951d1a4f"), true, false, "DefaultLanguage", "", "Configurations Company", "en" },
                    { new Guid("9a3b309e-51bd-4aba-a03f-8a502a7b6c0f"), true, false, "CompanyName", "en", "Configurations Company", "Cristian Company" },
                    { new Guid("b5d84509-8597-4ea8-9adb-fee8659a065f"), true, false, "MessageLoadingProducts", "en", "Configurations Messages", "Loading product ..." },
                    { new Guid("cfd0de8c-1b4e-41b8-8df8-a21a0006577a"), true, false, "ProductsByPage", "en", "Configurations Product", "5" },
                    { new Guid("d0256da9-2ed3-413e-b25f-4b798f437448"), true, false, "NoProductsFound", "en", "Configurations Messages", "No products found" },
                    { new Guid("da90eac8-e29b-4092-869c-fa5f37174b0e"), true, false, "TitleFeaturedProducts", "en", "Configurations Product", "Top Products of Today" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("51c52403-856c-4f31-a448-d398951d1a4f"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("9a3b309e-51bd-4aba-a03f-8a502a7b6c0f"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("b5d84509-8597-4ea8-9adb-fee8659a065f"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("cfd0de8c-1b4e-41b8-8df8-a21a0006577a"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("d0256da9-2ed3-413e-b25f-4b798f437448"));

            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("da90eac8-e29b-4092-869c-fa5f37174b0e"));

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Configurations");

            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Deleted", "Key", "Language", "Value" },
                values: new object[,]
                {
                    { new Guid("07a1f9cb-7db3-48b1-a9e5-ff01285be299"), true, false, "CompanyName", "en", "Cristian Company" },
                    { new Guid("67abd99c-b673-4f8a-9b58-1aa0b13e3351"), true, false, "MessageLoadingProducts", "en", "Loading product ..." },
                    { new Guid("795bb102-babe-4122-bb4b-2bce21ddffde"), true, false, "TitleFeaturedProducts", "en", "Top Products of Today" },
                    { new Guid("abe36317-8c35-4aca-bc0e-03eda638a30e"), true, false, "NoProductsFound", "en", "No products found" },
                    { new Guid("e2d38dd3-eb12-47b4-8ac1-548230909304"), true, false, "ProductsByPage", "en", "5" },
                    { new Guid("f6b88c72-0460-4393-ad58-a49f8f30d56a"), true, false, "DefaultLanguage", "", "en" }
                });
        }
    }
}
