using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    public partial class UserContentDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "420c2f8f-3315-425f-b865-13e9146991b6", "896ef532-034c-4425-8d71-75f90b17e6fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e45e7052-fab1-4848-9057-162971c9e740", "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896ef532-034c-4425-8d71-75f90b17e6fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420c2f8f-3315-425f-b865-13e9146991b6",
                column: "ConcurrencyStamp",
                value: "0055b89a-6e1d-4923-a7d8-d884a3d8bc51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e7052-fab1-4848-9057-162971c9e740",
                column: "ConcurrencyStamp",
                value: "975e151b-6a09-4559-b98e-3643121d0d10");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "896ef532-034c-4425-8d71-75f90b17e6fa", 0, "3839c665-b7c3-427a-a651-aa0e73f2be98", "user@user.com", true, false, null, null, null, "AIMFDugbwSJrauyhl1LBMSbxjsmSpenq9v2tsbx+VXzY0p6CcaY+CzhCRcZXtiYIJQ==", null, true, "790cf61e-0925-418c-b963-01cda802d78f", false, "user" },
                    { "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168", 0, "4c990b42-4cbc-4c05-97b9-31613286ffc3", "admin@admin.com", true, false, null, null, null, "AKHyMoyo2+OZMxkCcHb+P6ITlZNff6LgVzgRGJc5fcfuSsVmEapz/f+b+ncEtywp+w==", null, true, "45389e97-9589-413f-ba76-946028f80914", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "420c2f8f-3315-425f-b865-13e9146991b6", "896ef532-034c-4425-8d71-75f90b17e6fa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "e45e7052-fab1-4848-9057-162971c9e740", "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168" });
        }
    }
}
