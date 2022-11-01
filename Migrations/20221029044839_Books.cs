using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM1670.Migrations
{
    public partial class Books : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "035ba0f9-ac27-4fb3-8c32-bf02e0b2a8e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "8b6396d9-b70d-4051-ad56-bc830a0a9803");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "728f7082-1389-41cc-8550-7005b606a372");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5fe2f784-b50a-48c6-8bfe-c0f9aecf9974", "AQAAAAEAACcQAAAAEOwcaaj2Lsz8qzfcXdtLcC+Y9CklKDD8L0Clshn5KINfvyhNv1zkCLZDns9re9mcwQ==", "300f288d-a5db-4b34-9b8a-dfbcad42df11" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de0917e3-98d3-42f2-b95f-973fa72d24b4", "AQAAAAEAACcQAAAAEAuk00vVdpPtHquj+cgkov2HGgRZ/PeGJGODdz65/QpmM+s6QZHjkAQBu/fNVZ3C2Q==", "eff1d6c1-8204-4b23-952b-c34bc9d34926" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6607c47-f4bc-4922-8fd5-2c1803a2b658", "AQAAAAEAACcQAAAAEDXylsvYNVi+bZeNqoN/TR7uUTWQ+OfkS3x/hyb+L9z1lyOhIATrT7DSb91sN0e9kA==", "c3234322-e3e9-449d-8424-a1f0d503e3ea" });
        }
    }
}
