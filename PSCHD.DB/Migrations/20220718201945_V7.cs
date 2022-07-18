using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArtistIDs_MagiCards_MagicCardId",
                table: "ArtistIDs");

            migrationBuilder.DropForeignKey(
                name: "FK_CardArtistsId_ArtistIDs_artistIdId",
                table: "CardArtistsId");

            migrationBuilder.DropForeignKey(
                name: "FK_MagicCardKeyword_MagiCards_MagicCardId",
                table: "MagicCardKeyword");

            migrationBuilder.DropForeignKey(
                name: "FK_MagicCardKeyword_MagicKeyword_keywordId",
                table: "MagicCardKeyword");

            migrationBuilder.DropIndex(
                name: "IX_ArtistIDs_MagicCardId",
                table: "ArtistIDs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MagicKeyword",
                table: "MagicKeyword");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MagicCardKeyword",
                table: "MagicCardKeyword");

            migrationBuilder.DropColumn(
                name: "MagicCardId",
                table: "ArtistIDs");

            migrationBuilder.RenameTable(
                name: "MagicKeyword",
                newName: "Keywords");

            migrationBuilder.RenameTable(
                name: "MagicCardKeyword",
                newName: "MagicCardKeywords");

            migrationBuilder.RenameColumn(
                name: "artistIdId",
                table: "CardArtistsId",
                newName: "ArtistIdId");

            migrationBuilder.RenameIndex(
                name: "IX_CardArtistsId_artistIdId",
                table: "CardArtistsId",
                newName: "IX_CardArtistsId_ArtistIdId");

            migrationBuilder.RenameIndex(
                name: "IX_MagicCardKeyword_MagicCardId",
                table: "MagicCardKeywords",
                newName: "IX_MagicCardKeywords_MagicCardId");

            migrationBuilder.RenameIndex(
                name: "IX_MagicCardKeyword_keywordId",
                table: "MagicCardKeywords",
                newName: "IX_MagicCardKeywords_keywordId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MagicCardKeywords",
                table: "MagicCardKeywords",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardArtistsId_ArtistIDs_ArtistIdId",
                table: "CardArtistsId",
                column: "ArtistIdId",
                principalTable: "ArtistIDs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MagicCardKeywords_Keywords_keywordId",
                table: "MagicCardKeywords",
                column: "keywordId",
                principalTable: "Keywords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MagicCardKeywords_MagiCards_MagicCardId",
                table: "MagicCardKeywords",
                column: "MagicCardId",
                principalTable: "MagiCards",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CardArtistsId_ArtistIDs_ArtistIdId",
                table: "CardArtistsId");

            migrationBuilder.DropForeignKey(
                name: "FK_MagicCardKeywords_Keywords_keywordId",
                table: "MagicCardKeywords");

            migrationBuilder.DropForeignKey(
                name: "FK_MagicCardKeywords_MagiCards_MagicCardId",
                table: "MagicCardKeywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MagicCardKeywords",
                table: "MagicCardKeywords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Keywords",
                table: "Keywords");

            migrationBuilder.RenameTable(
                name: "MagicCardKeywords",
                newName: "MagicCardKeyword");

            migrationBuilder.RenameTable(
                name: "Keywords",
                newName: "MagicKeyword");

            migrationBuilder.RenameColumn(
                name: "ArtistIdId",
                table: "CardArtistsId",
                newName: "artistIdId");

            migrationBuilder.RenameIndex(
                name: "IX_CardArtistsId_ArtistIdId",
                table: "CardArtistsId",
                newName: "IX_CardArtistsId_artistIdId");

            migrationBuilder.RenameIndex(
                name: "IX_MagicCardKeywords_MagicCardId",
                table: "MagicCardKeyword",
                newName: "IX_MagicCardKeyword_MagicCardId");

            migrationBuilder.RenameIndex(
                name: "IX_MagicCardKeywords_keywordId",
                table: "MagicCardKeyword",
                newName: "IX_MagicCardKeyword_keywordId");

            migrationBuilder.AddColumn<int>(
                name: "MagicCardId",
                table: "ArtistIDs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MagicCardKeyword",
                table: "MagicCardKeyword",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MagicKeyword",
                table: "MagicKeyword",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistIDs_MagicCardId",
                table: "ArtistIDs",
                column: "MagicCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArtistIDs_MagiCards_MagicCardId",
                table: "ArtistIDs",
                column: "MagicCardId",
                principalTable: "MagiCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CardArtistsId_ArtistIDs_artistIdId",
                table: "CardArtistsId",
                column: "artistIdId",
                principalTable: "ArtistIDs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MagicCardKeyword_MagiCards_MagicCardId",
                table: "MagicCardKeyword",
                column: "MagicCardId",
                principalTable: "MagiCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MagicCardKeyword_MagicKeyword_keywordId",
                table: "MagicCardKeyword",
                column: "keywordId",
                principalTable: "MagicKeyword",
                principalColumn: "Id");
        }
    }
}
