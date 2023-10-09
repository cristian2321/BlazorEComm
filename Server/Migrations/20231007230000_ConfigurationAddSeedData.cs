using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEComm.Server.Migrations
{
    public partial class ConfigurationAddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Configurations",
                columns: new[] { "Id", "Activ", "Key", "Value" },
                values: new object[] { new Guid("007181e9-de7a-411d-9544-225663b78196"), true, "ProductsByPage", "5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Configurations",
                keyColumn: "Id",
                keyValue: new Guid("007181e9-de7a-411d-9544-225663b78196"));
        }
    }
}
