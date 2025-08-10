using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdKartInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AdWatches_Advertisements_AdvertisementId",
                table: "AdWatches");

            migrationBuilder.DropForeignKey(
                name: "FK_AdWatches_Users_UserId",
                table: "AdWatches");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId1",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId1",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Shops_ShopId1",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Shops_Categories_CategoryId1",
                table: "Shops");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Shops_CategoryId1",
                table: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Products_ShopId1",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Orders_UserId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderItems_OrderId1",
                table: "OrderItems");

            migrationBuilder.DropIndex(
                name: "IX_CartItems_CartId1",
                table: "CartItems");

            migrationBuilder.DropIndex(
                name: "IX_AdWatches_AdvertisementId",
                table: "AdWatches");

            migrationBuilder.DropIndex(
                name: "IX_AdWatches_UserId",
                table: "AdWatches");

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("49f14b93-8731-4559-8ca5-bae79f0899c6"));

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("5b5ae69b-e6f3-4c28-b3c3-48a82756fc5b"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3fcf8635-7010-4abf-8363-6ea02d4ca09d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dfbc2f57-7acf-429e-8d49-3428926ff468"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("500449f7-3765-4b4b-a117-acab8eb3db46"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("58ee79ec-f920-4c56-a09f-5c37d3a8407c"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("0ea4872a-302c-4da2-8a8a-b266f1088acf"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "CategoryId1",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "ShopId1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "OrderId1",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CartId1",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "AdvertisementId",
                table: "AdWatches");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "AdWatches");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId1",
                table: "Shops",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ShopId1",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId1",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CartId1",
                table: "CartItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AdvertisementId",
                table: "AdWatches",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "AdWatches",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Role", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("3fcf8635-7010-4abf-8363-6ea02d4ca09d"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3215), true, "ShopOwner", null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3216) },
                    { new Guid("58ee79ec-f920-4c56-a09f-5c37d3a8407c"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3191), true, "Admin", null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3211) },
                    { new Guid("dfbc2f57-7acf-429e-8d49-3428926ff468"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3218), true, "Customer", null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3219) }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("0ea4872a-302c-4da2-8a8a-b266f1088acf"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3222), true, "Narasaraopet", null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.InsertData(
                table: "CoinsContainers",
                columns: new[] { "Id", "Coins", "CreatedBy", "CreatedOn", "Discriminator", "IsActive", "TownId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("49f14b93-8731-4559-8ca5-bae79f0899c6"), 0m, null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3936), "TransientCoinsContainer", true, new Guid("0ea4872a-302c-4da2-8a8a-b266f1088acf"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3937) },
                    { new Guid("5b5ae69b-e6f3-4c28-b3c3-48a82756fc5b"), 0m, null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3893), "CoinsContainer", true, new Guid("0ea4872a-302c-4da2-8a8a-b266f1088acf"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3897) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Coins", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "ProfilePic", "TownId", "UpdatedBy", "UpdatedOn", "UserRoleId" },
                values: new object[] { new Guid("500449f7-3765-4b4b-a117-acab8eb3db46"), "Barampet", 0, null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3975), "ibvramasai1563@gmail.com", "Bala Venkata Rama Sai", true, "Immadisetty", "1234567890", "7382755402", "Pic1", new Guid("0ea4872a-302c-4da2-8a8a-b266f1088acf"), null, new DateTime(2025, 8, 11, 2, 14, 36, 863, DateTimeKind.Local).AddTicks(3976), new Guid("58ee79ec-f920-4c56-a09f-5c37d3a8407c") });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CategoryId1",
                table: "Shops",
                column: "CategoryId1");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ShopId1",
                table: "Products",
                column: "ShopId1");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId1",
                table: "OrderItems",
                column: "OrderId1");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId1",
                table: "CartItems",
                column: "CartId1");

            migrationBuilder.CreateIndex(
                name: "IX_AdWatches_AdvertisementId",
                table: "AdWatches",
                column: "AdvertisementId");

            migrationBuilder.CreateIndex(
                name: "IX_AdWatches_UserId",
                table: "AdWatches",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AdWatches_Advertisements_AdvertisementId",
                table: "AdWatches",
                column: "AdvertisementId",
                principalTable: "Advertisements",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AdWatches_Users_UserId",
                table: "AdWatches",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId1",
                table: "CartItems",
                column: "CartId1",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId1",
                table: "OrderItems",
                column: "OrderId1",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Shops_ShopId1",
                table: "Products",
                column: "ShopId1",
                principalTable: "Shops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shops_Categories_CategoryId1",
                table: "Shops",
                column: "CategoryId1",
                principalTable: "Categories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
