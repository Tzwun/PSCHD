using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PSCHD.DB.Migrations
{
    public partial class V0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Leglities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    standard = table.Column<int>(type: "INTEGER", nullable: false),
                    future = table.Column<int>(type: "INTEGER", nullable: false),
                    historic = table.Column<int>(type: "INTEGER", nullable: false),
                    gladiator = table.Column<int>(type: "INTEGER", nullable: false),
                    pioneer = table.Column<int>(type: "INTEGER", nullable: false),
                    modern = table.Column<int>(type: "INTEGER", nullable: false),
                    legacy = table.Column<int>(type: "INTEGER", nullable: false),
                    pauper = table.Column<int>(type: "INTEGER", nullable: false),
                    vintage = table.Column<int>(type: "INTEGER", nullable: false),
                    penny = table.Column<int>(type: "INTEGER", nullable: false),
                    commander = table.Column<int>(type: "INTEGER", nullable: false),
                    brawl = table.Column<int>(type: "INTEGER", nullable: false),
                    historicbrawl = table.Column<int>(type: "INTEGER", nullable: false),
                    alchemy = table.Column<int>(type: "INTEGER", nullable: false),
                    paupercommander = table.Column<int>(type: "INTEGER", nullable: false),
                    duel = table.Column<int>(type: "INTEGER", nullable: false),
                    oldschool = table.Column<int>(type: "INTEGER", nullable: false),
                    premodern = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leglities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MagiCards",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    _object = table.Column<string>(type: "TEXT", nullable: true),
                    string_id = table.Column<string>(type: "TEXT", nullable: true),
                    oracle_id = table.Column<string>(type: "TEXT", nullable: true),
                    mtgo_id = table.Column<int>(type: "INTEGER", nullable: true),
                    mtgo_foil_id = table.Column<int>(type: "INTEGER", nullable: true),
                    tcgplayer_id = table.Column<int>(type: "INTEGER", nullable: true),
                    cardmarket_id = table.Column<int>(type: "INTEGER", nullable: true),
                    name = table.Column<string>(type: "TEXT", nullable: true),
                    lang = table.Column<string>(type: "TEXT", nullable: true),
                    released_at = table.Column<string>(type: "TEXT", nullable: true),
                    uri = table.Column<string>(type: "TEXT", nullable: true),
                    scryfall_uri = table.Column<string>(type: "TEXT", nullable: true),
                    layout = table.Column<string>(type: "TEXT", nullable: true),
                    highres_image = table.Column<bool>(type: "INTEGER", nullable: false),
                    image_status = table.Column<string>(type: "TEXT", nullable: true),
                    mana_cost = table.Column<string>(type: "TEXT", nullable: true),
                    cmc = table.Column<double>(type: "REAL", nullable: true),
                    type_line = table.Column<string>(type: "TEXT", nullable: true),
                    oracle_text = table.Column<string>(type: "TEXT", nullable: true),
                    power = table.Column<string>(type: "TEXT", nullable: true),
                    toughness = table.Column<string>(type: "TEXT", nullable: true),
                    reserved = table.Column<bool>(type: "INTEGER", nullable: false),
                    foil = table.Column<bool>(type: "INTEGER", nullable: false),
                    nonfoil = table.Column<bool>(type: "INTEGER", nullable: false),
                    oversized = table.Column<bool>(type: "INTEGER", nullable: false),
                    promo = table.Column<bool>(type: "INTEGER", nullable: false),
                    reprint = table.Column<bool>(type: "INTEGER", nullable: false),
                    variation = table.Column<bool>(type: "INTEGER", nullable: false),
                    Cardset_id = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_name = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_type = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_uri = table.Column<string>(type: "TEXT", nullable: true),
                    Cardset_search_uri = table.Column<string>(type: "TEXT", nullable: true),
                    scryfall_set_uri = table.Column<string>(type: "TEXT", nullable: true),
                    rulings_uri = table.Column<string>(type: "TEXT", nullable: true),
                    prints_search_uri = table.Column<string>(type: "TEXT", nullable: true),
                    collector_number = table.Column<string>(type: "TEXT", nullable: true),
                    digital = table.Column<bool>(type: "INTEGER", nullable: false),
                    rarity = table.Column<string>(type: "TEXT", nullable: true),
                    flavor_text = table.Column<string>(type: "TEXT", nullable: true),
                    card_back_id = table.Column<string>(type: "TEXT", nullable: true),
                    artist = table.Column<string>(type: "TEXT", nullable: true),
                    illustration_id = table.Column<string>(type: "TEXT", nullable: true),
                    border_color = table.Column<string>(type: "TEXT", nullable: true),
                    frame = table.Column<string>(type: "TEXT", nullable: true),
                    full_art = table.Column<bool>(type: "INTEGER", nullable: false),
                    textless = table.Column<bool>(type: "INTEGER", nullable: false),
                    booster = table.Column<bool>(type: "INTEGER", nullable: false),
                    story_spotlight = table.Column<bool>(type: "INTEGER", nullable: false),
                    edhrec_rank = table.Column<int>(type: "INTEGER", nullable: false),
                    legalitiesId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagiCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagiCards_Leglities_legalitiesId",
                        column: x => x.legalitiesId,
                        principalTable: "Leglities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ArtistIDs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    artistId = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistIDs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistIDs_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magicColor = table.Column<char>(type: "TEXT", nullable: false),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Colors_Identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magicColorIdentity = table.Column<char>(type: "TEXT", nullable: false),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors_Identity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Colors_Identity_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Finishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    finish = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Finishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Finishes_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ImageUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    ImageSize = table.Column<int>(type: "INTEGER", nullable: false),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUris_MagiCards_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Keywords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    keyword = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "MagicGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    magicGame = table.Column<string>(type: "TEXT", nullable: true),
                    MagicCardId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MagicGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MagicGames_MagiCards_MagicCardId",
                        column: x => x.MagicCardId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MultiverseIds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    multiVerseId = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MultiverseIds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MultiverseIds_MagiCards_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RelatedUris",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    URI = table.Column<string>(type: "TEXT", nullable: true),
                    Source = table.Column<string>(type: "TEXT", nullable: true),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RelatedUris_MagiCards_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    currency = table.Column<string>(type: "TEXT", nullable: true),
                    FinishId = table.Column<int>(type: "INTEGER", nullable: true),
                    datetime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ParentId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prices_Finishes_FinishId",
                        column: x => x.FinishId,
                        principalTable: "Finishes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Prices_MagiCards_ParentId",
                        column: x => x.ParentId,
                        principalTable: "MagiCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistIDs_MagicCardId",
                table: "ArtistIDs",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_MagicCardId",
                table: "Colors",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Colors_Identity_MagicCardId",
                table: "Colors_Identity",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Finishes_MagicCardId",
                table: "Finishes",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ImageUris_ParentId",
                table: "ImageUris",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Keywords_MagicCardId",
                table: "Keywords",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MagiCards_legalitiesId",
                table: "MagiCards",
                column: "legalitiesId");

            migrationBuilder.CreateIndex(
                name: "IX_MagicGames_MagicCardId",
                table: "MagicGames",
                column: "MagicCardId");

            migrationBuilder.CreateIndex(
                name: "IX_MultiverseIds_ParentId",
                table: "MultiverseIds",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_FinishId",
                table: "Prices",
                column: "FinishId");

            migrationBuilder.CreateIndex(
                name: "IX_Prices_ParentId",
                table: "Prices",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedUris_ParentId",
                table: "RelatedUris",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistIDs");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Colors_Identity");

            migrationBuilder.DropTable(
                name: "ImageUris");

            migrationBuilder.DropTable(
                name: "Keywords");

            migrationBuilder.DropTable(
                name: "MagicGames");

            migrationBuilder.DropTable(
                name: "MultiverseIds");

            migrationBuilder.DropTable(
                name: "Prices");

            migrationBuilder.DropTable(
                name: "RelatedUris");

            migrationBuilder.DropTable(
                name: "Finishes");

            migrationBuilder.DropTable(
                name: "MagiCards");

            migrationBuilder.DropTable(
                name: "Leglities");
        }
    }
}
