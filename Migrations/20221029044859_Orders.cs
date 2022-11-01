using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM1670.Migrations
{
    public partial class Orders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "4d42724d-2389-49d7-ae3b-44259aecb3a5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "fe77afd0-b252-4957-9601-338f3931f5ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "90c07d53-9cf6-4072-a9d0-bdbeede8de1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65182ab7-e4dd-4dae-8ffe-63c04a31a1e8", "AQAAAAEAACcQAAAAEPehp6xqhRXmjgynhQhkgX8edUgBt3IbELVd5dXZj+fRunTmIBhxt57XdnAhbVKM9A==", "c44f6d01-addd-4d9b-9efc-273c3c1fc0ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c926485d-91a7-47bc-b2e2-27e8d25ff897", "AQAAAAEAACcQAAAAEEqEKxQG9pcQ0Fe8JafO2qXZILm/UAsEGdIfFBaSO28rOlDlrgijkzwJPP/7jH30CA==", "e7894b98-1856-41bc-bcc5-e7c88fb1e525" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7786d90-fb7c-4ecf-9054-99aa13f56c22", "AQAAAAEAACcQAAAAEHI3KcPuan5tQ/Xir6QjGxq9Xs4zW/klqOK8RzGllBx9JXHh9wyNpN/D3vgi0zUJJw==", "750ccaae-0fbd-477d-8184-f4e77ab679c8" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "ba5bc540-fffe-464d-8b96-794eb32199d9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "c2e25b7b-67d5-4430-8977-43120c31fc47");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "fffb2a4f-4fa2-48c2-9ac6-3506fa1a37c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "160d2fd6-66d1-41a0-bf7e-060201bb1fef", "AQAAAAEAACcQAAAAELYn6f8FBqHr4xYYOWnC9CzDlBlv+htM6/1I0ABgN8DBdRvZCpcdwJCxd60qt1FfvA==", "5b4d854f-de7e-47a9-aa20-215ac0d7a778" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c33693f-9301-4c95-be98-63c6ed75efea", "AQAAAAEAACcQAAAAEO/yAKI0Hjxihu3uJeJM6d0R+oKFHnlvGNNHKcEKQqkpUgFxpLEP6AL4oYW1u1X6Lg==", "8cbd8dc0-ffaf-42c3-ab2a-533a7d155cf2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9039ed6-86b1-4b34-965d-6fe51def1204", "AQAAAAEAACcQAAAAEC1GcocIIJXqkuFDqiUkUCoUCAc/iHpWdOrrEpmpVIUr7LANlcxORtUNsZpkKwCrkg==", "ef7acd2c-63ae-40aa-afac-6ed139334d9e" });
        }
    }
}
