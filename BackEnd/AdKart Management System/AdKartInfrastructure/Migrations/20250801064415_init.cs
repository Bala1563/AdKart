using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdKartInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "[User]",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TownId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProfilePic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Coins = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_[User]", x => x.Id);
                    table.ForeignKey(
                        name: "FK_[User]_[User]_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "[User]",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_[User]_[User]_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "[User]",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Town",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Town", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Town_[User]_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "[User]",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Town_[User]_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "[User]",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRole_[User]_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "[User]",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRole_[User]_UpdatedBy",
                        column: x => x.UpdatedBy,
                        principalTable: "[User]",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_[User]_CreatedBy",
                table: "[User]",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_[User]_PhoneNumber",
                table: "[User]",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_[User]_TownId",
                table: "[User]",
                column: "TownId");

            migrationBuilder.CreateIndex(
                name: "IX_[User]_UpdatedBy",
                table: "[User]",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_[User]_UserRoleId",
                table: "[User]",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Town_CreatedBy",
                table: "Town",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Town_Name",
                table: "Town",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Town_UpdatedBy",
                table: "Town",
                column: "UpdatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_CreatedBy",
                table: "UserRole",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_Role",
                table: "UserRole",
                column: "Role",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_UpdatedBy",
                table: "UserRole",
                column: "UpdatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_[User]_Town_TownId",
                table: "[User]",
                column: "TownId",
                principalTable: "Town",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_[User]_UserRole_UserRoleId",
                table: "[User]",
                column: "UserRoleId",
                principalTable: "UserRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_[User]_Town_TownId",
                table: "[User]");

            migrationBuilder.DropForeignKey(
                name: "FK_[User]_UserRole_UserRoleId",
                table: "[User]");

            migrationBuilder.DropTable(
                name: "Town");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "[User]");
        }
    }
}
