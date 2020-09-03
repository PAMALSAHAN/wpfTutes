using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPFTest.EntityFramework.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatedJoin",
                table: "UserTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "UserTable",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateProcessed",
                table: "AssetTransactionTable",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatedJoin",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "UserTable");

            migrationBuilder.DropColumn(
                name: "DateProcessed",
                table: "AssetTransactionTable");
        }
    }
}
