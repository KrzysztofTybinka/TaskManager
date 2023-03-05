using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    public partial class IdentityUserRoleInsert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "420c2f8f-3315-425f-b865-13e9146991b6", "896ef532-034c-4425-8d71-75f90b17e6fa" },
                    { "e45e7052-fab1-4848-9057-162971c9e740", "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896ef532-034c-4425-8d71-75f90b17e6fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3839c665-b7c3-427a-a651-aa0e73f2be98", "AIMFDugbwSJrauyhl1LBMSbxjsmSpenq9v2tsbx+VXzY0p6CcaY+CzhCRcZXtiYIJQ==", "790cf61e-0925-418c-b963-01cda802d78f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c990b42-4cbc-4c05-97b9-31613286ffc3", "AKHyMoyo2+OZMxkCcHb+P6ITlZNff6LgVzgRGJc5fcfuSsVmEapz/f+b+ncEtywp+w==", "45389e97-9589-413f-ba76-946028f80914" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "420c2f8f-3315-425f-b865-13e9146991b6", "896ef532-034c-4425-8d71-75f90b17e6fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e45e7052-fab1-4848-9057-162971c9e740", "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "420c2f8f-3315-425f-b865-13e9146991b6",
                column: "ConcurrencyStamp",
                value: "e852f612-6b08-4367-9afa-d56ac9e36fc3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e45e7052-fab1-4848-9057-162971c9e740",
                column: "ConcurrencyStamp",
                value: "935dd8e3-1090-4a45-8727-bc5f36be91b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "896ef532-034c-4425-8d71-75f90b17e6fa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a59633c5-4626-4793-8def-a4e9c4e1f37d", "AA1X7As/c0Kutejsm/PahpOTLthn0qlTztSgvEmyhVoQqv9S2dpEiGftCMo25Gi3Cg==", "81b349a7-e182-48f9-955e-d799c26c45d5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b2ad1c-f92f-46bf-abb7-170a4ba8d168",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0165eda-c398-43ca-8ad4-f4e4ddf70d4d", "AKQUmQiSG2CMnL5Te9aLQf7YisDpPFohe6ZzrGyWVMI5eBjoEPR6TwhFWK9nAe8Ebg==", "278c6739-0711-4b5f-a00c-b5cb28ce2686" });
        }
    }
}
