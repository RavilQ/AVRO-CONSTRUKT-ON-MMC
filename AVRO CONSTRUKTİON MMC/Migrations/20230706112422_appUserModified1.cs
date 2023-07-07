using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVRO_CONSTRUKTİON_MMC.Migrations
{
    public partial class appUserModified1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDefaultPassword",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDefaultPassword",
                table: "AspNetUsers");
        }
    }
}
