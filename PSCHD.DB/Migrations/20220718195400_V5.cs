using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardArtistsId",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    artistIdId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardArtistsId", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CardArtistsId_ArtistIDs_artistIdId",
                        column: x => x.artistIdId,
                        principalTable: "ArtistIDs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CardArtistsId_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardArtistsId_artistIdId",
                table: "CardArtistsId",
                column: "artistIdId");

            migrationBuilder.CreateIndex(
                name: "IX_CardArtistsId_MagicCardId",
                table: "CardArtistsId",
                column: "MagicCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardArtistsId");
        }
    }
}
