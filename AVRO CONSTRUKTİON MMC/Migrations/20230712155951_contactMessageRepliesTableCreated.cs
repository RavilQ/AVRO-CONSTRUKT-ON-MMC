using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AVRO_CONSTRUKTİON_MMC.Migrations
{
    public partial class contactMessageRepliesTableCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "contactMessageReplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactMessageId = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contactMessageReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_contactMessageReplies_ContactMessages_ContactMessageId",
                        column: x => x.ContactMessageId,
                        principalTable: "ContactMessages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_contactMessageReplies_ContactMessageId",
                table: "contactMessageReplies",
                column: "ContactMessageId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contactMessageReplies");
        }
    }
}
