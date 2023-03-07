using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    public partial class PublishDateNullsAllowed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Tasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420c2f8f-3315-425f-b865-13e9146991b6",
                column: "ConcurrencyStamp",
                value: "9d4a708d-981d-4746-9b05-38d20392762e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e7052-fab1-4848-9057-162971c9e740",
                column: "ConcurrencyStamp",
                value: "d3ddd957-d5a7-470e-804a-c80e8253c63c");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PublishDate",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420c2f8f-3315-425f-b865-13e9146991b6",
                column: "ConcurrencyStamp",
                value: "6c0897b4-827f-42e8-9685-cb458e6c0c08");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e7052-fab1-4848-9057-162971c9e740",
                column: "ConcurrencyStamp",
                value: "c34133f8-a9ee-4518-96e6-cda1cc35ab0d");
        }
    }
}
