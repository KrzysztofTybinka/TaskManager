using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    public partial class IdentityUserTableDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcb49433-5cb8-4d72-8de5-25b7198f7e7d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feffc446-9dd6-4bf0-bb14-083bea3dadab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "420c2f8f-3315-425f-b865-13e9146991b6", "e852f612-6b08-4367-9afa-d56ac9e36fc3", "User", "USER" },
                    { "e45e7052-fab1-4848-9057-162971c9e740", "935dd8e3-1090-4a45-8727-bc5f36be91b7", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "896ef532-034c-4425-8d71-75f90b17e6fa", 0, "a59633c5-4626-4793-8def-a4e9c4e1f37d", "user@user.com", true, false, null, null, null, "AA1X7As/c0Kutejsm/PahpOTLthn0qlTztSgvEmyhVoQqv9S2dpEiGftCMo25Gi3Cg==", null, true, "81b349a7-e182-48f9-955e-d799c26c45d5", false, "user" },
                    { "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168", 0, "c0165eda-c398-43ca-8ad4-f4e4ddf70d4d", "admin@admin.com", true, false, null, null, null, "AKQUmQiSG2CMnL5Te9aLQf7YisDpPFohe6ZzrGyWVMI5eBjoEPR6TwhFWK9nAe8Ebg==", null, true, "278c6739-0711-4b5f-a00c-b5cb28ce2686", false, "admin" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420c2f8f-3315-425f-b865-13e9146991b6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e7052-fab1-4848-9057-162971c9e740");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896ef532-034c-4425-8d71-75f90b17e6fa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168");

            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dcb49433-5cb8-4d72-8de5-25b7198f7e7d", "6c0a1bed-71bd-41bd-8349-340de343ade0", "User", "USER" },
                    { "feffc446-9dd6-4bf0-bb14-083bea3dadab", "bcc62376-8c2a-4d42-88ef-1902230b0107", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "IdentityUser",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c2b4b1b1-a75a-4c40-9fb8-ebde9dbeaf0e", 0, "19f06389-e7e4-4bfb-bd01-eb524117f6c2", "admin@admin.com", true, false, null, null, null, "AE7gAfJniadmwggeNiKzJ5+Tw3Qw/5BCXJMl1x34yF5KRPgwkx3DOsHOLprQFi5/rQ==", null, true, "4d20e86f-d1cf-40fd-8092-e47ba94bbdd0", false, "admin" },
                    { "f7949659-6e4c-4493-9568-7f3efb14995b", 0, "eab05d6e-ddc6-426a-b4d4-a6c388cbcdf5", "user@user.com", true, false, null, null, null, "ABQRwqK4303oJa/eLSz+SuOxpFbFXnJ3urZBHliaKAGVfg2IAF0+SkZ8gNyc256YBQ==", null, true, "a3101c24-e95b-4c71-9891-37355c48a7f7", false, "user" }
                });
        }
    }
}
