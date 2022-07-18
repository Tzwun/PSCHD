using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RelatedMagicCard",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    relatedCardID = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedMagicCard", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedMagicCard_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelatedMagicCard_MagicCardId",
                table: "RelatedMagicCard",
                column: "MagicCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RelatedMagicCard");
        }
    }
}
