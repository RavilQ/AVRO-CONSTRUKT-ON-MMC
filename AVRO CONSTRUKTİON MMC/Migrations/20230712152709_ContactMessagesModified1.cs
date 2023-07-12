using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVRO_CONSTRUKTİON_MMC.Migrations
{
    public partial class ContactMessagesModified1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "ContactMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "ContactMessages");
        }
    }
}
