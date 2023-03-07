using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    public partial class NullsAllowed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_PublisherId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Statuses_StatusId",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "StatusId",
                table: "Tasks",
                type: "nvarchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)");

            migrationBuilder.AlterColumn<string>(
                name: "PublisherId",
                table: "Tasks",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_PublisherId",
                table: "Tasks",
                column: "PublisherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Statuses_StatusId",
                table: "Tasks",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AspNetUsers_PublisherId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Statuses_StatusId",
                table: "Tasks");

            migrationBuilder.AlterColumn<string>(
                name: "StatusId",
                table: "Tasks",
                type: "nvarchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PublisherId",
                table: "Tasks",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420c2f8f-3315-425f-b865-13e9146991b6",
                column: "ConcurrencyStamp",
                value: "56020382-55ff-4f26-859c-304a93e5e846");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e7052-fab1-4848-9057-162971c9e740",
                column: "ConcurrencyStamp",
                value: "ebaf119f-2c15-4913-8188-7a40c9811ad8");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AspNetUsers_PublisherId",
                table: "Tasks",
                column: "PublisherId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Statuses_StatusId",
                table: "Tasks",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
