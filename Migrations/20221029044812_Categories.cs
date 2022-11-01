using Microsoft.EntityFrameworkCore.Migrations;

namespace ASM1670.Migrations
{
    public partial class Categories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "A",
                column: "ConcurrencyStamp",
                value: "47619441-720c-49e8-91bc-f3e8d763a529");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "B",
                column: "ConcurrencyStamp",
                value: "bcad8aa1-cb7b-43e9-93b8-9081d3aca552");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "C",
                column: "ConcurrencyStamp",
                value: "cdc01efb-8c48-42f5-86b8-98f5f18c1510");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8992f958-5c7c-42b7-804e-3a53d8a4b876", "AQAAAAEAACcQAAAAEACR3jbJwqbXV48ScJc2hatxfmtdoeOdA/ZVaBR8rySp4dvq0y+tnCWa/RZuS/5tRg==", "6969816d-a215-49d7-b07d-9c9d473bb3ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0c3efdb-083e-4db0-96d3-61af34703e81", "AQAAAAEAACcQAAAAEFEiEFz1tWpZSWJFlKA5gC2Nd32y2xIbd/57CBUg5a7hQ7M2LIz4vZeUgz9vC4VU5A==", "5552515a-fcc7-4900-9ab3-51f3cb461d6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22105c56-b778-4338-9539-c8772860bcca", "AQAAAAEAACcQAAAAEA46Ro/6pXDqgWBdFNlCehmDaoHk7gxFeLe/EPCAbG0Gg7RuSjq4+957+Upiu0ewig==", "94f58609-9eaa-45e3-8d51-42dc5f4e0cf2" });
        }
    }
}
