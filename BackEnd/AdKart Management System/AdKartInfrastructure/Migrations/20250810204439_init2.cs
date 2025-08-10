using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdKartInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Towns_TownId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("cb1e90cd-8b13-4cba-86bb-25630455da6e"));

            migrationBuilder.DeleteData(
                table: "CoinsContainers",
                keyColumn: "Id",
                keyValue: new Guid("fb192da4-929c-4553-b0d3-426190852cb3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("52733066-94d5-404f-9afb-05915c8aa8ee"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("90bbd9c8-87b2-4d8b-94fd-e87932b2fd2b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f0603044-0352-479d-868f-1b09e7ad5a31"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("39d35f12-aefa-4ab1-890e-6193227f92c2"));

            migrationBuilder.DeleteData(
                table: "Towns",
                keyColumn: "Id",
                keyValue: new Guid("1891054f-2b78-4c99-b6c3-d896a1910465"));

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
                name: "UserId",
                table: "Carts",
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
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

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
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Towns_TownId",
                table: "Users",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "FK_Carts_Users_UserId",
                table: "Carts");

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

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Towns_TownId",
                table: "Users");

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
                name: "IX_Carts_UserId",
                table: "Carts");

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
                name: "UserId",
                table: "Carts");

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
                    { new Guid("39d35f12-aefa-4ab1-890e-6193227f92c2"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7400), true, "Admin", null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7416) },
                    { new Guid("52733066-94d5-404f-9afb-05915c8aa8ee"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7420), true, "Customer", null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7420) },
                    { new Guid("90bbd9c8-87b2-4d8b-94fd-e87932b2fd2b"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7418), true, "ShopOwner", null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7418) }
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "IsActive", "Name", "UpdatedBy", "UpdatedOn" },
                values: new object[] { new Guid("1891054f-2b78-4c99-b6c3-d896a1910465"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7422), true, "Narasaraopet", null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7423) });

            migrationBuilder.InsertData(
                table: "CoinsContainers",
                columns: new[] { "Id", "Coins", "CreatedBy", "CreatedOn", "Discriminator", "IsActive", "TownId", "UpdatedBy", "UpdatedOn" },
                values: new object[,]
                {
                    { new Guid("cb1e90cd-8b13-4cba-86bb-25630455da6e"), 0m, null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7714), "CoinsContainer", true, new Guid("1891054f-2b78-4c99-b6c3-d896a1910465"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7715) },
                    { new Guid("fb192da4-929c-4553-b0d3-426190852cb3"), 0m, null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7740), "TransientCoinsContainer", true, new Guid("1891054f-2b78-4c99-b6c3-d896a1910465"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7741) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Coins", "CreatedBy", "CreatedOn", "Email", "FirstName", "IsActive", "LastName", "PasswordHash", "PhoneNumber", "ProfilePic", "TownId", "UpdatedBy", "UpdatedOn", "UserRoleId" },
                values: new object[] { new Guid("f0603044-0352-479d-868f-1b09e7ad5a31"), "Barampet", 0, null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7767), "ibvramasai1563@gmail.com", "Bala Venkata Rama Sai", true, "Immadisetty", "1234567890", "7382755402", "Pic1", new Guid("1891054f-2b78-4c99-b6c3-d896a1910465"), null, new DateTime(2025, 8, 5, 0, 55, 29, 249, DateTimeKind.Local).AddTicks(7768), new Guid("39d35f12-aefa-4ab1-890e-6193227f92c2") });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Towns_TownId",
                table: "Users",
                column: "TownId",
                principalTable: "Towns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
