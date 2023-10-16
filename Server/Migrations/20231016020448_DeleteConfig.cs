using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class DeleteConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Configurations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Configurations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Configurations",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<bool>(
                name: "Deleted",
                table: "Configurations",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Deleted",
                table: "Configurations");

            migrationBuilder.AlterColumn<string>(
                name: "Value",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Key",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

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
    }
}
