using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineShoppingCart.Migrations
{
    /// <inheritdoc />
    public partial class LoginHistoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "EncryptedPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "LoginHistory",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OS = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidTill = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DbEntryTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LoginHistory_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LoginHistory_UserId",
                table: "LoginHistory",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LoginHistory");

            migrationBuilder.AlterColumn<string>(
                name: "EncryptedPassword",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
