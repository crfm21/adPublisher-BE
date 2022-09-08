using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ExameBE.Infrastructure.Migrations
{
    public partial class contact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Ads",
                type: "NVARCHAR(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ads",
                type: "NVARCHAR(400)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(300)");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Ads",
                type: "NVARCHAR(50)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Contact", "CreationDate" },
                values: new object[] { "93XXXXXXX", new DateTime(2022, 6, 24, 13, 40, 14, 74, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Contact", "CreationDate" },
                values: new object[] { "93XXXXXXX", new DateTime(2022, 6, 24, 13, 40, 14, 91, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Contact", "CreationDate", "Subject" },
                values: new object[] { "93XXXXXXX", new DateTime(2022, 6, 24, 13, 40, 14, 91, DateTimeKind.Local).AddTicks(8900), "Mazda CX-5, Loulé, 2018, 40000 Km, 27000€" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Ads");

            migrationBuilder.AlterColumn<string>(
                name: "Subject",
                table: "Ads",
                type: "NVARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Ads",
                type: "NVARCHAR(300)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(400)");

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2022, 6, 22, 21, 55, 44, 561, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2022, 6, 22, 21, 55, 44, 579, DateTimeKind.Local).AddTicks(7840));

            migrationBuilder.UpdateData(
                table: "Ads",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreationDate", "Subject" },
                values: new object[] { new DateTime(2022, 6, 22, 21, 55, 44, 579, DateTimeKind.Local).AddTicks(8540), "Mazda CX-5, 2018, 40000 Km, 27000€" });
        }
    }
}
