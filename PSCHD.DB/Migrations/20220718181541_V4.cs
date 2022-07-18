using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "datetime",
                table: "Prices",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldRowVersion: true);

            migrationBuilder.InsertData(
                table: "Finishes",
                columns: new[] { "Id", "finish" },
                values: new object[] { 1, "nonfoil" });

            migrationBuilder.InsertData(
                table: "Finishes",
                columns: new[] { "Id", "finish" },
                values: new object[] { 2, "foil" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Finishes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Finishes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "datetime",
                table: "Prices",
                type: "TEXT",
                rowVersion: true,
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "TEXT",
                oldNullable: true);
        }
    }
}
