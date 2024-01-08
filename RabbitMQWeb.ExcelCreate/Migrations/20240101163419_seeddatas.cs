using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RabbitMQWeb.ExcelCreate.Migrations
{
    /// <inheritdoc />
    public partial class seeddatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1689e75d-6c66-4eef-917d-73109d6b207d", 0, "6c759b42-ae9f-41b5-8bb8-7e168692ea16", "deneme2@gmail.com", true, false, null, "DENEME2@GMAİL.COM", "DENEME2", "AQAAAAIAAYagAAAAEBd2JNVT/zULmr0yGmwJ8vuQKRd6s6U9FDGiG75iyYsSAYGm0nyWXEV+xJ9b3vYSFA==", null, false, "74b060cc-4192-49be-9566-b59b5ba55558", false, "deneme2" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "e5d01601-59b1-4192-acad-fbf60f24c617", "deneme@gmail.com", true, false, null, "DENEME@GMAİL.COM", "DENEME", "AQAAAAIAAYagAAAAEAEqkRPjbb+PaYOkRgBIaiVkVe6MWx3iwvG4h8OXPLjvNa04P1FKcKfNyfmwEc2mGA==", null, false, "2dc016e0-5bff-4e25-9814-ab08c815041b", false, "deneme" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1689e75d-6c66-4eef-917d-73109d6b207d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");
        }
    }
}
