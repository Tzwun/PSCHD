using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colors_MagiCards_MagicCardId",
                table: "Colors");

            migrationBuilder.DropForeignKey(
                name: "FK_Colors_Identity_MagiCards_MagicCardId",
                table: "Colors_Identity");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropIndex(
                name: "IX_Colors_Identity_MagicCardId",
                table: "Colors_Identity");

            migrationBuilder.DropIndex(
                name: "IX_Colors_MagicCardId",
                table: "Colors");

            migrationBuilder.DropColumn(
                name: "MagicCardId",
                table: "Colors_Identity");

            migrationBuilder.DropColumn(
                name: "MagicCardId",
                table: "Colors");

            migrationBuilder.CreateTable(
                name: "AppSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicCardColorIdentities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MagicColorIdentityId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardColorIdentities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardColorIdentities_Colors_Identity_MagicColorIdentityId",
                        column: x => x.MagicColorIdentityId,
                        principalTable: "Colors_Identity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardColorIdentities_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCardColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ColorId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardColors_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardColors_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Keyword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicKeyword", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    Salt = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagicCardKeyword",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    keywordId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCardKeyword", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCardKeyword_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MagicCardKeyword_MagicKeyword_keywordId",
                        column: x => x.keywordId,
                        principalTable: "MagicKeyword",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MagicCollections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicCollections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicCollections_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Vlue = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<int>(type: "INTEGER", nullable: true),
                    SettingId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserSettings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSettings_UserSettings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "UserSettings",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserMagicCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Count = table.Column<int>(type: "INTEGER", nullable: false),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true),
                    MagicCollectionId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMagicCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserMagicCards_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserMagicCards_MagicCollections_MagicCollectionId",
                        column: x => x.MagicCollectionId,
                        principalTable: "MagicCollections",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColorIdentities_MagicCardId",
                table: "MagicCardColorIdentities",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColorIdentities_MagicColorIdentityId",
                table: "MagicCardColorIdentities",
                column: "MagicColorIdentityId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColors_ColorId",
                table: "MagicCardColors",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardColors_MagicCardId",
                table: "MagicCardColors",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardKeyword_keywordId",
                table: "MagicCardKeyword",
                column: "keywordId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCardKeyword_MagicCardId",
                table: "MagicCardKeyword",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicCollections_UserId",
                table: "MagicCollections",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMagicCards_MagicCardId",
                table: "UserMagicCards",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMagicCards_MagicCollectionId",
                table: "UserMagicCards",
                column: "MagicCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_SettingId",
                table: "UserSettings",
                column: "SettingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSettings_UserId",
                table: "UserSettings",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppSettings");

            migrationBuilder.DropTable(
                name: "MagicCardColorIdentities");

            migrationBuilder.DropTable(
                name: "MagicCardColors");

            migrationBuilder.DropTable(
                name: "MagicCardKeyword");

            migrationBuilder.DropTable(
                name: "UserMagicCards");

            migrationBuilder.DropTable(
                name: "UserSettings");

            migrationBuilder.DropTable(
                name: "MagicKeyword");

            migrationBuilder.DropTable(
                name: "MagicCollections");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.AddColumn<int>(
                name: "MagicCardId",
                table: "Colors_Identity",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MagicCardId",
                table: "Colors",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true),
                    keyword = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keywords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Keywords_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Colors_Identity_MagicCardId",
                table: "Colors_Identity",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_MagicCardId",
                table: "Colors",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_MagicCardId",
                table: "Keywords",
                column: "MagicCardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_MagiCards_MagicCardId",
                table: "Colors",
                column: "MagicCardId",
                principalTable: "MagiCards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Colors_Identity_MagiCards_MagicCardId",
                table: "Colors_Identity",
                column: "MagicCardId",
                principalTable: "MagiCards",
                principalColumn: "Id");
        }
    }
}
