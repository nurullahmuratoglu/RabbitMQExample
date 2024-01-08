using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RabbitMQWeb.ExcelCreate.Migrations
{
    /// <inheritdoc />
    public partial class updatenullablefilepath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1689e75d-6c66-4eef-917d-73109d6b207d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9");

            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "UserFiles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FilePath",
                table: "UserFiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1689e75d-6c66-4eef-917d-73109d6b207d", 0, "0f8395b9-81f9-40de-b26f-d6a279dbeed5", "deneme2@gmail.com", true, false, null, "DENEME2@GMAİL.COM", "DENEME2", "AQAAAAIAAYagAAAAEO3r9xKtSmeYYAbYwkGFw/j3coMFjrrcOrneU8V0tI0ouTtbSVpAizKjZySIrDXS9A==", null, false, "618d3142-eea7-4b29-b119-65f132532210", false, "deneme2" },
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "363f666b-bc2b-47e6-a19b-f7dcca0921d6", "deneme@gmail.com", true, false, null, "DENEME@GMAİL.COM", "DENEME", "AQAAAAIAAYagAAAAEPXtbsR79qNolC9hkDrIU648+ruM1E0jONtt/yCnEDEyLlaJQoZ6nzeg1KhyFe+1WQ==", null, false, "06297dc2-6a60-46fd-8d5b-063ff5a98fa1", false, "deneme" }
                });
        }
    }
}
