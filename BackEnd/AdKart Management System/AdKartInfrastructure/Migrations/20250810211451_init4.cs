using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdKartInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("5c94e4ab-01a0-4e2b-846e-46d32d4d53be"));

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("80ad5a13-57cb-40af-87a5-f269b8c62683"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("65efb54e-1867-46e4-8239-eb52e4cd3852"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("66e2fb6a-b5ac-4473-add8-e85ac1d77681"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("26d693e6-4a88-41ce-b76c-ed7b32c4d166"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fa99fef7-70ee-4b95-ba1d-3222a299eeee"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("c1575d96-9fa5-459b-9cf2-33220951d797"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Carts");

            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Role", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("bf8e59df-4368-4a2a-9082-012adb02bea7"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2556), true, "Customer", null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2557) },
                    { new Guid("e85ba5cd-168c-4d7b-8816-478887cdcf4d"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2536), true, "Admin", null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2550) },
                    { new Guid("eb459dee-f966-445c-b40c-817031712570"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2553), true, "ShopOwner", null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2554) }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("da6e1911-9c1f-4c1e-8c31-7a2308a76f08"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2559), true, "Narasaraopet", null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2560) });

            migrationBuilder.InsertData(
                table: "CoinsContainers",
                columns: new[] { "Id", "Coins", "CreatedBy", "CreatedOn", "Discriminator", "IsActive", "TownId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("34031864-9206-4dd9-bb2f-23cf15f112dd"), 0m, null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2965), "TransientCoinsContainer", true, new Guid("da6e1911-9c1f-4c1e-8c31-7a2308a76f08"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2965) },
                    { new Guid("d619f161-f26a-4f82-945e-561e5a0ff65d"), 0m, null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2921), "CoinsContainer", true, new Guid("da6e1911-9c1f-4c1e-8c31-7a2308a76f08"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2921) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Coins", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "ProfilePic", "TownId", "UpdatedBy", "UpdatedOn", "UserRoleId" },
                values: new object[] { new Guid("3df30ed0-77d1-45c1-92b0-260644286da5"), "Barampet", 0, null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2994), "ibvramasai1563@gmail.com", "Bala Venkata Rama Sai", true, "Immadisetty", "1234567890", "7382755402", "Pic1", new Guid("da6e1911-9c1f-4c1e-8c31-7a2308a76f08"), null, new DateTime(2025, 8, 11, 2, 44, 49, 636, DateTimeKind.Local).AddTicks(2994), new Guid("e85ba5cd-168c-4d7b-8816-478887cdcf4d") });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ShopId",
                table: "Orders",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Shops_ShopId",
                table: "Orders",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Shops_ShopId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ShopId",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("34031864-9206-4dd9-bb2f-23cf15f112dd"));

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("d619f161-f26a-4f82-945e-561e5a0ff65d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bf8e59df-4368-4a2a-9082-012adb02bea7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("eb459dee-f966-445c-b40c-817031712570"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3df30ed0-77d1-45c1-92b0-260644286da5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e85ba5cd-168c-4d7b-8816-478887cdcf4d"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("da6e1911-9c1f-4c1e-8c31-7a2308a76f08"));

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Orders");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Carts",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Role", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("65efb54e-1867-46e4-8239-eb52e4cd3852"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9184), true, "ShopOwner", null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9184) },
                    { new Guid("66e2fb6a-b5ac-4473-add8-e85ac1d77681"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9186), true, "Customer", null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9187) },
                    { new Guid("fa99fef7-70ee-4b95-ba1d-3222a299eeee"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9163), true, "Admin", null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9180) }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("c1575d96-9fa5-459b-9cf2-33220951d797"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9190), true, "Narasaraopet", null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.InsertData(
                table: "CoinsContainers",
                columns: new[] { "Id", "Coins", "CreatedBy", "CreatedOn", "Discriminator", "IsActive", "TownId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("5c94e4ab-01a0-4e2b-846e-46d32d4d53be"), 0m, null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9707), "TransientCoinsContainer", true, new Guid("c1575d96-9fa5-459b-9cf2-33220951d797"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9708) },
                    { new Guid("80ad5a13-57cb-40af-87a5-f269b8c62683"), 0m, null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9671), "CoinsContainer", true, new Guid("c1575d96-9fa5-459b-9cf2-33220951d797"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9672) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Coins", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "ProfilePic", "TownId", "UpdatedBy", "UpdatedOn", "UserRoleId" },
                values: new object[] { new Guid("26d693e6-4a88-41ce-b76c-ed7b32c4d166"), "Barampet", 0, null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9747), "ibvramasai1563@gmail.com", "Bala Venkata Rama Sai", true, "Immadisetty", "1234567890", "7382755402", "Pic1", new Guid("c1575d96-9fa5-459b-9cf2-33220951d797"), null, new DateTime(2025, 8, 11, 2, 31, 0, 802, DateTimeKind.Local).AddTicks(9747), new Guid("fa99fef7-70ee-4b95-ba1d-3222a299eeee") });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
